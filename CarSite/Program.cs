using System;
using System.Collections.Generic;
using System.Threading;

namespace CarSite
{
    class Program
    {
        static int _key;
        static void Main(string[] args)
        {
            IDictionary<int, Car> car = new Dictionary<int, Car>();

            while (true)
            {
                Menu();
                Console.WriteLine();
                switch (Console.ReadLine())
                {

                    case "1":
                        foreach (var item in car)
                        {
                            Console.WriteLine(item.Value.ToString());
                        }
                        break;

                    case "2":
                        Console.WriteLine("Enter marka");
                        string marka = Console.ReadLine();

                        Console.WriteLine("enter Model");
                        string model = Console.ReadLine();

                        Console.WriteLine("enter year");
                        int year = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("enter price");
                        double price = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter ban");
                        int ban = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("enter color number");
                        int color = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter yanacaq");
                        int yanacaq = Convert.ToInt32(Console.ReadLine());

                        int key = Interlocked.Increment(ref _key);

                        car.Add(key, new Car(marka, model, year, price, ban, color, yanacaq));
                        break;
                    case "3":
                        Console.WriteLine("Enter the id of the car you want to remove");
                        int id = Convert.ToInt32(Console.ReadLine());
                        car.Remove(id);
                        break;
                    case "4":
                        Console.WriteLine("Enter the id of the car you want to update");
                        int _id = Convert.ToInt32(Console.ReadLine());

                        break;
                    default:
                        Console.WriteLine("Bele bir emeliyyat yoxdur");
                        break;
                }
                Console.WriteLine();
            }
        }
        public static void Menu()
        {
            Console.WriteLine("Əməliyyatlar");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1.Kataloq ");
            Console.WriteLine("2.Elan yerləşdirmək");
            Console.WriteLine("3.Elan silmək");
            Console.WriteLine("4.Redaktə et");
            Console.WriteLine("5.Çıxış");
            Console.WriteLine("6.Save");
        }
    }
}
