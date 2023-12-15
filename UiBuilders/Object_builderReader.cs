using CAN_PGN_SIM_4p7p2.BluePrints;
using CAN_PGN_SIM_4p7p2.CustomUserControls.SimulaUC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAN_PGN_SIM_4p7p2.UiBuilders
{
    internal class Object_builderReader
    {
        const int _StructureWidth = 404;
        int ___XCursor = 0;
        int argYoffset = 40;
        int __margin = 8;
        int TotalWidth = 0;
        int TotalHeight = 0;
        string _filename_objbuilder = "sameFile2apps";

        public int WidthFINAL { get { return TotalWidth; } }
        public int HeightFINAL { get { return TotalHeight; } }


        Dictionary<int, VC_PGN_ColCtrlr_UC> ActivePgnsOnScreen;
        List<VCPGN_BP> LoadJsonFile(string path)
        {
            string json = System.IO.File.ReadAllText(path);
            List<VCPGN_BP> myPgnList = JsonConvert.DeserializeObject<List<VCPGN_BP>>(json);
            return myPgnList;
        }

        List<VCPGN_BP> mylistOfObjs;
        public Object_builderReader(Form2_CANSIM argform, FlowLayoutPanel argpanel, string argfilename )
        {
            _filename_objbuilder = argfilename;
            ActivePgnsOnScreen = new Dictionary<int, VC_PGN_ColCtrlr_UC>();
            string path_filenameFromMain = "C:\\___Root_VCI_Projects\\AL_SEER\\SAVEDFILES\\newday\\__" + _filename_objbuilder + ".json";
            //string pathSameFile = "C:\\___Root_VCI_Projects\\AL_SEER\\SAVEDFILES\\newday\\__sameFile.json";
            mylistOfObjs = LoadJsonFile(path_filenameFromMain);
           // mylistOfObjs = LoadJsonFile("C:\\___Root_VCI_Projects\\AL_SEER\\SAVEDFILES\\test5.json");
            int listsize = mylistOfObjs.Count;

            List<int> FoundPGNS = new List<int>();

            for (int x = 0; x < listsize; x++)
            {
                int apgn = mylistOfObjs[x].PGNint;
                FoundPGNS.Add(apgn);
            }

            if (!List_of_int_Has_Only_Unique_numbers(FoundPGNS))
            {
                throw new InvalidOperationException("The list contains duplicate numbers.");

            }

            for (int x = 0; x < listsize; x++)
            {

                VC_PGN_ColCtrlr_UC my_PGN_Ctrl0 = new VC_PGN_ColCtrlr_UC();
                //get the first object in the list
                VCPGN_BP myFirstObj = mylistOfObjs[x];
                int intID = myFirstObj.ID;
                int PGNint = myFirstObj.PGNint;
                string thBigDescription = myFirstObj.Description;
                List<VCPGNDB_BP> list = myFirstObj.ByteTypes;



                my_PGN_Ctrl0.SetMeUp_withGenericBytes(list, PGNint, thBigDescription);

                ActivePgnsOnScreen.Add(PGNint, my_PGN_Ctrl0);
                my_PGN_Ctrl0.Location = new Point( argYoffset,___XCursor);
                argpanel.Controls.Add(my_PGN_Ctrl0);
                //argform.Controls.Add(my_PGN_Ctrl0);

                ___XCursor += _StructureWidth;

            }
            argpanel.Width = ___XCursor + 10; ;
            argpanel.Height = argYoffset + 860;
            TotalWidth = ___XCursor+40;
            TotalHeight = argYoffset + 980;

            argform.Width = TotalWidth;
            argform.Height = TotalHeight;
        }

        bool List_of_int_Has_Only_Unique_numbers(List<int> argListints)
        {
            HashSet<int> uniqueNumbers = new HashSet<int>(argListints);

            bool _isOnlyuniques = uniqueNumbers.Count == argListints.Count;

            return _isOnlyuniques;

        }

        public Dictionary<int, VC_PGN_ColCtrlr_UC> GetDICT_forCAN()
        {
            return this.ActivePgnsOnScreen;
        }
    }
}
