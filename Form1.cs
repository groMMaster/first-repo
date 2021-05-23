using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            this.Size = new Size(640, 480);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.BackColor = Color.Beige;

            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var graphics = e.Graphics;
            var start = 65;
            var end = start + 300;

            for (int step = start; step < end + 1; step += 50)
                graphics.DrawLine(new Pen(Color.Gray, 2), new Point(step, start), new Point(step, end));
            for (int step = start; step < end + 1; step += 50)
                graphics.DrawLine(new Pen(Color.Gray, 2), new Point(start, step), new Point(end, step));

            for (int i = start; i < end + 1; i += 50)
                for (int j = start; j < end + 1; j += 50)
                    ButtonCreator(i, j);
        }

        protected void ButtonCreator(int x, int y)
        {
            Button button = new Button();
            button.Size = new Size(6, 6);
            button.Left = x - 3;
            button.Top = y - 3;
            this.Controls.Add(button);
        }
    }
}
