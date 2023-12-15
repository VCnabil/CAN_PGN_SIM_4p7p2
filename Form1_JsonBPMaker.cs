using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAN_PGN_SIM_4p7p2.UiBuilders;
using System.Windows.Forms;

namespace CAN_PGN_SIM_4p7p2
{
    public partial class Form1_JsonBPMaker : Form
    {
        int _width = 1300;
        int _height = 1000;
        int _howmanyRowsTomake = 1;
        string _filename_FORM1BPMAKER = "sameFile2apps";
        Builder_UI_JSONWRITE test;
        public Form1_JsonBPMaker(string argFilename)
        {
            _filename_FORM1BPMAKER = argFilename;
            InitializeComponent();
            textBox1.TextChanged += TextBox1_TextChanged;
            button1.Click += Button1_Click;
            btn_MakeJsonFile.Click += Btn_MakeJsonFile_Click;
        }

        #region UI Events

        private void Btn_MakeJsonFile_Click(object sender, EventArgs e)
        {
            test.MakeJson();
            //btn_MakeJsonFile.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (_howmanyRowsTomake > 0)
            {
                test = new Builder_UI_JSONWRITE(this, this.flowLayoutPanel1, _howmanyRowsTomake, _filename_FORM1BPMAKER);
                _width = test.WidthFINAL;
                _height = test.HeightFINAL;

            }
            else
            {
                MessageBox.Show("Please enter a number between 1 and 10");
            }

            this.Width = _width;
            this.Height = _height;
            button1.Enabled = false;

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            _howmanyRowsTomake = Convert.ToInt32(textBox1.Text);

            if (_howmanyRowsTomake < 1)
            {
                _howmanyRowsTomake = 1;
            }
            else if (_howmanyRowsTomake > 10)
            {
                _howmanyRowsTomake = 10;
            }

        }
        #endregion
    }
}
