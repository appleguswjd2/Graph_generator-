using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace graphGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.x_start.Text = "0";
            this.x_end.Text = "1";
            this.y_start.Text = "1000";
            this.y_end.Text = "400";
            this.mode1.Checked = true;
        }

        double mode = 0.1;//Initialize generating mode1
        int intMode = 1;
        string matlab_dir = @"cd C:\temp\";//the folder directory where matlab files are saved 
        double[,] res_x, res_y = null;

        private void mode1_CheckedChanged(object sender, EventArgs e)
        {
            mode = 0.1;
            intMode = 1;
        }

        private void mode2_CheckedChanged_1(object sender, EventArgs e)
        {
            mode = 0.2;
            intMode = 2;
        }


        private void mode3_CheckedChanged_1(object sender, EventArgs e)
        {
            mode = 0.3;
            intMode = 3;
        }

        private void jpegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.windowChart.SaveImage("C:\\temp\\myimage\\graph_mode_"+intMode+"_"+  DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss") + ".jpeg", ChartImageFormat.Jpeg);

        }

        private void csvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save data as csv
            RadioButton[] radioButtons = new RadioButton[] { mode1, mode2, mode3 };

            if (radioButtons.Any(rb => rb.Checked))
            {
                using (StreamWriter sw = new StreamWriter(@"C:\\temp\\myfile\\graph_mode_"+intMode + "_"+DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss") + ".csv"))
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

        private void geneBtn_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream("C:\\temp\\mydata\\graph_mode_" + intMode + "_" + DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss") + ".bin", FileMode.Create)) //  file directory.
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                {
                    for (int i = 0; i < res_x.Length; i++)
                    {
                        binaryWriter.Write(res_x[0, i]);
                    }
                    for (int i = 0; i < res_y.Length; i++)
                    {
                        binaryWriter.Write(res_y[0, i]);
                    }
                    binaryWriter.Close();
                }
            }
        }

        private void overviewBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(x_start.Text) || String.IsNullOrEmpty(x_end.Text) || String.IsNullOrEmpty(y_start.Text) || String.IsNullOrEmpty(y_end.Text))
            {
                MessageBox.Show("Fill in the values");//If there is an insufficient values, pop the message to fill in competely
            }
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
                matlab.Feval("graphGeneratorFunc", 2, out result, mode, xStart, xEnd, yStart, yEnd);//function name, return value number,output, input values...

                //For displaying data
                res = result as object[];

                for (int a = 0; a < res.Length; a++)
                {
                    if (a == 0)
                    {
                        res_x = (double[,])res[a];//x values
                    }
                    else if (a == 1)
                    {
                        res_y = (double[,])res[a];//y values
                    }
                }

                //Plotting the data
                windowChart.Series["Result"].Points.Clear();
                windowChart.ChartAreas[0].AxisX.Minimum = xStart;
                windowChart.ChartAreas[0].AxisX.Maximum = xEnd;

                for (int i = 0; i < res_y.Length; i++)
                {

                    windowChart.Series["Result"].Points.AddXY(res_x[0, i], res_y[0, i]);//xvalue, yvalue

                }

            }

        }
    }
}
