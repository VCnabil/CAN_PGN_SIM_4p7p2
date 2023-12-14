using CAN_PGN_SIM_4p7p2.BluePrints;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CAN_PGN_SIM_4p7p2.CustomUserControls.ConfigUC
{
    public partial class VCPNGDB_UC_C : UserControl
    {
        int _uniqID = 0;
        public int ID_uc => _uniqID;
        public event EventHandler BlueBrintUpdatedEvent;
        VCPGNDB_BP DB_BluePrint;
        public VCPGNDB_BP _myVCPGNDB_BP => DB_BluePrint;
        #region Dimenssions
        int _width = 0;
        int _height = 0;
        public int WidthControl => _width;
        public int HeightControl => _height;
        #endregion
        private List<string> list_ctrlTypes = new List<string> { "A 8bits", "B 8bit slider", "C 16bit slider", "D 8bit label", "E 16bit label" };
        TextBox[] tb_bit_arra;
        string __Lettertype = "";
        string __description = "";
        int __minimum = 0;
        int __maximum = 0;
        int __prim = 0;
        int __sec = 0;
        int __def = 0;
        string[] __bitDefinitions;
        public VCPNGDB_UC_C(int argid)
        {
            InitializeComponent();
            _uniqID = argid;
            comboBox_types.DataSource = list_ctrlTypes;
            comboBox_types.SelectedIndex = 0;
            __Lettertype = "A";
            lbl_ctrltype.Text = list_ctrlTypes[comboBox_types.SelectedIndex];
            tb_bit_arra = new TextBox[8];
            tb_bit_arra[0] = tb_bit0;
            tb_bit_arra[1] = tb_bit1;
            tb_bit_arra[2] = tb_bit2;
            tb_bit_arra[3] = tb_bit3;
            tb_bit_arra[4] = tb_bit4;
            tb_bit_arra[5] = tb_bit5;
            tb_bit_arra[6] = tb_bit6;
            tb_bit_arra[7] = tb_bit7;
            __bitDefinitions = new string[8];
            __bitDefinitions[0] = tb_bit_arra[0].Text;
            __bitDefinitions[1] = tb_bit_arra[1].Text;
            __bitDefinitions[2] = tb_bit_arra[2].Text;
            __bitDefinitions[3] = tb_bit_arra[3].Text;
            __bitDefinitions[4] = tb_bit_arra[4].Text;
            __bitDefinitions[5] = tb_bit_arra[5].Text;
            __bitDefinitions[6] = tb_bit_arra[6].Text;
            __bitDefinitions[7] = tb_bit_arra[7].Text;
            //whencombobox is used 
            comboBox_types.SelectedIndexChanged += ComboBox_types_SelectedIndexChanged;
            //when tb_Desc value changes , run event 
            tb_Desc.TextChanged += Avalue_has_Changed;
            tb_Max.TextChanged += Avalue_has_Changed;
            tb_defval.TextChanged += Avalue_has_Changed;
            tb_prim.TextChanged += Avalue_has_Changed;
            tb_bit0.TextChanged += Avalue_has_Changed;
            tb_bit1.TextChanged += Avalue_has_Changed;
            tb_bit2.TextChanged += Avalue_has_Changed;
            tb_bit3.TextChanged += Avalue_has_Changed;
            tb_bit4.TextChanged += Avalue_has_Changed;
            tb_bit5.TextChanged += Avalue_has_Changed;
            tb_bit6.TextChanged += Avalue_has_Changed;
            tb_bit7.TextChanged += Avalue_has_Changed;
            _width = this.Width;
            _height = this.Height;
            __prim = 0;
            __maximum = 255;
            __def = 0;
            __sec = 0;
            DB_BluePrint = new VCPGNDB_BP();
            UpdateValues_and_UI();
            Extract__values_();
            Populate_BP_0();
        }
        #region UIevents
        private void ComboBox_types_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_ctrltype.Text = list_ctrlTypes[comboBox_types.SelectedIndex];
            UpdateValues_and_UI();
            Extract__values_();
            Populated_BP_WithEVENT();
        }
        private void Avalue_has_Changed(object sender, EventArgs e)
        {
            Extract__values_();
            Populated_BP_WithEVENT();
        }
        #endregion
        void UpdateValues_and_UI()
        {
            //A
            if (__Lettertype == "A")
            {
                //******************how hide elements
                tb_Max.Hide();
                lbl_Max.Hide();
                tb_defval.Hide();
                lbl_defval.Hide();
                lbl_sectext.Hide();
                lbl_secVal.Hide();
                tableLayoutPanel1.Show();
            }
            //B or D
            if (__Lettertype == "B" || __Lettertype == "D")
            {
                tb_Max.Hide();
                lbl_Max.Hide();
                tb_defval.Hide();
                lbl_defval.Hide();
                lbl_sectext.Hide();
                lbl_secVal.Hide();
                tableLayoutPanel1.Hide();
            }
            //C or E
            if (__Lettertype == "C" || __Lettertype == "E")
            {
                //******************how hide elements
                tb_Max.Show();
                lbl_Max.Show();
                tb_defval.Show();
                lbl_defval.Show();
                lbl_sectext.Show();
                lbl_secVal.Show();
                tableLayoutPanel1.Hide();
            }
        }
        void Extract__values_()
        {
            if (comboBox_types.SelectedIndex == 0) { __Lettertype = "A"; }
            if (comboBox_types.SelectedIndex == 1) { __Lettertype = "B"; }
            if (comboBox_types.SelectedIndex == 2) { __Lettertype = "C"; }
            if (comboBox_types.SelectedIndex == 3) { __Lettertype = "D"; }
            if (comboBox_types.SelectedIndex == 4) { __Lettertype = "E"; }
            __description = tb_Desc.Text;
            __minimum = 0;
            int.TryParse(tb_Max.Text, out __maximum);
            if (__maximum < 3)
            {
                __maximum = 3;
            }
            if (__maximum > 0xFFFF)
            {
                __maximum = 0xFFFF;
            }
            int.TryParse(tb_defval.Text, out __def);
            if (__def < 0)
            {
                __def = 0;
            }
            if (__def > __maximum)
            {
                __def = __maximum;
            }
            //  Save the strings from tetxboxes 
            // __array  <------- to the textboxes
            for (int x = 0; x < 8; x++) { __bitDefinitions[x] = tb_bit_arra[x].Text; }
            int.TryParse(tb_prim.Text, out __prim);
            if (__prim < 1)
            {
                __prim = 1;
            }
            if (__prim > 8)
            {
                __prim = 8;
            }
            int.TryParse(lbl_secVal.Text, out __sec);
            if (__sec < 1)
            {
                __sec = 1;
            }
            __sec = __prim + 1;
            if (__sec > 8)
            {
                __sec = 8;
            }
            if (__sec == __prim && __prim > 1)
            {
                MessageBox.Show("Could be problematic , fix later ");
                return;
            }
        }
        void Populate_BP_0()
        {
            DB_BluePrint._myType = __Lettertype;
            DB_BluePrint._myDescription = __description;
            DB_BluePrint._myMin = __minimum;
            int.TryParse(tb_Max.Text, out __maximum);
            DB_BluePrint._myMax = __maximum;
            int.TryParse(tb_defval.Text, out __def);
            DB_BluePrint._muDefVal = __def;
            int.TryParse(tb_prim.Text, out __prim);
            DB_BluePrint._myByteIndexInPayload = __prim;
            int.TryParse(lbl_sectext.Text, out __sec);
            DB_BluePrint._myByteIndexInPayload_secondary = __sec;
            DB_BluePrint.bits_desc = __bitDefinitions.ToList();
        }
        void Populated_BP_WithEVENT()
        {
            DB_BluePrint._myType = __Lettertype;
            DB_BluePrint._myDescription = __description;
            DB_BluePrint._myMin = __minimum;
            int.TryParse(tb_Max.Text, out __maximum);
            DB_BluePrint._myMax = __maximum;
            int.TryParse(tb_defval.Text, out __def);
            DB_BluePrint._muDefVal = __def;
            int.TryParse(tb_prim.Text, out __prim);
            DB_BluePrint._myByteIndexInPayload = __prim;
            int.TryParse(lbl_sectext.Text, out __sec);
            DB_BluePrint._myByteIndexInPayload_secondary = __sec;
            DB_BluePrint.bits_desc = __bitDefinitions.ToList();
            if (BlueBrintUpdatedEvent != null)
            {
                BlueBrintUpdatedEvent.Invoke(this, new EventArgs());
                //MessageBox.Show("Event has subscribers, raising event.");
                // return;
            }
            else
            {
                MessageBox.Show("No subscribers to BlueBrintUpdatedEvent.");
                return;
            }
        }
        #region Handle Case A B C D E
        void CleanAndDisplay_Prim()
        {
            //***************************    handle Primarybyte index Elements
            int.TryParse(tb_prim.Text, out __prim);
            if (__prim < 1)
            {
                __prim = 1;
            }
            if (__prim > 8)
            {
                __prim = 8;
            }
            tb_prim.Text = __prim.ToString();
        }
        #endregion
    }
}