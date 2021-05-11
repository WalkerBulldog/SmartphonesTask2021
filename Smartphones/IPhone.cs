using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphones
{
    public class IPhone : Smartphone
    {
        public IPhone(string model, double cost, sbyte simCount, float screenDiagonal, double inBuildMemory, bool memoryCardSlot, double camera, double battary, sbyte cpu) :
            base(model, cost, simCount, screenDiagonal, inBuildMemory, memoryCardSlot, camera, battary, cpu)
        {
        }

        public override string Type => base.Type + " IPhone";

        public override string OS => "iOS";

    }
}
