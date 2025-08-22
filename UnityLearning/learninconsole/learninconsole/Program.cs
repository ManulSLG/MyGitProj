using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learninconsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            string dayOfWeek;

            Console.Write("Введите день недели: ");
            dayOfWeek = Console.ReadLine();

            switch(dayOfWeek)
            {
                case "понедельник":
                    Console.WriteLine("лол");
                    break;
                case "вторник":
                    Console.WriteLine("кек");
                    break;
                case "среда":
                    Console.WriteLine("чебурек");
                    break;
                case "четверг":
                    Console.WriteLine("умный человек в очках");
                    break;
                case "пятница":
                    Console.WriteLine("понедельник");
                    break;
            }
            Console.ReadKey();
        }
    }
}
