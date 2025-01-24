using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;

namespace AppFuncoes
{
    public class Program
    {
        #region valida_img_base64
        //Verifica se img base64 é valida
        public static bool IsBase64String(string base64)
        {
            Span<byte> buffer = new Span<byte>(new byte[base64.Length]);
            return Convert.TryFromBase64String(base64, buffer, out int bytesParsed);
        }
        #endregion

        static void Main(string[] args)
        {
            #region caracter_especial
            // Remover caracter especial e espaço
            string value_caracter_especial = "ABS_ rteste; &%";
            Console.WriteLine(Regex.Replace(value_caracter_especial, "[^0-9a-zA-Z]+", ""));
            #endregion

            #region string_to_datetime
            // Converter string em DateTime
            string data_string = "20241204091516";
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime dataEmDateTime = DateTime.ParseExact(data_string, "yyyyMMddHHmmss", provider);
            Console.WriteLine(dataEmDateTime);
            #endregion

            #region download_img_convert_base64
            //download de imagem internet e converter em base 64
            string url = "https://img.freepik.com/fotos-premium/uma-imagem-aproximada-de-um-olho_410516-7158.jpg";
            using (var client = new WebClient())
            {
                var bytes = client.DownloadData(url);
                var base64String = Convert.ToBase64String(bytes);
                Console.WriteLine("image/png;base64," + base64String);
                if (IsBase64String(base64String))
                {

                    try
                    {
                        Console.WriteLine("Valid Image!!!");
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);

                    }
                }
                else
                    Console.WriteLine("Invalid Image!!!");
            }
            #endregion

        }
    }
}
