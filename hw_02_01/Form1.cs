using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_02_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Palette
        {
            public Color[] color { get; set; } = new Color[5] { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Black };
            public int colorID { get; set; } = 0;
        }

        Palette plt = new Palette();

        bool brushOff = false;
        class Brush
        {
            public Size size = new Size(2, 2);
            public Color clr { get; set; } = Color.Red;

            public void ChangeColor(Palette plt)
            {
                if (plt.colorID < 4)
                    ++plt.colorID;
                else
                    plt.colorID = 0;

                clr = plt.color[plt.colorID];
            }

            public void ChangeSize(int value)
            {
                size.Width += value;
                size.Height += value;

            }
        }

        Brush brush = new Brush();

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //Text = $"X : {e.X}, Y : {e.Y}, Button : {e.Button.ToString()}";
            if (brushOff != true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    var label = new Label();
                    label.Size = brush.size;
                    label.BackColor = brush.clr;
                    label.Location = e.Location;
                    panel1.Controls.Add(label);
                }
            }
        }

        private void lb_color_Click(object sender, EventArgs e)
        {
            brush.ChangeColor(plt);
            lb_color.BackColor = brush.clr;
        }

        int valueCH = 2;
        private void btn_plus_Click(object sender, EventArgs e)
        {
            brush.ChangeSize(valueCH);
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (brush.size.Width - valueCH >= 2)
                if (brush.size.Height - valueCH >= 2)
                    brush.ChangeSize(-valueCH);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }

        private void btn_rctngl_Click(object sender, EventArgs e)
        {
            if (brushOff == false)
                brushOff = true;
            else
                brushOff = false;
        }

        int startX = 0;
        int startY = 0;
        int endX = 0;
        int endY = 0;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (brushOff == true)
            {
                startX = e.X;
                startY = e.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (brushOff == true)
            {
                endX = e.X;
                endY = e.Y;

                var label = new Label();
                label.BackColor = brush.clr;
                label.Size = new Size(endX - startX, endY - startY);
                label.Location = new Point(startX, startY);
                panel1.Controls.Add(label);
            }
        }
    }
}
