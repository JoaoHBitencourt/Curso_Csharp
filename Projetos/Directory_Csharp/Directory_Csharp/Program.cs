﻿namespace Directory_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\temp\myfolder";
            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("\nFILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                Directory.CreateDirectory($@"{path}\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}