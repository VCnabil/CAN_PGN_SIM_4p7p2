using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAN_PGN_SIM_4p7p2.BluePrints
{
    public struct VCPGNDB_BP
    {
        public string _myType { get; set; }
        public string _myDescription { get; set; }
        public int _myByteIndexInPayload { get; set; }
        public int _myByteIndexInPayload_secondary { get; set; }
        public int _myMin { get; set; }
        public int _myMax { get; set; }
        public int _muDefVal { get; set; }
        public List<string> bits_desc { get; set; }
    }
}
