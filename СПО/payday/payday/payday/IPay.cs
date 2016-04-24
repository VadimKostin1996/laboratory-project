using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payCalculation
{
    /// <summary>
    /// Интерфейс для работника с определенным способом оплаты.
    /// </summary>
    public interface IPay
    {
        /// <summary>
        /// Фамилия.
        /// </summary>
        string surname { get; set; }

        /// <summary>
        /// Имя.
        /// </summary>
        string name { get; set; }

        /// <summary>
        /// Отчетсво.
        /// </summary>
        string patronymic { get; set; }

        /// <summary>
        /// Метод, рассчитывающий зарплату.
        /// </summary>
        /// <returns></returns>
        double CalculationOfWages();
    }

}

