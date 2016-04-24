using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_3var
{
    /// <summary>
    /// Интерфейс для работника со способом оплаты.
    /// </summary>
    public interface IEmployer
    {
        /// <summary>
        /// Фамилия.
        /// </summary>
        string Surname { get; set; }

        /// <summary>
        /// Имя.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Отчетсво.
        /// </summary>
        string Patronymic { get; set; }

        /// <summary>
        /// Премия.
        /// </summary>
        double Premium { get; set; }

        /// <summary>
        /// Метод, рассчитывающий зарплату.
        /// </summary>
        /// <returns></returns>
        double CalculationOfWages();
    }

}
