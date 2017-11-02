namespace graphGenerator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.overviewBtn = new System.Windows.Forms.Button();
            this.geneBtn = new System.Windows.Forms.Button();
            this.x_start = new System.Windows.Forms.TextBox();
            this.y_end = new System.Windows.Forms.TextBox();
            this.y_start = new System.Windows.Forms.TextBox();
            this.x_end = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.windowChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mode1 = new System.Windows.Forms.RadioButton();
            this.mode2 = new System.Windows.Forms.RadioButton();
            this.mode3 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jpegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.windowChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // overviewBtn
            // 
            this.overviewBtn.Location = new System.Drawing.Point(523, 52);
            this.overviewBtn.Name = "overviewBtn";
            this.overviewBtn.Size = new System.Drawing.Size(80, 19);
            this.overviewBtn.TabIndex = 0;
            this.overviewBtn.Text = "OVERVIEW";
            this.overviewBtn.UseVisualStyleBackColor = true;
            this.overviewBtn.Click += new System.EventHandler(this.overviewBtn_Click);
            // 
            // geneBtn
            // 
            this.geneBtn.Location = new System.Drawing.Point(523, 84);
            this.geneBtn.Name = "geneBtn";
            this.geneBtn.Size = new System.Drawing.Size(80, 19);
            this.geneBtn.TabIndex = 1;
            this.geneBtn.Text = "GENERATE";
            this.geneBtn.UseVisualStyleBackColor = true;
            this.geneBtn.Click += new System.EventHandler(this.geneBtn_Click);
            // 
            // x_start
            // 
            this.x_start.Location = new System.Drawing.Point(268, 55);
            this.x_start.Name = "x_start";
            this.x_start.Size = new System.Drawing.Size(80, 21);
            this.x_start.TabIndex = 2;
            // 
            // y_end
            // 
            this.y_end.Location = new System.Drawing.Point(384, 86);
            this.y_end.Name = "y_end";
            this.y_end.Size = new System.Drawing.Size(80, 21);
            this.y_end.TabIndex = 3;
            // 
            // y_start
            // 
            this.y_start.Location = new System.Drawing.Point(268, 87);
            this.y_start.Name = "y_start";
            this.y_start.Size = new System.Drawing.Size(80, 21);
            this.y_start.TabIndex = 4;
            // 
            // x_end
            // 
            this.x_end.Location = new System.Drawing.Point(384, 54);
            this.x_end.Name = "x_end";
            this.x_end.Size = new System.Drawing.Size(80, 21);
            this.x_end.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "START";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "END";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Y";
            // 
            // windowChart
            // 
            chartArea2.Name = "ChartArea1";
            this.windowChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.windowChart.Legends.Add(legend2);
            this.windowChart.Location = new System.Drawing.Point(77, 159);
            this.windowChart.Name = "windowChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Result";
            this.windowChart.Series.Add(series2);
            this.windowChart.Size = new System.Drawing.Size(699, 205);
            this.windowChart.TabIndex = 11;
            this.windowChart.Text = "windowChart";
            // 
            // mode1
            // 
            this.mode1.AutoSize = true;
            this.mode1.Location = new System.Drawing.Point(223, 128);
            this.mode1.Name = "mode1";
            this.mode1.Size = new System.Drawing.Size(53, 16);
            this.mode1.TabIndex = 12;
            this.mode1.TabStop = true;
            this.mode1.Text = "MODE1";
            this.mode1.UseVisualStyleBackColor = true;
            this.mode1.CheckedChanged += new System.EventHandler(this.mode1_CheckedChanged);
            // 
            // mode2
            // 
            this.mode2.AutoSize = true;
            this.mode2.Location = new System.Drawing.Point(374, 128);
            this.mode2.Name = "mode2";
            this.mode2.Size = new System.Drawing.Size(53, 16);
            this.mode2.TabIndex = 13;
            this.mode2.TabStop = true;
            this.mode2.Text = "MODE2";
            this.mode2.UseVisualStyleBackColor = true;
            this.mode2.CheckedChanged += new System.EventHandler(this.mode2_CheckedChanged_1);
            // 
            // mode3
            // 
            this.mode3.AutoSize = true;
            this.mode3.Location = new System.Drawing.Point(515, 128);
            this.mode3.Name = "mode3";
            this.mode3.Size = new System.Drawing.Size(53, 16);
            this.mode3.TabIndex = 14;
            this.mode3.TabStop = true;
            this.mode3.Text = "MODE3";
            this.mode3.UseVisualStyleBackColor = true;
            this.mode3.CheckedChanged += new System.EventHandler(this.mode3_CheckedChanged_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 25);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDataToolStripMenuItem,
            this.saveImageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveDataToolStripMenuItem
            // 
            this.saveDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csvToolStripMenuItem});
            this.saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            this.saveDataToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveDataToolStripMenuItem.Text = "Save data";
            // 
            // csvToolStripMenuItem
            // 
            this.csvToolStripMenuItem.Name = "csvToolStripMenuItem";
            this.csvToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.csvToolStripMenuItem.Text = "csv";
            this.csvToolStripMenuItem.Click += new System.EventHandler(this.csvToolStripMenuItem_Click);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jpegToolStripMenuItem});
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveImageToolStripMenuItem.Text = "Save image";
            // 
            // jpegToolStripMenuItem
            // 
            this.jpegToolStripMenuItem.Name = "jpegToolStripMenuItem";
            this.jpegToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.jpegToolStripMenuItem.Text = "jpeg";
            this.jpegToolStripMenuItem.Click += new System.EventHandler(this.jpegToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 376);
            this.Controls.Add(this.mode3);
            this.Controls.Add(this.mode2);
            this.Controls.Add(this.mode1);
            this.Controls.Add(this.windowChart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.x_end);
            this.Controls.Add(this.y_start);
            this.Controls.Add(this.y_end);
            this.Controls.Add(this.x_start);
            this.Controls.Add(this.geneBtn);
            this.Controls.Add(this.overviewBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "graphGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.windowChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button overviewBtn;
        private System.Windows.Forms.Button geneBtn;
        private System.Windows.Forms.TextBox x_start;
        private System.Windows.Forms.TextBox y_end;
        private System.Windows.Forms.TextBox y_start;
        private System.Windows.Forms.TextBox x_end;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart windowChart;
        private System.Windows.Forms.RadioButton mode1;
        private System.Windows.Forms.RadioButton mode2;
        private System.Windows.Forms.RadioButton mode3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jpegToolStripMenuItem;
    }
}

