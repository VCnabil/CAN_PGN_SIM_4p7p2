using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAN_PGN_SIM_4p7p2.CustomUserControls.Utils
{
    public partial class uc_PgnDataDisplay : UserControl
    {
        bool Display_in_HexFormat = false;
        byte[] bytes;
        //array of metro labels
        Label[] mLabels;
        public uc_PgnDataDisplay()
        {
            InitializeComponent();
            bytes = new byte[8];
            bytes[0] = 0x00;
            bytes[1] = 0x00;
            bytes[2] = 0x00;
            bytes[3] = 0x00;
            bytes[4] = 0x00;
            bytes[5] = 0x00;
            bytes[6] = 0x00;
            bytes[7] = 0x00;
            mLabels = new Label[8];
            mLabels[0] = mlbl_B0;
            mLabels[1] = mlbl_B1;
            mLabels[2] = mlbl_B2;
            mLabels[3] = mlbl_B3;
            mLabels[4] = mlbl_B4;
            mLabels[5] = mlbl_B5;
            mLabels[6] = mlbl_B6;
            mLabels[7] = mlbl_B7;

            mcb_Hex.Checked = false;
            Display_in_HexFormat = mcb_Hex.Checked;
            mcb_Hex.CheckedChanged += new EventHandler(mcb_Hex_CheckedChanged);



            Display_in_HexFormat = mcb_Hex.Checked;

            if (Display_in_HexFormat)
            {
                for (int i = 0; i < mLabels.Length; i++)
                {


                    mLabels[i].Text = bytes[i].ToString("X2");
                }
            }
            else
            {
                for (int i = 0; i < mLabels.Length; i++)
                {


                    mLabels[i].Text = bytes[i].ToString("D3");
                }

            }
        }

        #region events
        void mcb_Hex_CheckedChanged(object sender, EventArgs e)
        {
            Display_in_HexFormat = mcb_Hex.Checked;

            if (Display_in_HexFormat)
            {
                for (int i = 0; i < mLabels.Length; i++)
                {


                    mLabels[i].Text = bytes[i].ToString("X2");
                }
            }
            else
            {
                for (int i = 0; i < mLabels.Length; i++)
                {


                    mLabels[i].Text = bytes[i].ToString("D3");
                }

            }
        }
        #endregion

        public void UpdateDisplay(byte[] data)
        {
            if (data.Length > 0)
            {
                bytes = data;
                if (Display_in_HexFormat)
                {
                    for (int i = 0; i < data.Length; i++)
                    {

                        mLabels[i].Text = data[i].ToString("X2");
                    }
                }
                else
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        mLabels[i].Text = data[i].ToString("D3");
                    }

                }
            }
        }

        public void SetTitle_str(string title)
        {
            mlbl_Title.Text = title;
        }

        public void SetTitle_intPgnHex(int argPgn)
        {
            mlbl_Title.Text = "0x " + argPgn.ToString("X");
        }
    }
}
