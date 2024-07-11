using System.Text.Json;

namespace CodeWars;

public class Program
{
    static void Main()
    {
        Console.Write("Enter PhoneNumber: ");
        var phone = Console.ReadLine();

        var normalizedPhone = phone.NormalizePhoneNumber();

        Console.WriteLine("Entered phoneNumber => " + normalizedPhone);

    }

    public static bool XO(string input)
    {

        input = input.ToLower();
        return input.Count(c => c == 'o') == input.Count(c => c == 'x');
    }

    public static String Accum(string s)
    {
        return string.Join("-",
            s.Select((c, i) => char.ToUpper(c).ToString().PadRight(i + 1, char.ToLower(c))));
    }
}

