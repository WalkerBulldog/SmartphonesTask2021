using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphones
{
    public abstract class Phone
    {
        /// <summary>
        /// Модель телефона.
        /// </summary>
        public string Model { get; }
        /// <summary>
        /// Стоимость телефона.
        /// </summary>
        public double Cost { get; protected set; }
        /// <summary>
        /// Тип телефона.
        /// </summary>
        public abstract string Type { get; }
        public Phone(string model, double cost)
        {
            Model = model;
            Cost = cost;
        }
        public override string ToString()
        {
            return Model + "\nСтоимость: " + Cost.ToString();
        }
    }
}
