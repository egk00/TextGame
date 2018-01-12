using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_TextGame
{
    public partial class Form1 : Form
    {
        Random random;
        Stats stats;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            stats = new Stats();

            toolStripStatusLabel1.Text = "Correct :" + stats.Correct;
            toolStripStatusLabel2.Text = "Missed : " + stats.Missed;
            toolStripStatusLabel3.Text = "Total : " + stats.Total;
            toolStripStatusLabel4.Text = "Accuray : " + stats.Accuray + "%";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if(listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game Ober");
                timer1.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                if (listBox1.Items.Contains(e.KeyCode))
                {
                    listBox1.Items.Remove(e.KeyCode);
                    listBox1.Refresh();
                    stats.Update(true);
                }
                else stats.Update(false);
            }
            toolStripStatusLabel1.Text = "Correct :" + stats.Correct;
            toolStripStatusLabel2.Text = "Missed : " + stats.Missed;
            toolStripStatusLabel3.Text = "Total : " + stats.Total;
            toolStripStatusLabel4.Text = "Accuray : " + stats.Accuray + "%";
        }
    }
}
