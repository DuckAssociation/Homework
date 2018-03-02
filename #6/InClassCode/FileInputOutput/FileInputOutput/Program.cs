using System;
using System.IO;
using System.Text;

namespace FileInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var filestream = File.OpenRead("C:/Users/BB9195/Desktop/Lecture/asdasd/MyFile.txt"))
                {
                    byte[] buffer = new byte[1024];
                    while (filestream.CanRead)
                    {

                        var n = filestream.Read(buffer, 0, 1028);
                        if (n == 0) break;
                        Console.WriteLine(Encoding.ASCII.GetString(buffer));

                    }

                    //var ourText = "aaaa";
                    //var ourBytesArray = Encoding.ASCII.GetBytes(ourText);
                    //filestream.Position = filestream.Seek(0, SeekOrigin.End);
                    ////filestream.Write(ourBytesArray, 0, ourBytesArray.Length);
                    //for (int i = 0; i < ourBytesArray.Length; i++)
                    //{
                    //    filestream.WriteByte(ourBytesArray[i]);
                    //}
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Failed to read");
                // TODO: try to recover;
            }
            //catch (System.IO.DirectoryNotFoundException ex)
            //{

            //}
            catch (Exception ex)
            {
                Console.Write(ex);
                throw;
            }
            Console.ReadLine();
        }
    }
}
