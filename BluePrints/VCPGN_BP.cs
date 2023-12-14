using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAN_PGN_SIM_4p7p2.BluePrints
{
    public struct VCPGN_BP
    {
        public int ID { get; set; }
        public int PGNint { get; set; }
        public string PGNstr { get; set; }
        public string Description { get; set; }
        public List<VCPGNDB_BP> ByteTypes { get; set; }
    }
}
