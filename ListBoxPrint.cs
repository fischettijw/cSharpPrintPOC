using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpPrintPOC
{
    public class ListBoxPrint
    {
        public ListBox Lbx { get; set; }
        public int W1 { get; set; }
        public int W2 { get; set; }
        public int W3 { get; set; }
        public int W4 { get; set; }

        public ListBoxPrint(ListBox lbx, int w1 = 0, int w2 = 0, int w3 = 0, int w4 = 0)
        {
            Lbx = lbx;
            W1 = w1;
            W2 = w2;
            W3 = w3;
            W4 = w4;
        }

        public void Print(object V1 = null, object V2 = null, object V3 = null, object V4 = null)
        {
            string output = "";
            string v1 = ""; string v2 = ""; string v3 = ""; string v4 = "";
            if (V1 != null) v1 = V1.ToString().RJ(W1);
            if (V2 != null) v2 = V2.ToString().RJ(W2);
            if (V3 != null) v3 = V3.ToString().RJ(W3);
            if (V4 != null) v4 = V4.ToString().RJ(W4);
            output = v1 + v2 + v3 + v4;
            Lbx.Items.Add(output);
        }



    }
}
