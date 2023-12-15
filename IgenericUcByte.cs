using CAN_PGN_SIM_4p7p2.CustomUserControls.SimulaUC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAN_PGN_SIM_4p7p2
{
    internal interface IgenericUcByte
    {
        void Init_genericBytetype(string argDescription, int arg_MyByteIndexInPayload, int arg_mysecondary, VC_PGN_ColCtrlr_UC arg_refTOCTRL, int argMin, int argMax, int argDefaltval);
        char get_myType();
        int Get_My_ByteA_Index();
        int Get_My_ByteB_Index();
        void set_myBits_ifApplies(string[] argBitDescriptions);

        byte[] getMy2Bytes();

        // event EventHandler ValueChanged;
    }
}
