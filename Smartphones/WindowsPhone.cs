using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphones
{
    public class WindowsPhone : Smartphone
    {
        public WindowsPhone(string model, double cost, sbyte simCount, float screenDiagonal, double inBuildMemory, bool memoryCardSlot, double camera, double battary, sbyte cpu) : base(model, cost, simCount, screenDiagonal, inBuildMemory, memoryCardSlot, camera, battary, cpu)
        {
        }

        public override string OS => "Windows";

        public override string Type => "Windows Phone";
    }
}
