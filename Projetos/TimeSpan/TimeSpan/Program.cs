namespace TimeSpan
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t = new TimeSpan(0, 1, 30);

            Console.WriteLine(t);
            Console.WriteLine(t.Ticks);

            Console.WriteLine();
            //Demo - construtores
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            Console.WriteLine();
            //Demo - métodos From
            TimeSpan t6 = TimeSpan.FromDays(1.5);
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);

            Console.WriteLine();
            //Demo: MaxValue, MinValue, Zero
            TimeSpan t12 = TimeSpan.MaxValue; 
            TimeSpan t13 = TimeSpan.MinValue;
            TimeSpan t14 = TimeSpan.Zero; 

            Console.WriteLine(t12); 
            Console.WriteLine(t13); 
            Console.WriteLine(t14);

            Console.WriteLine();
            //Demo - propriedades
            TimeSpan time = new TimeSpan(2, 3, 5, 7, 11); 

            Console.WriteLine(time);
            Console.WriteLine("Days: " + time.Days);
            Console.WriteLine("Hours: " + time.Hours);
            Console.WriteLine("Minutes: " + time.Minutes);
            Console.WriteLine("Milliseconds: " + time.Milliseconds); 
            Console.WriteLine("Seconds: " + time.Seconds);
            Console.WriteLine("Ticks: " + time.Ticks);
            Console.WriteLine("TotalDays: " + time.TotalDays); 
            Console.WriteLine("TotalHours: " + time.TotalHours);
            Console.WriteLine("TotalMinutes: " + time.TotalMinutes); 
            Console.WriteLine("TotalSeconds: " + time.TotalSeconds); 
            Console.WriteLine("TotalMilliseconds: " + time.TotalMilliseconds);

            Console.WriteLine();
            //Demo - operações
            TimeSpan t15 = new TimeSpan(1, 30, 10);
            TimeSpan t16 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t15.Add(t16);
            TimeSpan dif = t15.Subtract(t16);
            TimeSpan mult = t16.Multiply(2.0);
            TimeSpan div = t16.Divide(2.0);

            Console.WriteLine(t15);
            Console.WriteLine(t16);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}