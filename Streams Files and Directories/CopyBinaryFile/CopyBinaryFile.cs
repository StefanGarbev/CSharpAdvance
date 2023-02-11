namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {

            using FileStream fileStreamReader = new FileStream(inputFilePath, FileMode.Open);
            using FileStream fileStreamWriter = new FileStream(outputFilePath, FileMode.Create);

            byte[] buffer = new byte[1024];
            int size = 0;

            while ((size = fileStreamReader.Read(buffer, 0, buffer.Length)) != 0)
            { 
                fileStreamWriter.Write(buffer, 0, size);
            }
            
        }
    }
}
