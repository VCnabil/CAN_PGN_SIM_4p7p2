using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAN_PGN_SIM_4p7p2.CustomUserControls.ConfigUC;
using static System.Net.Mime.MediaTypeNames;
using Newtonsoft.Json;
using CAN_PGN_SIM_4p7p2.BluePrints;

namespace CAN_PGN_SIM_4p7p2.UiBuilders
{
    public class Builder_UI_JSONWRITE
    {
         List<VCPGN_BP> List_BP_ToSerialize;
        List<VCPGN_UC_C> List_of_UCrows;
        VCPGN_UC_C test_UCrow;
        int ___YCursor= 40;
        int _yoffset = 40 ;
        int __margin = 8;
        int RowHeight = 0;
        int TotalWidth = 0;
        int TotalHeight = 0;

        public int WidthFINAL { get { return TotalWidth; } }
        public int HeightFINAL { get { return TotalHeight; } }
        public Builder_UI_JSONWRITE(Form1 argForm1, FlowLayoutPanel argpanel,int arg_howmanyRows) {
            List_BP_ToSerialize = new List<VCPGN_BP>();
            List_of_UCrows  = new List<VCPGN_UC_C>();


            argpanel.Width = 1300;
            argpanel.Height = 900;
            for (int i = 0; i < arg_howmanyRows; i++)
            {
                test_UCrow = new VCPGN_UC_C(i);
                RowHeight= test_UCrow._Height;
                if (i == 0) {
                    ___YCursor = 40;
                }
                else
                ___YCursor = _yoffset + (test_UCrow._Height + __margin) * i;

                List_of_UCrows.Add(test_UCrow);
                argpanel.Controls.Add(test_UCrow);
                test_UCrow.Location = new System.Drawing.Point(0, ___YCursor);
            }
            TotalWidth = 1380;
            TotalHeight = 980;// ___YCursor + RowHeight + __margin;
        }

        public void MakeJson() {

            string path_pre = "C:\\___Root_VCI_Projects\\AL_SEER\\SAVEDFILES\\newday\\filetest_";

            string path_post = ".json";
            string random_3numbers = new Random().Next(100, 999).ToString();
            string path = path_pre + random_3numbers + path_post;

            for (int x = 0; x < List_of_UCrows.Count; x++) {
                List_BP_ToSerialize.Add(List_of_UCrows[x].GET_BLUEPRINT()); 
            }

            string json = JsonConvert.SerializeObject(List_BP_ToSerialize.ToArray());

            System.IO.File.WriteAllText(path, json);
        }
    }
}
