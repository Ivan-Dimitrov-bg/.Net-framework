using System;
using System.Threading;

class Timer7

{
    static int n = 0;

    public static void Numbers()
    {        
        Console.WriteLine(n);        
    }

    public class Timer
    {
        public delegate void Execute();

        public Execute EvenNumbers;

        public void Begin(int Seconds)
        {
            DateTime start = DateTime.Now;
            DateTime end = start.AddSeconds(Seconds);
            while (start <= end)
            {
                EvenNumbers();
                Thread.Sleep(1000);
                start = DateTime.Now;
                n += 2;
            }

        }
    }
    static void Main()
    {
        Console.WriteLine("Pls input the seconds");
        int secs = int.Parse(Console.ReadLine());
        Timer timer = new Timer();
        timer.EvenNumbers = Numbers;
        timer.Begin(secs);
    }
}