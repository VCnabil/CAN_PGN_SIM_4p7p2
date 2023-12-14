using CAN_PGN_SIM_4p7p2.BluePrints;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAN_PGN_SIM_4p7p2.CustomUserControls.ConfigUC
{
    public partial class VCPGN_UC_C : UserControl
    {
        #region Dimenssions
        int _width = 0;
        int _height = 0;
        public int _Width { get { return _width; } }
        public int _Height { get { return _height; } }
        #endregion
        int _myID = 0;
        int _myPGNint = 0;
        string _myPGNstr = "";
        string _myDescription = "";
        
        int __howmanyBytes = 1;
        int __margin = 8;
        int __Yoffset_toClearSpace = 38;
        int ____cursorX= 0;
        int _TOTALWDTHEREQUIRED = 0;
        int _TOTALHGTHEREQUIRED = 0;

        Dictionary<int, VCPNGDB_UC_C> _myByteTypes_UCs;

        VCPGN_BP _myVCPGN_BP;
        List<VCPGNDB_BP> _myVCPGNDB_BP;

        public VCPGN_UC_C(int argFRAMEID)
        {
            InitializeComponent();
            _myByteTypes_UCs = new Dictionary<int, VCPNGDB_UC_C>();
            _width= this.Width;
            _height= this.Height;
            lbl_BytesAmount.Text = __howmanyBytes.ToString();
            
            tb_DESC.TextChanged += Tb_DESC_TextChanged;
            btn_make.Click += Btn_make_Click;
            btn_plus.Click += Btn_plus_Click;   
            btn_minus.Click += Btn_minus_Click;

            _myID = argFRAMEID;
            _myVCPGNDB_BP = new List<VCPGNDB_BP>();
        }

        private void Btn_minus_Click(object sender, EventArgs e)
        {
            if(__howmanyBytes>1)
            {
                __howmanyBytes--;
                lbl_BytesAmount.Text = __howmanyBytes.ToString();
            }
            else
            {
                __howmanyBytes = 1;
                lbl_BytesAmount.Text = __howmanyBytes.ToString();
            }
        }
        private void Btn_plus_Click(object sender, EventArgs e)
        {
           if(__howmanyBytes<8)
            {
                __howmanyBytes++;
                lbl_BytesAmount.Text = __howmanyBytes.ToString();
            }
            else
            {
                __howmanyBytes = 8;
                lbl_BytesAmount.Text = __howmanyBytes.ToString();
            }
            
        }

        private void Btn_make_Click(object sender, EventArgs e)
        {
            if(_myByteTypes_UCs== null)
            {
                MessageBox.Show("No List of UCs");
                return;
            }
            else 
            if(_myByteTypes_UCs.Count > 0)
            {
                MessageBox.Show("List UCs isnot empty ");
                return;
            }
            else
            if (_myByteTypes_UCs.Count == 0)
            {

                //if(textBox_PGN.Text is null or string.Empty )
                if(string.IsNullOrEmpty(textBox_PGN.Text))
                {
                    MessageBox.Show("Please enter a PGN");
                    return;
                }

                int enteredpgn = 0;
                string _strPgn= textBox_PGN.Text;
                // Remove the "0x" prefix if it exists
                if (_strPgn.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                {
                    _strPgn = _strPgn.Substring(2);
                }

                bool success = int.TryParse(_strPgn, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out enteredpgn);

                if (!success)
                {
                     MessageBox.Show("PGN bad format");
                    return;
                }


                _myPGNint = enteredpgn;

                _myVCPGN_BP.ID = _myID;
                _myPGNstr = "0x"+_strPgn;


                if (string.IsNullOrEmpty(tb_DESC.Text))
                {
                    MessageBox.Show("Please enter a description of this PGN");
                    return;
                }

                _myDescription = tb_DESC.Text;
                _myVCPGN_BP.Description = _myDescription;

                _myVCPGN_BP.PGNint = _myPGNint;
                _myVCPGN_BP.PGNstr = _myPGNstr;

                for (int u=0; u< __howmanyBytes; u++)
                {
                    VCPNGDB_UC_C temp = new VCPNGDB_UC_C(u);
                    ____cursorX = __margin + (temp._Width + __margin) * u;
                    _TOTALHGTHEREQUIRED = temp._Height + __Yoffset_toClearSpace;
                    _TOTALWDTHEREQUIRED = ____cursorX + temp._Width + __margin;
                    temp.Location = new Point(____cursorX, __Yoffset_toClearSpace);
                    _myByteTypes_UCs.Add(u,temp);
                    temp.BlueBrintUpdatedEvent += ON_oneOfMuUc_BPUpdated;
                    this.Controls.Add(temp);
                }
                _width = _TOTALWDTHEREQUIRED;
                _height = _TOTALHGTHEREQUIRED;
                this.Width= _width;
                this.Height= _height ;
                btn_make.Enabled = false;
            }
        }

        private void ON_oneOfMuUc_BPUpdated(object sender, EventArgs e)
        {
          
            _myVCPGN_BP.ID = _myID;
            _myDescription=  tb_DESC.Text;
            _myVCPGN_BP.PGNint = _myPGNint;
            _myVCPGN_BP.Description = _myDescription;
           
            _myVCPGN_BP.ByteTypes = new List<VCPGNDB_BP>();
            foreach (VCPNGDB_UC_C temp in _myByteTypes_UCs.Values)
            {
                _myVCPGN_BP.ByteTypes.Add(temp._myVCPGNDB_BP);
            }



            //int tempid= ((VCPNGDB_UC_C)sender)._ID_uc;

            //lbl_debug1.Text= _myByteTypes_UCs.Values.ElementAt(tempid)._myVCPGNDB_BP._myType;
        }
        private void Tb_DESC_TextChanged(object sender, EventArgs e)
        {
            _myDescription= tb_DESC.Text;
        }
 

        public VCPGN_BP GET_BLUEPRINT()
        {

            _myVCPGN_BP.ID = _myID;
            _myDescription = tb_DESC.Text;
            _myVCPGN_BP.PGNint = _myPGNint;
            _myVCPGN_BP.Description = _myDescription;

            _myVCPGN_BP.ByteTypes = new List<VCPGNDB_BP>();
            foreach (VCPNGDB_UC_C temp in _myByteTypes_UCs.Values)
            {
                _myVCPGN_BP.ByteTypes.Add(temp._myVCPGNDB_BP);
            }

            return _myVCPGN_BP;
        }
    }
}
