using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars;

public class Person
{
    public Person(string firstName, string nationalCode, string userName, string password)
    {
        FirstName = firstName;
        NationanlCode = nationalCode;
        UserName = userName;
        Password = password;
    }
    public int Id { get; set; } = new Random().Next(1, 1000);
    public string FirstName { get; set; }
    public string NationanlCode { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}
