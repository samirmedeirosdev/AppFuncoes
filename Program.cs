using System.Text.RegularExpressions;

namespace AppFuncoes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Remover caracter especial e espaço
            string value_caracter_especial = "ABS_ rteste; &%";
            Console.WriteLine(Regex.Replace(value_caracter_especial, "[^0-9a-zA-Z]+", ""));

            // Converter string em DateTime
            string data_string = "20241204091516";
            DateTime dataEmDateTime = DateTime.ParseExact(data_string, "yyyyMMddHHmmss", null);
            Console.WriteLine(dataEmDateTime);

        }
    }
}
