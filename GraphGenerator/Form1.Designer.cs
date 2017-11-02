namespace WindowsFormsApplication1
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
            this.x_start = new System.Windows.Forms.TextBox();
            this.x_end = new System.Windows.Forms.TextBox();
            this.y_start = new System.Windows.Forms.TextBox();
            this.y_end = new System.Windows.Forms.TextBox();
            this.START = new System.Windows.Forms.Label();
            this.END = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.overviewBtn = new System.Windows.Forms.Button();
            this.generatorBtn = new System.Windows.Forms.Button();
            this.mode1 = new System.Windows.Forms.RadioButton();
            this.mode2 = new System.Windows.Forms.RadioButton();
            this.mode3 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jpegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // x_start
            // 
            this.x_start.Location = new System.Drawing.Point(245, 46);
            this.x_start.Name = "x_start";
            this.x_start.Size = new System.Drawing.Size(115, 21);
            this.x_start.TabIndex = 0;
            // 
            // x_end
            // 
            this.x_end.Location = new System.Drawing.Point(385, 46);
            this.x_end.Name = "x_end";
            this.x_end.Size = new System.Drawing.Size(115, 21);
            this.x_end.TabIndex = 1;
            // 
            // y_start
            // 
            this.y_start.Location = new System.Drawing.Point(245, 84);
            this.y_start.Name = "y_start";
            this.y_start.Size = new System.Drawing.Size(115, 21);
            this.y_start.TabIndex = 2;
            // 
            // y_end
            // 
            this.y_end.Location = new System.Drawing.Point(385, 84);
            this.y_end.Name = "y_end";
            this.y_end.Size = new System.Drawing.Size(115, 21);
            this.y_end.TabIndex = 3;
            // 
            // START
            // 
            this.START.AutoSize = true;
            this.START.Location = new System.Drawing.Point(282, 31);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(35, 12);
            this.START.TabIndex = 4;
            this.START.Text = "START";
            // 
            // END
            // 
            this.END.AutoSize = true;
            this.END.Location = new System.Drawing.Point(428, 31);
            this.END.Name = "END";
            this.END.Size = new System.Drawing.Size(23, 12);
            this.END.TabIndex = 5;
            this.END.Text = "END";
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(228, 49);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(11, 12);
            this.x.TabIndex = 6;
            this.x.Text = "X";
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Location = new System.Drawing.Point(228, 85);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(11, 12);
            this.y.TabIndex = 7;
            this.y.Text = "Y";
            // 
            // overviewBtn
            // 
            this.overviewBtn.Location = new System.Drawing.Point(576, 48);
            this.overviewBtn.Name = "overviewBtn";
            this.overviewBtn.Size = new System.Drawing.Size(90, 27);
            this.overviewBtn.TabIndex = 8;
            this.overviewBtn.Text = "OVERVIEW";
            this.overviewBtn.UseVisualStyleBackColor = true;
            this.overviewBtn.Click += new System.EventHandler(this.overviewBtn_Click);
            // 
            // generatorBtn
            // 
            this.generatorBtn.Location = new System.Drawing.Point(576, 77);
            this.generatorBtn.Name = "generatorBtn";
            this.generatorBtn.Size = new System.Drawing.Size(90, 28);
            this.generatorBtn.TabIndex = 9;
            this.generatorBtn.Text = "GENERATOR";
            this.generatorBtn.UseVisualStyleBackColor = true;
            // 
            // mode1
            // 
            this.mode1.AutoSize = true;
            this.mode1.Location = new System.Drawing.Point(184, 121);
            this.mode1.Name = "mode1";
            this.mode1.Size = new System.Drawing.Size(59, 16);
            this.mode1.TabIndex = 10;
            this.mode1.TabStop = true;
            this.mode1.Text = "MODE 1";
            this.mode1.UseVisualStyleBackColor = true;
            this.mode1.CheckedChanged += new System.EventHandler(this.mode1_CheckedChanged);
            // 
            // mode2
            // 
            this.mode2.AutoSize = true;
            this.mode2.Location = new System.Drawing.Point(332, 121);
            this.mode2.Name = "mode2";
            this.mode2.Size = new System.Drawing.Size(59, 16);
            this.mode2.TabIndex = 11;
            this.mode2.TabStop = true;
            this.mode2.Text = "MODE 2";
            this.mode2.UseVisualStyleBackColor = true;
            // 
            // mode3
            // 
            this.mode3.AutoSize = true;
            this.mode3.Location = new System.Drawing.Point(480, 121);
            this.mode3.Name = "mode3";
            this.mode3.Size = new System.Drawing.Size(59, 16);
            this.mode3.TabIndex = 12;
            this.mode3.TabStop = true;
            this.mode3.Text = "MODE 3";
            this.mode3.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 25);
            this.menuStrip1.TabIndex = 13;
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
            this.saveDataToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveDataToolStripMenuItem.Text = "Save data";
            // 
            // csvToolStripMenuItem
            // 
            this.csvToolStripMenuItem.Name = "csvToolStripMenuItem";
            this.csvToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.csvToolStripMenuItem.Text = "csv";
            this.csvToolStripMenuItem.Click += new System.EventHandler(this.csvToolStripMenuItem_Click);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jpegToolStripMenuItem});
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveImageToolStripMenuItem.Text = "Save image";
            // 
            // jpegToolStripMenuItem
            // 
            this.jpegToolStripMenuItem.Name = "jpegToolStripMenuItem";
            this.jpegToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.jpegToolStripMenuItem.Text = "jpeg";
            this.jpegToolStripMenuItem.Click += new System.EventHandler(this.jpegToolStripMenuItem_Click);
            // 
            // windowGraph
            // 
            chartArea2.Name = "ChartArea1";
            this.windowGraph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.windowGraph.Legends.Add(legend2);
            this.windowGraph.Location = new System.Drawing.Point(85, 143);
            this.windowGraph.Name = "windowGraph";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Result";
            this.windowGraph.Series.Add(series2);
            this.windowGraph.Size = new System.Drawing.Size(632, 243);
            this.windowGraph.TabIndex = 14;
            this.windowGraph.Text = "windowGraph";
            this.windowGraph.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 413);
            this.Controls.Add(this.windowGraph);
            this.Controls.Add(this.mode3);
            this.Controls.Add(this.mode2);
            this.Controls.Add(this.mode1);
            this.Controls.Add(this.generatorBtn);
            this.Controls.Add(this.overviewBtn);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.END);
            this.Controls.Add(this.START);
            this.Controls.Add(this.y_end);
            this.Controls.Add(this.y_start);
            this.Controls.Add(this.x_end);
            this.Controls.Add(this.x_start);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Graph_generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x_start;
        private System.Windows.Forms.TextBox x_end;
        private System.Windows.Forms.TextBox y_start;
        private System.Windows.Forms.TextBox y_end;
        private System.Windows.Forms.Label START;
        private System.Windows.Forms.Label END;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.Button overviewBtn;
        private System.Windows.Forms.Button generatorBtn;
        private System.Windows.Forms.RadioButton mode1;
        private System.Windows.Forms.RadioButton mode2;
        private System.Windows.Forms.RadioButton mode3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart windowGraph;
        private System.Windows.Forms.ToolStripMenuItem saveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jpegToolStripMenuItem;
    }
}

