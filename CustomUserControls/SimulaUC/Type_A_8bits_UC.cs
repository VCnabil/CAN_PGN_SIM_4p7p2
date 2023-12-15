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
    public partial class Type_A_8bits_UC : UserControl, IgenericUcByte
    {
        char _myType = 'A';
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
        public Type_A_8bits_UC()
        {
            InitializeComponent();
            myCbs = new CheckBox[8];
            myCbs[0] = cb_b0;
            myCbs[1] = cb_b1;
            myCbs[2] = cb_b2;
            myCbs[3] = cb_b3;
            myCbs[4] = cb_b4;
            myCbs[5] = cb_b5;
            myCbs[6] = cb_b6;
            myCbs[7] = cb_b7;
            cb_HEX.CheckedChanged += new EventHandler(cb_HEX_CheckedChanged);
            cb_b0.CheckedChanged += new EventHandler(cb_bit_changed);
            cb_b1.CheckedChanged += new EventHandler(cb_bit_changed);
            cb_b2.CheckedChanged += new EventHandler(cb_bit_changed);
            cb_b3.CheckedChanged += new EventHandler(cb_bit_changed);
            cb_b4.CheckedChanged += new EventHandler(cb_bit_changed);
            cb_b5.CheckedChanged += new EventHandler(cb_bit_changed);
            cb_b6.CheckedChanged += new EventHandler(cb_bit_changed);
            cb_b7.CheckedChanged += new EventHandler(cb_bit_changed);
            btn_reset.Click += new EventHandler(btn_reset_Click);
        }
        #region UI Events
        void cb_bit_changed(object sender, EventArgs e)
        {
            // _cur_INT_Value is the value of the byte set by the cb_b0 to cb_b7 representing bit 0 to bit 8 of the byte    
            _cur_INT_Value = 0;
            if (cb_b0.Checked) { _cur_INT_Value += 1; }
            if (cb_b1.Checked) { _cur_INT_Value += 2; }
            if (cb_b2.Checked) { _cur_INT_Value += 4; }
            if (cb_b3.Checked) { _cur_INT_Value += 8; }
            if (cb_b4.Checked) { _cur_INT_Value += 16; }
            if (cb_b5.Checked) { _cur_INT_Value += 32; }
            if (cb_b6.Checked) { _cur_INT_Value += 64; }
            if (cb_b7.Checked) { _cur_INT_Value += 128; }
            Update_Bval_label();
            Update_my2bytes();

        }
        void btn_reset_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 8; x++)
            {
                if (myCbs[x].Enabled)
                    myCbs[x].Checked = false;
            }

            _cur_INT_Value = 0;

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
            _myByteIndexInPayload_secondary = arg_MyByteIndexInPayload; //i only have one byte so my secondary index is the same as my primary
            this.lbl_Desc.Text = argDescription;
            // i am an 8 bit byte, I always have a min of 0 and a max of 255
            _myMin = 0;
            _myMax = 255;
            _myMidVal = (_myMax - _myMin) / 2;
            _cur_INT_Value = 0;
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
            if (argBitDescriptions.Length == 8)
            {
                for (int i = 0; i < argBitDescriptions.Length; i++)
                {
                    //if argBitDescriptions[i] is null or empty, disable the corresponding cbs[i] else set the cbs[i].text tp the argbitdescription
                    if (string.IsNullOrEmpty(argBitDescriptions[i]))
                    {
                        myCbs[i].Text = "";
                        myCbs[i].Enabled = false;
                    }
                    else
                    {
                        myCbs[i].Enabled = true;
                        myCbs[i].Text = "bit " + i.ToString() + " " + argBitDescriptions[i];
                    }
                }
            }
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
            my2bytes[0] = (byte)_cur_INT_Value;
            my2bytes[1] = (byte)_cur_INT_Value;
            my_refTOCTRL.PlugYourByteHere(_myByteIndexInPayload, my2bytes[0], _myType, _myByteIndexInPayload_secondary, my2bytes[1]);
        }
        
        #endregion
    }
}
