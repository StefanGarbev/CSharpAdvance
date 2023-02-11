namespace EvenLines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            var reader = new StreamReader(inputFilePath);
            int counter = 0;
            string line = string.Empty;
            StringBuilder stringBuilder = new StringBuilder();

            using (reader)
            {
                
                while (line != null)
                {
                    line = reader.ReadLine();
                    

                    if (counter % 2 == 0)
                    {
                        string replacedSymbols = ReplaceSymbol(line);
                        string revercedArr = ReceiveArray(replacedSymbols);
                        stringBuilder.AppendLine(revercedArr);
                    }
                    counter++;
                }
            }
            return stringBuilder.ToString();
        }

        
        private static string ReplaceSymbol(string line)
        {
            StringBuilder sb = new StringBuilder(line);

            string[] oldChar = { "-", ", ", ". ", "! ", "? " };

            foreach (string symbol in oldChar)
            {
                    sb.Replace(symbol, "@");
            }

            return sb.ToString();
        }

        private static string ReceiveArray(string replacedSymbols)
        {
            string[] strings = replacedSymbols
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            return string.Join(" ", strings);
        }

    }
}
