public class OTPInfo
{
    public int Id { get; set; } // Example primary key property

    public string OTPCode { get; set; }
    public DateTime? OTPExpiration { get; set; }
}

public class User
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    public OTPInfo OTPInfo { get; set; }
}
