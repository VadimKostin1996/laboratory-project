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
    public class HourlyPay: IPay
    {
        /// <summary>
        /// Локальная переменная для фамилии
        /// </summary>
        private string _surname;

        /// <summary>
        /// Локальная переменная для имени
        /// </summary>
        private string _name;

        /// <summary>
        /// Локальная переменная для отчества
        /// </summary>
        private string _patronymic;
       
        /// <summary>
        /// Свойство фамилии
        /// </summary>
        public string surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        /// <summary>
        /// Свойство имени
        /// </summary>
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        
        /// <summary>
        /// Свойство отчества
        /// </summary>
        public string patronymic
        {
            get { return _patronymic; }
            set { _patronymic = value; }
        }

        private int _hour;

        /// <summary>
        /// Рабочие часы
        /// </summary>
        public int hour
        {
            get { return _hour; }
            set
            {
                if (value > 0)
                    _hour = value;
                else hour = 1;
            }
        }

        private double _payment;

        /// <summary>
        /// Свойство cтоимости
        /// </summary>
        public double payment
        {
            get { return _payment; }
            set
            {
                if (value > 0)
                    _payment = value;
                else payment = 1;
            }
        }

        /// <summary>
        /// Метод, вычисляющий зарплату работника.
        /// </summary>
        /// <returns></returns>
        public double CalculationOfWages()
        {
            return hour*payment;
        }
        public HourlyPay(string _name, string _surname, string _patronymic, int _hour, double _payment)
        {
            name = _name;
            surname = _surname;
            patronymic = _patronymic;
            hour = _hour;
            payment= _payment;
        }
    }    
}

