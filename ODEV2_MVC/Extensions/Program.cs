using System;
namespace Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(Odev2_Core.Extensions.ToTurkishDateTime(dateTime));
            Console.WriteLine(dateTime.ToString());
            Console.ReadLine();
        }
    }
}
