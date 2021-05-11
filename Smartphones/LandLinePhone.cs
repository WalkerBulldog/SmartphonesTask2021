using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphones
{
    public class LandLinePhone : Phone
    {
        /// <summary>
        /// Тип телефона.
        /// </summary>
        public override string Type => "Проводной телефон";
        /// <summary>
        /// Налаичие определителя номера.
        /// </summary>
        public bool AOH { get; private protected set; }
        /// <summary>
        /// Наличие дисплея.
        /// </summary>
        public bool Display { get; private protected set; }
        /// <summary>
        /// Наличие громкой связи.
        /// </summary>
        public bool FreeHands { get; private protected set; }
        /// <summary>
        /// Наличие автоответчика.
        /// </summary>
        public bool AnsweringMachine { get; private protected set; }

        public LandLinePhone(string model, double cost, bool aoh, bool display, bool freeHands, bool answeringMachine):
            base(model,cost)
        {
            AOH = aoh;
            Display = display;
            FreeHands = freeHands;
            AnsweringMachine = answeringMachine;
        }
        public override string ToString()
        {
            return Type + " " + base.ToString() + "\nОпределитель номера:\t\t" + (AOH ? "да" : "нет") + "\nДисплей:\t\t" + (Display ? "да" : "нет")
                + "\nГромкая связь:\t\t" + (FreeHands ? "да" : "нет") + "\nАвтоответчик:\t\t" + (AnsweringMachine ? "да" : "нет");
        }
    }
}
