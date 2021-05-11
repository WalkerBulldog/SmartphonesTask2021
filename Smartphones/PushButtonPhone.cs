using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphones
{
    public class PushButtonPhone : Phone
    {
        private sbyte simCount;
        private double screedDiagonal;
        private double inBuildMemory;
        private double camera;
        private double battery;
        public PushButtonPhone(string model, double cost, sbyte simCount, double screenDiagonal, double inBuildMemory, bool memoryCardSlot, double camera, double battary):
            base(model, cost)
        {
            SimCount = simCount;
            ScreenDiagonal = screenDiagonal;
            InBuildMemory = inBuildMemory;
            MemoryCardSlot = memoryCardSlot;
            Camera = camera;
            Battery = battary;
        }

        public override string Type => "Кнопочный телефон";
        /// <summary>
        /// Количество сим-карт.
        /// </summary>
        public sbyte SimCount 
        { 
            get { return simCount; } 
            private protected set
            {
                if (value <= 0 || value > 6)
                    throw new ArgumentOutOfRangeException("SimCount must be between 1 and 6!");
                else
                    simCount = value;
            } 
        }
        /// <summary>
        /// Диагональ экрана в дюймах.
        /// </summary>
        public double ScreenDiagonal 
        { 
            get { return screedDiagonal; }
            private protected set
            {
                if (value < 1 || value > 15)
                    throw new ArgumentOutOfRangeException("ScreenDiagonal must be between 1 and 15 inches!");
                else
                    screedDiagonal = value;
            }
        }
        /// <summary>
        /// Внутренняя память, в мегабайтах.
        /// </summary>
        public double InBuildMemory 
        { 
            get { return inBuildMemory; }
            private protected set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Memory can't be negative!");
                else
                    inBuildMemory = value;
            }
        }
        /// <summary>
        /// Наличие слота под SD-карту.
        /// </summary>
        public bool MemoryCardSlot { get; private protected set; }
        /// <summary>
        /// Количество мегапикселей камеры.
        /// </summary>
        public double Camera
        {
            get { return camera; }
            private protected set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Camera quality can't be negative or zero!");
                else
                    camera = value;
            }
        }
        /// <summary>
        /// Ёмкость аккумуляторной батареи.
        /// </summary>
        public double Battery
        {
            get { return battery; }
            private protected set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Battery capacity can't be negative or zero!");
                else
                    battery = value;
            }
        }

        public override string ToString()
        {
            return Type + " " + base.ToString() + "\nКоличество сим-карт:\t\t" + SimCount + "\nДиагональ экрана, дюймов:\t\t" + ScreenDiagonal
                + "\nВнутренняя память, мб:\t\t" + InBuildMemory + "\nКамера, мегапикселей:\t\t" + Camera
                + "\nСлот под SD-карту:\t\t" + (MemoryCardSlot ? "да" : "нет") + "\nЁмкость батареи, мАч:\t\t" + Battery;
        }
    }
}
