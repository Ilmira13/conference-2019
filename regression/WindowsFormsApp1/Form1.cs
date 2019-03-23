using System;
//using System.IO;
/* using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; */
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
        string range;
        double[] Telephons = new double [100];
        public static string NameExcel = @"D:\\Работа\\regression\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\1.xlsx";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //string startupPath = System.IO.Directory.GetParent(@"./").FullName;

       
            { 
             
      
        
                ObjExcel.Visible = true;
                                                                                                                                                                 
                Microsoft.Office.Interop.Excel.Workbook ObjWorkBook = ObjExcel.Workbooks.Open(NameExcel, 0, true, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
       
                Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;
                ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];

                for (int i = 1; i < 100; i++)
                {

                    range = ObjWorkSheet.get_Range("A" + i.ToString()).Text.ToString();
                    if (range == "")
                    {
                        Telephons[i - 1] = 0;
                    }
                    else
                    {
                        Telephons[i - 1] = Convert.ToDouble(range);
                    }
                }

                Regression Regression1 = new Regression(Telephons);
                double Mean = Regression1.Mean(Telephons);
           
              
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ObjExcel.Quit();
        }
    }

}