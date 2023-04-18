namespace GDI_
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.btnCurve = new System.Windows.Forms.Button();
            this.btnClosedCurve = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnFillEllipse = new System.Windows.Forms.Button();
            this.btnFillRect = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.colorPickerPen = new EZControl.EZColorPicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colorPickerBrush = new EZControl.EZColorPicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPolygon);
            this.groupBox1.Controls.Add(this.btnText);
            this.groupBox1.Controls.Add(this.btnCurve);
            this.groupBox1.Controls.Add(this.btnClosedCurve);
            this.groupBox1.Controls.Add(this.btnEllipse);
            this.groupBox1.Controls.Add(this.btnFillEllipse);
            this.groupBox1.Controls.Add(this.btnFillRect);
            this.groupBox1.Controls.Add(this.btnRect);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(137, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(468, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "点击按钮绘制图形";
            // 
            // btnPolygon
            // 
            this.btnPolygon.Location = new System.Drawing.Point(329, 60);
            this.btnPolygon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(100, 35);
            this.btnPolygon.TabIndex = 3;
            this.btnPolygon.Text = "画多边形";
            this.btnPolygon.UseVisualStyleBackColor = true;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(221, 60);
            this.btnText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(100, 35);
            this.btnText.TabIndex = 2;
            this.btnText.Text = "绘制文字";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnCurve
            // 
            this.btnCurve.Location = new System.Drawing.Point(329, 25);
            this.btnCurve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCurve.Name = "btnCurve";
            this.btnCurve.Size = new System.Drawing.Size(100, 35);
            this.btnCurve.TabIndex = 1;
            this.btnCurve.Text = "非闭合曲线";
            this.btnCurve.UseVisualStyleBackColor = true;
            this.btnCurve.Click += new System.EventHandler(this.btnCurve_Click);
            // 
            // btnClosedCurve
            // 
            this.btnClosedCurve.Location = new System.Drawing.Point(221, 25);
            this.btnClosedCurve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClosedCurve.Name = "btnClosedCurve";
            this.btnClosedCurve.Size = new System.Drawing.Size(100, 35);
            this.btnClosedCurve.TabIndex = 1;
            this.btnClosedCurve.Text = "闭合曲线";
            this.btnClosedCurve.UseVisualStyleBackColor = true;
            this.btnClosedCurve.Click += new System.EventHandler(this.btnClosedCurve_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(119, 25);
            this.btnEllipse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(100, 35);
            this.btnEllipse.TabIndex = 0;
            this.btnEllipse.Text = "椭圆";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnFillEllipse
            // 
            this.btnFillEllipse.Location = new System.Drawing.Point(119, 60);
            this.btnFillEllipse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFillEllipse.Name = "btnFillEllipse";
            this.btnFillEllipse.Size = new System.Drawing.Size(100, 35);
            this.btnFillEllipse.TabIndex = 0;
            this.btnFillEllipse.Text = "填充椭圆";
            this.btnFillEllipse.UseVisualStyleBackColor = true;
            this.btnFillEllipse.Click += new System.EventHandler(this.btnFillEllipse_Click);
            // 
            // btnFillRect
            // 
            this.btnFillRect.Location = new System.Drawing.Point(16, 60);
            this.btnFillRect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFillRect.Name = "btnFillRect";
            this.btnFillRect.Size = new System.Drawing.Size(100, 35);
            this.btnFillRect.TabIndex = 0;
            this.btnFillRect.Text = "填充矩形";
            this.btnFillRect.UseVisualStyleBackColor = true;
            this.btnFillRect.Click += new System.EventHandler(this.btnFillRect_Click);
            // 
            // btnRect
            // 
            this.btnRect.Location = new System.Drawing.Point(16, 25);
            this.btnRect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(100, 35);
            this.btnRect.TabIndex = 0;
            this.btnRect.Text = "矩形";
            this.btnRect.UseVisualStyleBackColor = true;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // colorPickerPen
            // 
            this.colorPickerPen.Location = new System.Drawing.Point(64, 25);
            this.colorPickerPen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorPickerPen.Name = "colorPickerPen";
            this.colorPickerPen.Size = new System.Drawing.Size(59, 31);
            this.colorPickerPen.TabIndex = 1;
            this.colorPickerPen.Text = "ezColorPicker1";
            this.colorPickerPen.Value = System.Drawing.Color.Red;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 105);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.colorPickerBrush);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.colorPickerPen);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(137, 105);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "颜色";
            // 
            // colorPickerBrush
            // 
            this.colorPickerBrush.Location = new System.Drawing.Point(64, 64);
            this.colorPickerBrush.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorPickerBrush.Name = "colorPickerBrush";
            this.colorPickerBrush.Size = new System.Drawing.Size(59, 31);
            this.colorPickerBrush.TabIndex = 4;
            this.colorPickerBrush.Text = "ezColorPicker2";
            this.colorPickerBrush.Value = System.Drawing.Color.Green;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "画刷";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "画笔";
            // 
            // panelCanvas
            // 
            this.panelCanvas.BackColor = System.Drawing.Color.White;
            this.panelCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCanvas.Location = new System.Drawing.Point(0, 105);
            this.panelCanvas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(605, 324);
            this.panelCanvas.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 429);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Chapter_06_GDI+";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.Panel panel1;
        private EZControl.EZColorPicker colorPickerPen;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.GroupBox groupBox2;
        private EZControl.EZColorPicker colorPickerBrush;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.Button btnClosedCurve;
        private System.Windows.Forms.Button btnCurve;
        private System.Windows.Forms.Button btnFillEllipse;
        private System.Windows.Forms.Button btnFillRect;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnPolygon;
    }
}

