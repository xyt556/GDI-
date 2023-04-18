using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GDI_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            Graphics g = panelCanvas.CreateGraphics();
            g.Clear(Color.White);
            Pen pen = new Pen(colorPickerPen.Value);
            pen.Width = 1f;
            Rectangle rect = new Rectangle(1, 1, 100, 50);


            g.DrawRectangle(pen, rect);
            //g.DrawRectangle(pen, 10f, 10f, 200f, 150f);
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            Graphics g = panelCanvas.CreateGraphics();
            g.Clear(Color.White);
            Pen pen = new Pen(colorPickerPen.Value);

            Rectangle rect = new Rectangle(1, 1, 100, 50);

            g.DrawEllipse(pen, rect);

            g.DrawEllipse(pen, 10f, 10f, 200f, 150f);
        }

        private void btnClosedCurve_Click(object sender, EventArgs e)
        {
            Graphics g = panelCanvas.CreateGraphics();            
            g.Clear(Color.White);

            Pen pen = new Pen(colorPickerPen.Value, 2);
            Point p1 = new Point(50, 50);
            Point p2 = new Point(70, 25);
            Point p3 = new Point(100, 30);
            Point p4 = new Point(120, 85);
            Point p5 = new Point(80, 100);
            Point[] ps = { p1, p2, p3, p4, p5 };

            g.DrawClosedCurve(pen, ps, 0.9F, FillMode.Winding);

            pen = new Pen(colorPickerBrush.Value, 1);
            g.DrawClosedCurve(pen, ps, 0.3F, FillMode.Alternate);

            //SolidBrush brush = new SolidBrush(colorPickerBrush.Value);
            //g.FillClosedCurve(brush, ps, FillMode.Winding);
        }

        private void btnCurve_Click(object sender, EventArgs e)
        {
            Graphics g = panelCanvas.CreateGraphics();
            g.Clear(Color.White);
            Pen p = new Pen(colorPickerPen.Value, 2);
            Point p1 = new Point(50, 50);
            Point p2 = new Point(70, 25);
            Point p3 = new Point(100, 30);
            Point p4 = new Point(120, 85);
            Point p5 = new Point(80, 100);
            Point[] ps = { p1, p2, p3, p4, p5 };
            g.DrawCurve(p, ps,0.9F);
        
            p = new Pen(colorPickerBrush.Value, 1);
            g.DrawCurve(p, ps);
        }

        private void btnFillEllipse_Click(object sender, EventArgs e)
        {
            Graphics g = panelCanvas.CreateGraphics();//生成图形对象
            g.Clear(Color.White); 
            SolidBrush brush = new SolidBrush(colorPickerBrush.Value);//生成填充用的画刷
            int x = 10;//定义外接矩形的左上角坐标和高度及宽度
            int y = 10;
            int width = 200;
            int height = 150;
            Rectangle rect = new Rectangle(x, y, width, height);//定义矩形
            
            g.FillEllipse(brush, rect);//填充椭圆

        }

        private void btnFillRect_Click(object sender, EventArgs e)
        {
            Graphics g = panelCanvas.CreateGraphics();//生成图形对象
            g.Clear(Color.White);
            SolidBrush brush = new SolidBrush(colorPickerBrush.Value);//生成填充用的画刷
            int x = 10;//定义外接矩形的左上角坐标和高度及宽度
            int y = 10;
            int width = 200;
            int height = 150;
            Rectangle rect = new Rectangle(x, y, width, height);//定义矩形

            g.FillRectangle(brush, rect);//填充
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            Font f1 = new Font("黑体", 16F, FontStyle.Bold | FontStyle.Italic);
            SolidBrush brush = new SolidBrush(colorPickerBrush.Value);
            Graphics g = panelCanvas.CreateGraphics();
            g.Clear(Color.White);
            g.DrawString("地学程序设计Geological Programming", f1, brush, 100F, 100F);

            g.DrawString("HelloWorld!", f1, brush, 20F, 25F);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //panelCanvas.BackColor = Color.DarkGray;
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 3);//生成画笔;
            Graphics g = panelCanvas.CreateGraphics();//生成图形对象
            Point point1 = new Point(50, 50);//生成5个点	
            Point point2 = new Point(70, 25); Point point3 = new Point(100, 30);
            Point point4 = new Point(120, 85); Point point5 = new Point(80, 100);
            Point[] curvePoints = { point1, point2, point3, point4, point5 };
            g.DrawPolygon(blackPen, curvePoints);//绘制多边形


            Pen p = new Pen(colorPickerPen.Value, 2);
            Point[] curvePoints2 = { point2, point1, point3, point4, point5 };

            g.DrawPolygon(p, curvePoints2);//绘制多边形

        }
    }
}
