using AuthController.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace AuthController.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserAPIDbContext dbContext;

        public AuthController(UserAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            // Check if the username and password are valid
            var user = dbContext.User.Include(u => u.OTPInfo).FirstOrDefault(u => u.UserName == request.Username);

            if (user == null || !VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
            {
                return BadRequest(new { message = "Invalid username or password" });
            }

            // Generate and save OTP code
            var otpCode = GenerateOTPCode();
            user.OTPInfo = new OTPInfo
            {
                OTPCode = otpCode,
                OTPExpiration = DateTime.UtcNow.AddMinutes(5) // OTP code expires in 5 minutes
            };

            dbContext.SaveChanges();

            // Return OTP code to the client
            return Ok(new { otpCode });
        }

        [HttpPost("otp")]
        public IActionResult VerifyOTP(OTPRequest request)
        {
            var user = dbContext.User.Include(u => u.OTPInfo).FirstOrDefault(u => u.UserName == request.Username);

            if (user == null || user.OTPInfo == null || user.OTPInfo.OTPExpiration <= DateTime.UtcNow || user.OTPInfo.OTPCode != request.OTPCode)
            {
                return BadRequest(new { message = "Invalid OTP code" });
            }

            // OTP code is valid, perform further authentication or redirect to a secure page
            // ...

            // Clear OTP code and expiration
            user.OTPInfo = null;

            dbContext.SaveChanges();

            return Ok(new { message = "OTP code verified successfully" });
        }

        private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            using var hmac = new HMACSHA512(storedSalt);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != storedHash[i])
                {
                    return false;
                }
            }

            return true;
        }

        private static string GenerateOTPCode()
        {
            // Generate a random OTP code (e.g., a 6-digit number)
            var random = new Random();
            var otpCode = random.Next(100000, 999999).ToString();

            return otpCode;
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class OTPRequest
    {
        public string Username { get; set; }
        public string OTPCode { get; set; }
    }
}
