using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab1_3var;

namespace Loader
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var list = new List<IEmployer>();

                var wageEmployer1 = new WageEmployer();
                wageEmployer1.Surname = "Сидоров";
                wageEmployer1.Name = "Александр";
                wageEmployer1.Patronymic = "Андреевич";
                wageEmployer1.Premium = 5000;
                wageEmployer1.Salary = 25000;
                wageEmployer1.Rate = 1;
                wageEmployer1.AwardCount = 0;
                list.Add(wageEmployer1);

                var wageEmployer2 = new WageEmployer();
                wageEmployer2.Surname = "Ковган";
                wageEmployer2.Name = "Владимир";
                wageEmployer2.Patronymic = "Валерьевич";
                wageEmployer2.Premium = 0;
                wageEmployer2.Salary = 15000;
                wageEmployer2.Rate = 0.5;
                wageEmployer2.AwardCount = 10;
                list.Add(wageEmployer2);

                var hourEmployer1 = new HourEmployer();
                hourEmployer1.Surname = "Богомолов";
                hourEmployer1.Name = "Максим";
                hourEmployer1.Patronymic = "Александрович";
                hourEmployer1.HourCount = 8;
                hourEmployer1.Cost = 200;
                hourEmployer1.Premium = 3500;
                list.Add(hourEmployer1);

                var hourEmployer2 = new HourEmployer();
                hourEmployer2.Surname = "Беляев";
                hourEmployer2.Name = "Егор";
                hourEmployer2.Patronymic = "Евгеньевич";
                hourEmployer2.HourCount = 5;
                hourEmployer2.Cost = 300;
                hourEmployer2.Premium = 1700;
                list.Add(hourEmployer2);

                foreach (IEmployer employee in list)
                {
                    Console.WriteLine("зарплата работника {0}: {1} руб",employee.Surname, employee.CalculationOfWages());
                }
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка!");
            }
           
        }
    }
}
