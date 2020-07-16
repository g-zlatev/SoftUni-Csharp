using System;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#+([A-Z][A-Z;a-z;0-9]{4,}[A-Z])@#+";

            int count = int.Parse(Console.ReadLine());
            string barcode = "";
            string productGroup = "";

            for (int i = 0; i < count; i++)
            {
                barcode = Console.ReadLine();
                Match match = Regex.Match(barcode, pattern);

                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {
                    string text = match.Groups[1].Value;
                    for (int k = 0; k < text.Length; k++)
                    {
                        if (char.IsDigit(text[k]))
                        {
                            productGroup += text[k];
                        }
                    }
                    if (productGroup.Length == 0)
                    {
                        productGroup = "00";
                    }

                    Console.WriteLine($"Product group: {productGroup}");
                    productGroup = "";
                }
            }

        }
    }
}
