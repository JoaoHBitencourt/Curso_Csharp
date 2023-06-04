namespace DateTime
{using System;
    using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            DateTime d1 = DateTime.Now; 

            Console.WriteLine(d1); 
            Console.WriteLine(d1.Ticks);

            //Demo - construtores
            DateTime d2 = new DateTime(2023, 3, 15);
            DateTime d3 = new DateTime(2023, 3, 15, 13, 5, 58); 
            DateTime d4 = new DateTime(2023, 3, 15, 13, 5, 58, 275); 

            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            //Demo - Now, UtcNow, Today
            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.UtcNow;
            DateTime d7 = DateTime.Today; 

            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);

            //Demo - Parse
            DateTime d8 = DateTime.ParseExact("2023-03-02", "yyyy-MM-dd", CI);
            DateTime d9 = DateTime.ParseExact("02/03/2023 13:05:58", "dd/MM/yyyy HH:mm:ss", CI);

            Console.WriteLine(d8);
            Console.WriteLine(d9);

            Console.WriteLine();
            //Propriedades do DataTime
            DateTime d = new DateTime(2023, 3, 2, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            Console.WriteLine();
            //Formatação (DateTime -> string)
            DateTime date = new DateTime(2023, 3, 2, 20, 54, 18);
            string s1 = date.ToLongDateString();
            string s2 = date.ToLongTimeString();
            string s3 = date.ToShortDateString();
            string s4 = date.ToShortTimeString();
            string s5 = date.ToString();
            string s6 = date.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = date.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            Console.WriteLine();
            //Operações com Datetime
            DateTime x = new DateTime(2023, 3, 2, 20, 54, 18);

            DateTime y = x.AddHours(2);
            DateTime y2 = x.AddMinutes(3);
            DateTime y3 = DateTime.Now;
            DateTime y4 = y3.AddDays(7);//util para calcular um vencimento de boleto por exp..

            Console.WriteLine(y);
            Console.WriteLine(y2);
            Console.WriteLine(y3);
            Console.WriteLine(y4);
           
        }
    }
}