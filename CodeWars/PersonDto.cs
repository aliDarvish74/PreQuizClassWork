using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars;

public class PersonDto
{
    public PersonDto(string firstName, string nationalCode, string userName)
    {
        Name = firstName;
        Code = nationalCode;
        Account = userName;
    }
    public string Name { get; set; }
    public string Code { get; set; }
    public string Account { get; set; }
}
