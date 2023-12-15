using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAN_PGN_SIM_4p7p2
{
    public partial class Form0_Main : Form
    {
        string filename = "sameFile2apps";
        public Form0_Main()
        {
            InitializeComponent();
            button1.Click += btnOpenForm1_Click;
            button2.Click += btnOpenForm2_Click;
            textBox_fileName.TextChanged += TextBox_fileName_TextChanged;
        }

        private void TextBox_fileName_TextChanged(object sender, EventArgs e)
        {
            filename = textBox_fileName.Text;
        }

        private void btnOpenForm1_Click(object sender, EventArgs e)
        {
            using (Form1_JsonBPMaker form1 = new Form1_JsonBPMaker(filename))
            {
                form1.ShowDialog(); // This will show Form1_JsonBPMaker modally
            }
            // Control returns here after Form1_JsonBPMaker is closed
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            using (Form2_CANSIM form1 = new Form2_CANSIM(filename))
            {
                form1.ShowDialog(); // This will show Form1_JsonBPMaker modally
            }
            // Control returns here after Form1_JsonBPMaker is closed
        }
    }


}
