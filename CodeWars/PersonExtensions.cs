using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars;

public static class PersonExtensions
{
    public static PersonDto MapPersonToPersonDto(this Person person)
    {
        return new PersonDto(person.FirstName, person.NationanlCode, person.UserName);
    }

    public static string NormalizePhoneNumber(this string phoneNumber)
    {
        if (phoneNumber.StartsWith("+98"))
            return phoneNumber.Replace("+98", "0");

        return phoneNumber;
    }
}
