namespace Console
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using payday;

    class Program
    {
        static void Main(string[] args)
        {
        try
            {
                var list = new List<IPayday>();

                var casing = new Casing();
                casing.surname = "Неволин";
                casing.name = "Владимир";
                casing.patronymic = "Алексеевич";
                casing.salary = 5000000;
                casing.rate = 1;
                list.Add(casing);

                var casing2 = new Casing();
                casing2.surname = "Ускенбаев";
                casing2.name = "Бектур";
                casing2.patronymic = "Нурламович";
                casing2.salary = 100;
                casing2.rate = 0.5;
                list.Add(casing2);

                var hourEmployer1 = new HourlyPay();
                hourEmployer1.surname = "Кулигин";
                hourEmployer1.name = "Сергей";
                hourEmployer1.patronymic = "Константинович";
                hourEmployer1.hour =24;
                hourEmployer1.payment = 100;
                list.Add(hourEmployer1);

                var hourEmployer2 = new HourlyPay();
                hourEmployer2.surname = "Полякова";
                hourEmployer2.name = "Елизавета";
                hourEmployer2.patronymic = "Линоровна";
                hourEmployer2.hour = 8;
                hourEmployer2.payment = 3000;
                list.Add(hourEmployer2);

                foreach (IPayday employee in list)
                {
                    System.Console.WriteLine("Заработная плата работника {0} {1} {2} составляет {3} руб", employee.name, employee.patronymic, employee.surname, employee.CalculationOfWages());
                }
                System.Console.ReadLine();
            }
            catch (Exception)
            {
                System.Console.WriteLine("Ошибка!");
            }
           
        }
    }
}
