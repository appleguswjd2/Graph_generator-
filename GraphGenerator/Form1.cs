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
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Initialize text boxes value
            this.x_start.Text = "0";
            this.x_end.Text = "0.1";
            this.y_start.Text = "1000";
            this.y_end.Text = "40";
             mode1.Checked = true;

        }

        string matlab_dir = @"cd C:\temp\myfunction";//The folder directory where m-files saved 
        double mode = 0.1;
        double[,] res_x, res_y;

        private void mode1_CheckedChanged(object sender, EventArgs e)
        {
            //Linear graph 
            mode = 0.1;
        }
        private void mode2_CheckedChanged(object sender, EventArgs e)
        {
            //Log graph 
            mode = 0.2;
        }
        private void mode3_CheckedChanged(object sender, EventArgs e)
        {
            //Non-linear graph
            mode = 0.3;
        }

        private void overviewBtn_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(x_start.Text) || String.IsNullOrEmpty(x_end.Text) || String.IsNullOrEmpty(y_start.Text)
                || String.IsNullOrEmpty(y_end.Text))
            {
                MessageBox.Show("Please fill in the blanks");
            }//if
            else
            {

                double xStart = Double.Parse(x_start.Text);
                double xEnd = Double.Parse(x_end.Text);
                double yStart = Double.Parse(y_start.Text);
                double yEnd = Double.Parse(y_end.Text);

                // Create the MATLAB instance 
                MLApp.MLApp matlab = new MLApp.MLApp();


                // Change to the directory where the function is located 
                matlab.Execute(matlab_dir);

                // Define the output 
                object result = null;
                object[] res = null;
          

                // Call the MATLAB function according to the selected scan mode

                matlab.Feval("graphGenerator", 2, out result, mode, xStart, xEnd, yStart, yEnd);
                res = result as object[];

                // Plotting on chart
                for (int a = 0; a < res.Length; a++)
                {
                    if (a == 0)
                    {
                        res_x = (double[,])res[a];//ionization time
                    }
                    else if (a == 1)
                    {
                        res_y = (double[,])res[a];//cooling time
                    }
                }
               
                    windowGraph.Series["Result"].Points.Clear();
                for (int i = 0; i < res.Length; i++)
                {
                 // windowGraph.Series["Result"].Points.AddXY(res_x[0,i], res_y[0, i]);//xvalue, yvalue
                }
            }
        }

        private void jpegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save the graph as Jpeg image file
            this.windowGraph.SaveImage("C:\\temp\\myimage" + DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss") + ".jpeg", ChartImageFormat.Jpeg);

        }

        private void csvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save the data as CSV file
            RadioButton[] radioButtons = new RadioButton[] { mode1, mode2, mode3 };

            if (radioButtons.Any(rb => rb.Checked))
            {
                using (StreamWriter sw = new StreamWriter(@"C:\\temp\\myfile\\myCSVdata_AC_" + DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss") + ".csv"))
                {

                    for (int i = 0; i < res_x.Length; i++)
                    {
                        var line = String.Format("{0},{1}", res_x[0, i], res_y[0, i]);
                        sw.WriteLine(line);
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose the scan mode"); // No radio buttons are checked
            }

        }
    }
}
