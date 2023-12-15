using CAN_PGN_SIM_4p7p2.CustomUserControls.SimulaUC;
using CAN_PGN_SIM_4p7p2.UiBuilders;
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
    public partial class Form2_CANSIM : Form
    {
        bool _loopIsRunning;
        Object_builderReader object_BuilderReader;
        CanManager canManager;
        string _filename_FORM2CANSIM= "sameFile2apps";
        public Form2_CANSIM(string argFilename)
        {
            _filename_FORM2CANSIM= argFilename;
            InitializeComponent();
            canManager = new CanManager();
            canManager.ListChannels();
            canManager.OpenChannel(0);
            canManager.SetBusParams();
            canManager.GoOnBus();


            object_BuilderReader = new Object_builderReader(this, this.flowLayoutPanel1, _filename_FORM2CANSIM);

            timer1_Loop.Tick += Timer1_Loop_Tick;
            timer1_Loop.Interval = 200;
            timer1_Loop.Enabled = false;
            btn_RunLoop.Click += Btn_RunLoop_Click;
            _loopIsRunning = false;
        }


        #region UI events
        private void Btn_RunLoop_Click(object sender, EventArgs e)
        {
            _loopIsRunning = !_loopIsRunning; // Toggle the state of the loop running flag

            if (_loopIsRunning)
            {
                btn_RunLoop.BackColor = Color.Green; // Set button color to green when loop is running
                timer1_Loop.Enabled = true; // Start the timer
            }
            else
            {
                btn_RunLoop.BackColor = Color.Red; // Set button color to red when loop is stopped
                timer1_Loop.Enabled = false; // Stop the timer
            }
        }


        private void Timer1_Loop_Tick(object sender, EventArgs e)
        {
            SendAllCann();
        }
        void SendAllCann()
        {
            Dictionary<int, VC_PGN_ColCtrlr_UC> _localDict = object_BuilderReader.GetDICT_forCAN();

            foreach (KeyValuePair<int, VC_PGN_ColCtrlr_UC> entry in _localDict)
            {
                int pgn = entry.Key;
                byte[] data = entry.Value.Get_CAN_payload();

                canManager.SendMessage(pgn, data);
            }
        }

        #endregion


    }
}
