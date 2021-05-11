using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphones
{
    public abstract class Smartphone : PushButtonPhone
    {
        private sbyte cpu;
        public override string Type => "Смартфон";
        /// <summary>
        /// Количество ядер процессора.
        /// </summary>
        public sbyte CPU 
        { 
            get { return cpu; }
            private protected set
            {
                if (value <= 0 || value > 16)
                    throw new ArgumentOutOfRangeException("CPU count must be vetween 1 and 16!");
                else
                    cpu = value;
            }
        }
        /// <summary>
        /// Операционная система.
        /// </summary>
        public abstract string OS { get; }


        public Smartphone(string model, double cost, sbyte simCount, float screenDiagonal, double inBuildMemory, bool memoryCardSlot, double camera, double battary, sbyte cpu) : 
            base(model, cost, simCount, screenDiagonal, inBuildMemory, memoryCardSlot, camera, battary)
        {
            CPU = cpu;
        }
        public override string ToString()
        {
            return base.ToString() + "\nКоличество ядер процессора:\t" + CPU + "\nОперационная система:\t" + OS;
        }
    }
}
