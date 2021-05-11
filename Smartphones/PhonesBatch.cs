using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphones
{
    /// <summary>
    /// Партия телефонов.
    /// </summary>
    public class PhonesBatch
    {
        /// <summary>
        /// Тип телефона в партии.
        /// </summary>
        private Phone Phone;
        /// <summary>
        /// Количесвто телефонов в партии.
        /// </summary>
        private int count;
        public int Count 
        {
            get { return count; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Batch count must be > 0");
                else
                    count = value;
            }
        }
        /// <summary>
        /// Дата выхода партии.
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Конструктор партии.
        /// </summary>
        /// <param name="phone">Телефон.</param>
        /// <param name="count">Количество телефонов.</param>
        /// <param name="date">Дата выхода партии.</param>
        public PhonesBatch (Phone phone, int count, DateTime date)
        {
            Date = date;
            Phone = phone;
            Count = count;
        }
        /// <summary>
        /// Стоимость партии телефонов.
        /// </summary>
        public double Cost { get { return Phone.Cost * Count; } }
        /// <summary>
        /// Тип телефона партии.
        /// </summary>
        public string Type { get { return Phone.Type; } }
        /// <summary>
        /// Модель телефона партии.
        /// </summary>
        public string Model { get { return Phone.Model; } }
        public override string ToString()
        {
            return Phone.ToString();
        }

    }
}
