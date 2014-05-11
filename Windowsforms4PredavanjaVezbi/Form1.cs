using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Windowsforms4PredavanjaVezbi
{
    public partial class Form1 : Form
    {
        public Coins coinsDoc;

        public Form1()
        {
            InitializeComponent();
            coinsDoc = new Coins();
            this.DoubleBuffered = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush sb = new SolidBrush(Color.Gold);
            Pen pn = new Pen(Color.Black,1);
            Graphics g = panel1.CreateGraphics();
            g.Clear(Color.White);
            for (int i = 0; i < coinsDoc.numcoins; i++)
            {
                int y = panel1.Size.Height - 50 - 10 * i;
                g.FillEllipse(sb, 40, y, 100, 30);
                g.DrawEllipse(pn, 40,y, 100, 30);
               /* g.FillEllipse(sb, 40, y-9, 100, 30);
                g.DrawEllipse(pn, 40, y-9, 100, 30);*/
            
            }
            pn.Dispose();
            sb.Dispose();
        }

        private void addACoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            coinsDoc.AddCoin();
            Invalidate(true);
        }

        private void removeACoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            coinsDoc.RemoveOne();
            Invalidate(true);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            coinsDoc.AddCoin();
            Invalidate(true);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            coinsDoc.RemoveOne();
            Invalidate(true);
        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = "# of Coins :" + coinsDoc.numcoins.ToString();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Invalidate(true);
        }
    }
}
