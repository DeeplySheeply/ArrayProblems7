using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SalesArray
{
    public partial class FrmStoreSales : Form
    {
        public FrmStoreSales()
        {
            InitializeComponent();
        }

        private void BtnSalesAnalysis_Click(object sender, EventArgs e)
        {
            //the core set of 2d and 1d arrays needed 
            int[,] sales = new int[4, 6];
            string[] emp = new string[4];
            string[] day = new string[6];
            double[] weights = new double[6];

            TxtDisplay.Clear();
            TxtDisplay.Text = "Quiz Score Analysis" + Environment.NewLine + Environment.NewLine;
            TxtDisplay.Text += "Original Data" + Environment.NewLine;

            //read in all the data 2d,1d
            DataFile(sales, emp, day, weights, 4, 6);
            Display(sales, emp, day, 4, 6);

            // 4. Change Frank's sales total
            TxtDisplay.Text += "Frank's sales total increased to 1500" + Environment.NewLine;
            ChangeSalesTotal(sales, 2, 3, 1500);
            Display(sales, emp, day, 4, 6);

            // 5. Copy Lucy’s sales for Wed into Karen’s sales for Monday.
            TxtDisplay.Text += "Karen's Monday sales total has changed" + Environment.NewLine;
            CopySalesTotal(sales, 3, 0, 1, 2, 1500);
            Display(sales, emp, day, 4, 6);

            // 6. Add 10 to all the sales totals.
            TxtDisplay.Text += "All sales totals have increased by 10" + Environment.NewLine;
            IncreaseSalesTotals(sales, 10);
            Display(sales, emp, day, 4, 6);

            // 7. Display the names of all salespeople and dates for which sales were below 1000
            TxtDisplay.Text += "Display all sales less than 1000" + Environment.NewLine;
            DisplaySalesCeilings(sales, emp, day, 1000);
            //Display(sales, emp, day, 4, 6);
        }

        // 1. Load the data into a 2-d array called Sales
        private void DataFile(int[,] s, string[] e, string[] d, double[] w, int rows, int cols)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\salesdata.txt";
            StreamReader read = new StreamReader(f);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    s[r, c] = Convert.ToInt32(read.ReadLine());
                }
            }
        // 2. Load all the names and days of the week into 1-d arrays called names and days
            for (int r = 0; r < rows; r++)
            {
                e[r] = read.ReadLine();
            }

            for (int c = 0; c < cols; c++)
            {
                d[c] = read.ReadLine();
            }

           /* for (int c = 1; c <= cols; c++)
            {
                w[c] = Convert.ToDouble(read.ReadLine());
            }*/

            read.Close();


        }
        // (int[,] qS, string[] sN, string[] qnD, int rows, int cols)
        private void Display(int[,] s, string[] e, string[] d,  int rows, int cols)
        {
            TxtDisplay.Text += Environment.NewLine;
            TxtDisplay.Text += "\t";

            for (int c = 0; c < cols; c++)
            {
                TxtDisplay.Text += d[c] + "\t";
            }

            TxtDisplay.Text += Environment.NewLine;

            for (int r = 0; r < rows; r++)
            {
                TxtDisplay.Text += e[r] + "\t";
                for (int c = 0; c < cols; c++)
                {
                    TxtDisplay.Text += Convert.ToString(s[r, c]) + "\t";
                }
                TxtDisplay.Text += Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;
        }

        private void ChangeSalesTotal(int[,] s, int row, int col, int newTotal)
        {
            s[row, col] = newTotal;

        }

        private void CopySalesTotal(int[,] s, int row, int col, int rowC, int colC, int copyTotal)
        {
            s[row, col] = s[rowC, colC];

        }

        private void IncreaseSalesTotals(int[,] s, int increment)
        {
            for (int r = 0; r < s.GetLength(0); r++)
            {
                for (int c = 0; c < s.GetLength(1); c++)
                {
                    s[r, c] += increment;
                }
            }           
        }

        private void DisplaySalesCeilings(int[,] s, string [] e, string []d, int ceiling)
        {
            TxtDisplay.Text += Environment.NewLine;
            for (int r = 0; r < s.GetLength(0); r++)
            {
                for (int c = 0; c < s.GetLength(1); c++)
                {
                    if (s[r, c] < 1000)
                    {
                        TxtDisplay.Text += e[r] + "\t" + d[c] + "\t" + Convert.ToString(s[r,c]) + Environment.NewLine;
                    }
                }
            }
        }
        private void TxtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
