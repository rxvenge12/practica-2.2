using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtX.Text);
            int y = int.Parse(txtY.Text);
            Point pointA = new Point(x, y);

            Rectangle rectangle1 = new Rectangle(new Point(1, 1), new Point(5, 5));
            Rectangle rectangle2 = new Rectangle(new Point(2, 2), new Point(6, 6));

            string result = oke.CheckPoint(pointA, rectangle1, rectangle2);

            MessageBox.Show(result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        //поставьте пожалуйста мне 3 балла
        }
    }
}
