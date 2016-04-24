using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payCalculation
{
    /// <summary>
    /// 
    /// </summary>
    public class Casing : IPay
    {
        private string _surname;

        /// <summary>
        /// Фамилия.
        /// </summary>
        public string surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        private string _name;

        /// <summary>
        /// Имя.
        /// </summary>
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _patronymic;

        /// <summary>
        /// Отчетсво.
        /// </summary>
        public string patronymic
        {
            get { return _patronymic; }
            set { _patronymic = value; }
        }

        private double _salary;

        /// <summary>
        /// Оклад.
        /// </summary>
        public double salary
        {
            get { return _salary; }
            set
            {
                if (value > 0) 
                    _salary = value;
                else salary = 1;
            }
        }

        private double _rate;

        /// <summary>
        /// Ставка.
        /// </summary>
        public double rate
        {
            get { return _rate; }
            set
            {
                if ((value > 0) && (value <= 1))
                    _rate = value;
                else rate = 1;
            }
        }

        /// <summary>
        /// Метод, вычисляющий зарплату работника.
        /// </summary>
        /// <returns></returns>
        public double CalculationOfWages()
        {
            return salary * rate;
        }

        public Casing(string _name, string _surname, string _patronymic, double _salary, double _rate)
        {
            name = _name;
            surname = _surname;
            patronymic = _patronymic;
            salary = _salary;
            rate = _rate;
        }
    }
}