using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeVisualization
{
    /*
    C 0,0,50
    E -30,0,30,0,100
    P 4,40,40,-40,40,-40,-40,40,-40
    C 100,0,50
    E -30,0,30,0,100
    P 4,40,40,-40,40,-40,-40,40,-40
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "TXT(*.TXT)|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                var bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                
                ReadShape rs = new ReadShape();
                List<CreateContext> cc = rs.shapeRead(open.FileName);

                for (int i = 0; i < cc.Count; i++)
                {
                    ShapeFactory.CreateShape(cc[i]).Draw(bmp);

                }
                pictureBox1.Image = bmp;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PNG(*.PNG)|*.png";
            if (save.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(save.FileName);
            }
        }
    }
}
