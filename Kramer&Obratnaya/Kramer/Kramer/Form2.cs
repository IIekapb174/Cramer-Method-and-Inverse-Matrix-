using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kramer
{
    public partial class Form2 : Form
    {
        double b11, b12, b13, b21, b22, b23, b31, b32, b33, det, b111, b112, b113, b123, b221, b222, b223, b331, b332, b333, at;

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            b11 = Convert.ToInt32(a11.Text);
            b12 = Convert.ToInt32(a12.Text);
            b13 = Convert.ToInt32(a13.Text);
            b21 = Convert.ToInt32(a21.Text);
            b22 = Convert.ToInt32(a22.Text);
            b23 = Convert.ToInt32(a23.Text);
            b31 = Convert.ToInt32(a31.Text);
            b32 = Convert.ToInt32(a32.Text);
            b33 = Convert.ToInt32(a33.Text);
            Resultt.Text = Convert.ToString(det);
            aa11.Text = Convert.ToString(b111);
            aa21.Text = Convert.ToString(b221);
            aa31.Text = Convert.ToString(b331);
            aa12.Text = Convert.ToString(b112);
            aa22.Text = Convert.ToString(b222);
            aa32.Text = Convert.ToString(b332);
            aa13.Text = Convert.ToString(b113);
            aa23.Text = Convert.ToString(b223);
            aa33.Text = Convert.ToString(b333);


            det = b11 * b22 * b33 + b12 * b23 * b31 + b21 * b32 * b13 - b13 * b22 * b31 - b21 * b12 * b33 - b32 * b23 * b11;
            if (det == 0)
            {
                MessageBox.Show(
                    "Определитель = 0",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                    );  
            }
            else
            {
                b111 = (b22 * b33 - b32 * b23) / det;
                b221 = -(b21 * b33 - b23 * b31) / det;  // - =21
                b331 = (b21 * b32 - b22 * b31) / det;
                b112 = -(b12 * b33 - b13 * b32) / det; // - =12
                b222 = (b11 * b33 - b13 * b31) / det;
                b332 = -(b12 * b31 - b11 * b32) / det; // -  =32
                b113 = (b12 * b23 - b13 * b22) / det;
                b223 = -(b11 * b23 - b13 * b21) / det;  //  - =23
                b333 = (b11 * b22 - b12 * b21) / det;

               /* b112 = b221;
                b221 = b112;
                b223 = b332;
                b332 = b223;
                b113 = b331
                */
            }
        }

        private void Resultt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
