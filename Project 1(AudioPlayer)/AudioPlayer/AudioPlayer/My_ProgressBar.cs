using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioPlayer
{
    public partial class My_ProgressBar : UserControl
    {
        public My_ProgressBar()
        {
            InitializeComponent();
            this.Size = new Size(350, 15);
            this.BackColor = Color.DarkBlue;
            DoubleBuffered = true;
        }

        int pb_value = 30, pb_Min = 0, pb_Max = 100;

        float per = 0F;

        Color bara_color = Color.Aquamarine;

        public int Min
        {
            get { return pb_Min; }
            set { pb_Min = value; Invalidate(); }
        }
        public int Max
        {
            get { return pb_Max; }
            set { pb_Max = value; Invalidate(); }
        }
        public int Value
        {
            get { return pb_value; }
            set { pb_value = value; Invalidate(); }
        }

        public Color Bar_color 
        {
            get { return bara_color; }
            set { bara_color = value;Invalidate(); }
        }

        private void My_ProgressBar_Paint(object sender, PaintEventArgs e)
        {
            Color clr = Color.FromArgb(10, bara_color);
            SolidBrush br = new SolidBrush(bara_color);

            per  = (float)ClientSize.Width / pb_Max;
            e.Graphics.FillRectangle(br, new RectangleF(0,0, pb_value*per, ClientSize.Height));

            Pen pen = new Pen(Color.Black, 2);
            e.Graphics.DrawRectangle(pen, 0, 0, ClientSize.Width, ClientSize.Height);
        }
    }
}
