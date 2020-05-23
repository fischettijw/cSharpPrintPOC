using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpPrintPOC
{
    public partial class FrmTesting : Form
    {
        ListBoxPrint p1;
        ListBoxPrint p2;
        public FrmTesting()
        {
            InitializeComponent();
        }

        private void FrmTesting_Load(object sender, EventArgs e)
        {
            LbxOutput.Items.Clear();
            p1 = new ListBoxPrint(LbxOutput, 30, 8, 15); //Set Column Widths
            p1.Print("Col #1", "Col #2", "Col #3");  //Print Header Line
            p1.Print();

            p2 = new ListBoxPrint(LbxOutput, 15, 10, 25); //Set Column Widths
            p2.Print("Col #4", "Col #5", "Col #6");  //Print Header Line
            p2.Print();
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            p1.Print("n=: "+"123", 456, 789.12345);   //Print Data Row
            p2.Print("456", 123, 987.12345);   //Print Data Row
        }

    }

}
