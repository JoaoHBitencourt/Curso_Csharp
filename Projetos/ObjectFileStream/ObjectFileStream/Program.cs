namespace ObjectFileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileInfo
            string surcePath = @"D:\temp\File1.txt";

            FileInfo fileInfo = new FileInfo(surcePath);

            string[] lines = File.ReadAllLines(surcePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();

            //StreamReader
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(surcePath);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}