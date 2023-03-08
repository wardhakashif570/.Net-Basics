// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;

string firstname;
string lasttname;
Console.Write("Enter a first name: ");
firstname = Console.ReadLine(); 
Console.Write("Enter a last name: ");
lasttname = Console.ReadLine();
//Console.WriteLine("FirstName:" + firstname + ""+ "LastName" + lasttname);
Console.WriteLine("Hello {0} {1}",firstname,lasttname);

Console.ReadLine();

//Console.WriteLine (Cursor on next Line and Console.Write cursor on same Line)