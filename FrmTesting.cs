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
        ListBoxPrint p3;
        public FrmTesting()
        {
            InitializeComponent();
        }

        private void FrmTesting_Load(object sender, EventArgs e)
        {
            LbxOutput.Items.Clear();
            p1 = new ListBoxPrint(LbxOutput, 30, 8, 15); //Set Column Widths
            p1.Print("Col #1", "Col #2", "Col #3");  //Print Header Line
            p1.Print();  // Blank Line

            p2 = new ListBoxPrint(LbxOutput, 15, 10, 25); //Set Column Widths
            p2.Print("Col #4", "Col #5", "Col #6");  //Print Header Line
            p2.Print();  // Blank Line

            p3 = new ListBoxPrint(LbxOutput, 5, 5, 5, 5, 5, 5, 5, 5); //Set Column Widths
            p3.Print("A", "B", "C", "D", "E", "F", "G", "H");  //Print Header Line
            p3.Print();  // Blank Line
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            p1.Print("n=: "+"123", 456, 789.12345);   //Print Data Row
            p2.Print("456", 123, 987.12345);   //Print Data Row
            p3.Print(1, 2, 3, 4, 5, 6, 7, 8);
        }

    }

}
