using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankKonverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rub;
            float usd;
            float eur;
            float currencyCount;
            int rubToUsd = 46, rubToEur = 56;
            int usdToRub = 48, usdToEur = 1;
            int eurToRub = 58, eurToUsd = 1;
            string userInput;
            bool endConvertMoney = true;

            Console.Write("Введите количество Рублей на вашем счету: ");
            rub =Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите количество Долларов на вашем счету: ");
            usd = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите количество Евро на вашем счету: ");
            eur = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Здравствуйте. Здесь вы можете обменять валюты: Рубли(RUB), Доллары(USD) и Евро(EUR):");
            Console.WriteLine("1-обменять Рубли на Доллары");
            Console.WriteLine("2-обменять Рубли на Евро");
            Console.WriteLine("3-обменять Доллары на Рубли");
            Console.WriteLine("4-обменять Доллары на Евро");
            Console.WriteLine("5-обменять Евро на Доллары");
            Console.WriteLine("6-обменять Евро на Рубли");
            Console.WriteLine("7-завершить операцию");

            while (endConvertMoney == true)
            {
                Console.Write("Какую функцию желаете использовать: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Обмен Рублей на Доллары");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rub >= currencyCount)
                        {
                            rub -= currencyCount;
                            usd += currencyCount / rubToUsd;
                        }
                        else
                        {
                            Console.WriteLine("Нужно больше Рублей.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Обмен Рублей на Евро");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rub >= currencyCount)
                        {
                            rub -= currencyCount;
                            usd += currencyCount / rubToEur;
                        }
                        else
                        {
                            Console.WriteLine("Нужно больше Рублей.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Обмен Долларов на Рубли");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rub >= currencyCount)
                        {
                            usd -= currencyCount;
                            rub += currencyCount / usdToRub;
                        }
                        else
                        {
                            Console.WriteLine("Нужно больше Рублей.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Обмен Долларов на Евро");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rub >= currencyCount)
                        {
                            usd -= currencyCount;
                            eur += currencyCount / usdToEur;
                        }
                        else
                        {
                            Console.WriteLine("Нужно больше Рублей.");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Обмен Евро на Доллары");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rub >= currencyCount)
                        {
                            eur -= currencyCount;
                            usd += currencyCount / eurToUsd;
                        }
                        else
                        {
                            Console.WriteLine("Нужно больше Рублей.");
                        }
                        break;
                    case "6":
                        Console.WriteLine("Обмен Евро на Рубли");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rub >= currencyCount)
                        {
                            eur -= currencyCount;
                            rub += currencyCount / eurToRub;
                        }
                        else
                        {
                            Console.WriteLine("Нужно больше Рублей.");
                        }
                        break;
                    case "7":
                        Console.WriteLine("Досвидание!");
                        endConvertMoney = false;
                        break;
                }
                Console.WriteLine($"У вас на счету Рублей - {rub}, Долларов - {usd}, Евро - {eur}");
                Console.ReadKey();
            }
        }
    }
}
