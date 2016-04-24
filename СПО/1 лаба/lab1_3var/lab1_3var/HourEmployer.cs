using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_3var
{
    public class HourEmployer: IEmployer
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
        /// Отчество.
        /// </summary>
        public string Patronymic
        {
            get { return _patronymic; }
            set { _patronymic = value; }
        }

        private int _hourCount;

        /// <summary>
        /// Количество часов.
        /// </summary>
        public int HourCount
        {
            get { return _hourCount; }
            set
            {
                if (value > 0)
                    _hourCount = value;
                else HourCount = 1;
            }
        }

        private double _cost;

        /// <summary>
        /// Стоимость.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set
            {
                if (value > 0)
                    _cost = value;
                else Cost = 1;
            }
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

        /// <summary>
        /// Метод, вычисляющий зарплату работника.
        /// </summary>
        /// <returns></returns>
        public double CalculationOfWages()
        {
            return HourCount*Cost + Premium;
        }
    }
}
