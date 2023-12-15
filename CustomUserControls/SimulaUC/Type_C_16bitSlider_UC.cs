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
    public partial class Type_C_16bitSlider_UC : UserControl, IgenericUcByte
    {
        char _myType = 'C';
        int _myByteIndexInPayload;
        int _myByteIndexInPayload_secondary;
        byte[] my2bytes;
        int _myMin;
        int _myMax;
        int _myMidVal;
        bool _isHexFormat;
        int _cur_INT_Value;
        CheckBox[] myCbs;
        int _Default_Val;
        VC_PGN_ColCtrlr_UC my_refTOCTRL;
        public Type_C_16bitSlider_UC()
        {
            InitializeComponent();
            cb_HEX.CheckedChanged += new EventHandler(cb_HEX_CheckedChanged);
            tb_Slider.ValueChanged += new EventHandler(tb_Slider_ValueChanged);
            btn_reset.Click += new EventHandler(btn_reset_Click);
        }

        #region UI Events
        void tb_Slider_ValueChanged(object sender, EventArgs e)
        {
            _cur_INT_Value = tb_Slider.Value;
            Update_Bval_label();
            Update_my2bytes();
        }
        void btn_reset_Click(object sender, EventArgs e)
        {
            _cur_INT_Value = _myMidVal;
            tb_Slider.Value = _cur_INT_Value;
            Update_Bval_label();
            Update_my2bytes();
        }
        private void cb_HEX_CheckedChanged(object sender, EventArgs e)
        {
            _isHexFormat = cb_HEX.Checked;
            Update_Bval_label();
        }

        #endregion

        #region Interface implementation
        public void Init_genericBytetype(string argDescription, int arg_MyByteIndexInPayload, int arg_mysecondary, VC_PGN_ColCtrlr_UC arg_refTOCTRL, int argMin, int argMax, int argDefaltval)
        {
            _myMin = 0;
            _myMax = 0;
            _myMidVal = 0;
            my2bytes = new byte[2];
            _isHexFormat = cb_HEX.Checked;
            my_refTOCTRL = arg_refTOCTRL;
            _myByteIndexInPayload = arg_MyByteIndexInPayload;
            _myByteIndexInPayload_secondary = arg_mysecondary; //i only have one byte so my secondary index is the same as my primary
            this.lbl_Desc.Text = argDescription;
            //I need min max because I am a type C and my slider is 16 bits
            _myMin = argMin;
            _myMax = argMax;
            _myMidVal = (_myMax - _myMin) / 2;
            tb_Slider.Minimum = _myMin;
            tb_Slider.Maximum = _myMax;
            tb_Slider.Value = _myMidVal;//start me at _myMidVal  always
            _cur_INT_Value = tb_Slider.Value;
            Update_Bval_label();
            Update_my2bytes();
        }
        public byte[] getMy2Bytes()
        {
            return my2bytes;
        }

        public char get_myType()
        {
            return _myType;
        }

        public int Get_My_ByteA_Index()
        {
            return _myByteIndexInPayload;
        }

        public int Get_My_ByteB_Index()
        {
            return _myByteIndexInPayload_secondary;
        }



        public void set_myBits_ifApplies(string[] argBitDescriptions)
        {
            //if (argBitDescriptions.Length == 8)
            //{
            //    for (int i = 0; i < argBitDescriptions.Length; i++)
            //    {
            //        //if argBitDescriptions[i] is null or empty, disable the corresponding cbs[i] else set the cbs[i].text tp the argbitdescription
            //        if (string.IsNullOrEmpty(argBitDescriptions[i]))
            //        {
            //            myCbs[i].Text = "";
            //            myCbs[i].Enabled = false;
            //        }
            //        else
            //        {
            //            myCbs[i].Enabled = true;
            //            myCbs[i].Text = "bit " + i.ToString() + " " + argBitDescriptions[i];
            //        }
            //    }
            //}
        }

        #endregion

        #region Local Methods
        void Update_Bval_label()
        {
            if (_isHexFormat)
            {
                lbl_Bval.Text = _cur_INT_Value.ToString("X2");
            }
            else
            {
                lbl_Bval.Text = _cur_INT_Value.ToString("D3");
            }
        }
        void Update_my2bytes()
        {
            byte lowbyte = (byte)(_cur_INT_Value & 0x00FF);
            byte highbyte = (byte)((_cur_INT_Value & 0xFF00) >> 8);
            my2bytes[0] = lowbyte;
            my2bytes[1] = highbyte;
            my_refTOCTRL.PlugYourByteHere(_myByteIndexInPayload, my2bytes[0], _myType, _myByteIndexInPayload_secondary, my2bytes[1]);
        }

        #endregion
    }
}
