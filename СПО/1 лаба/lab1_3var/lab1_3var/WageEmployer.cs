using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_3var
{
    /// <summary>
    /// Класс для работника, который работает по окладу
    /// </summary>
    public class WageEmployer: IEmployer
    {
        private string _surname;

        /// <summary>
        /// Фамилия.
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        private string _name;

        /// <summary>
        /// Имя.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _patronymic;
        
        /// <summary>
        /// Отчетсво.
        /// </summary>
        public string Patronymic
        {
            get { return _patronymic; }
            set { _patronymic = value; }
        }

        private double _premium;

        /// <summary>
        /// Премия.
        /// </summary>
        public double Premium
        {
            get { return _premium; }
            set { _premium = value; }
        }

        private double _salary;

        /// <summary>
        /// Оклад.
        /// </summary>
        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value > 0)
                    _salary = value;
                else Salary = 1;
            }
        }

        private double _rate; 

        /// <summary>
        /// Ставка.
        /// </summary>
        public double Rate
        {
            get { return _rate; }
            set
            {
                if ((value > 0) && (value <= 1))
                    _rate = value;
                else Rate = 1;
            }
        }

        private int _awardCount; // Количество прогулов
        
        /// <summary>
        /// Количество прогулов.
        /// </summary>
        public int AwardCount
        {
            get { return _awardCount; }
            set
            {
                if ((value > 0) && (value <= 22))
                    _awardCount = value;
                else AwardCount = 1;
            }
        }

        /// <summary>
        /// Метод, вычисляющий зарплату работника.
        /// </summary>
        /// <returns></returns>
        public double CalculationOfWages()
        {
            return (Salary * Rate * (22 - AwardCount) / 22) + Premium ;
        }
    }
}
