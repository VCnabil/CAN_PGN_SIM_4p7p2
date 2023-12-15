using CAN_PGN_SIM_4p7p2.BluePrints;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAN_PGN_SIM_4p7p2.CustomUserControls.SimulaUC
{
    public partial class VC_PGN_ColCtrlr_UC : UserControl
    {

        string _mySetupInstruction = "";
        string _myDesc = "";
        int _pgnInt;
        byte[] _dataPayload;
        public int Get_CAN_pgn() { return this._pgnInt; }
        public byte[] Get_CAN_payload() { return this._dataPayload; }
        public VC_PGN_ColCtrlr_UC()
        {
            InitializeComponent();
            _dataPayload = new byte[8];
            _pgnInt = 0;
        }
        public void SetMeUp_withGenericBytes(List<VCPGNDB_BP> argGenericBytes, int argpgnInt, string argDescription)
        {

            _pgnInt = argpgnInt;// CanManager.HexStringToInt(arg0x18FFAA00);
            my_uc_PgnDataDisplay.SetTitle_intPgnHex(_pgnInt);
            this.lbl_Desc.Text = argDescription;// "18 FF51 29   is the Blah of Port Blah CU v 43424";
                                                //_pgnInt =argGenericByteType.pgn
                                                //  string strType = argGenericByteType._myType;

            IgenericUcByte generic_PTR;

            for (int i = 0; i < argGenericBytes.Count; i++)
            {
                string strType = argGenericBytes[i]._myType;

                int __row = argGenericBytes[i]._myByteIndexInPayload;
                int __rowSecondary = argGenericBytes[i]._my_sec_index;
                string[] __argBitsDescriptor = argGenericBytes[i].bits_desc.ToArray();
                string _sliderDesc = argGenericBytes[i]._myDescription;
                int __min = argGenericBytes[i]._myMin;
                int __max = argGenericBytes[i]._myMax;
                int __DefaultV = argGenericBytes[i]._muDefVal;

                if (strType == "A")
                {
                    generic_PTR = new Type_A_8bits_UC();
                    generic_PTR.Init_genericBytetype(_sliderDesc, __row, __rowSecondary, this, __min, __max, __DefaultV);
                    generic_PTR.set_myBits_ifApplies(__argBitsDescriptor);
                    my_2x8_tableLayoutPanel.Controls.Add((Type_A_8bits_UC)generic_PTR, 1, __row);
                }
                else
                if (strType == "B")
                {
                    generic_PTR = new Type_B_8bitSlider_UC();
                    generic_PTR.Init_genericBytetype(_sliderDesc, __row, __rowSecondary, this, __min, __max, __DefaultV);
                    generic_PTR.set_myBits_ifApplies(__argBitsDescriptor);
                    my_2x8_tableLayoutPanel.Controls.Add((Type_B_8bitSlider_UC)generic_PTR, 1, __row);
                }
                else
                 if (strType == "C")
                {
                    generic_PTR = new Type_C_16bitSlider_UC();
                    generic_PTR.Init_genericBytetype(_sliderDesc, __row, __rowSecondary, this, __min, __max, __DefaultV);
                    generic_PTR.set_myBits_ifApplies(__argBitsDescriptor);
                    my_2x8_tableLayoutPanel.Controls.Add((Type_C_16bitSlider_UC)generic_PTR, 1, __row);
                }
                else
                 if (strType == "D")
                {
                    generic_PTR = new Type_D_8bitLabel_UC();
                    generic_PTR.Init_genericBytetype(_sliderDesc, __row, __rowSecondary, this, __min, __max, __DefaultV);
                    generic_PTR.set_myBits_ifApplies(__argBitsDescriptor);
                    my_2x8_tableLayoutPanel.Controls.Add((Type_D_8bitLabel_UC)generic_PTR, 1, __row);
                }
                else
                // if (strType == "E")
                {
                    generic_PTR = new Type_E_16bitLabel_UC();
                    generic_PTR.Init_genericBytetype(_sliderDesc, __row, __rowSecondary, this, __min, __max, __DefaultV);
                    generic_PTR.set_myBits_ifApplies(__argBitsDescriptor);
                    my_2x8_tableLayoutPanel.Controls.Add((Type_E_16bitLabel_UC)generic_PTR, 1, __row);
                }


            }



        }

        public void PlugYourByteHere(int argByteIndex, byte argByteValue, char argYOurtype, int argSecondIndex, byte argSecondByte)
        {

            if (argYOurtype == 'C' || argYOurtype == 'E')
            {

                _dataPayload[argByteIndex] = argByteValue;
                _dataPayload[argSecondIndex] = argSecondByte;
            }

            else
            {
                _dataPayload[argByteIndex] = argByteValue;
            }
            UpdateMyDisplay();
        }

        void UpdateMyDisplay()
        {
            my_uc_PgnDataDisplay.UpdateDisplay(_dataPayload);
        }
    }
}
