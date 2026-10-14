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
        List<string> secilenler = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox2.Items.Add("rize");
            listBox2.Items.Add("bitlis");
            listBox2.Items.Add("yozgat");
            listBox2.Items.Add("istanbul");
            listBox2.Items.Add("ankara");
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // seçimi kaldırılanları listeden çıkar
            for (int i = secilenler.Count - 1; i >= 0; i--)
            {
                if (!listBox2.SelectedItems.Contains(secilenler[i]))
                    secilenler.RemoveAt(i);
            }

            // yeni seçilenleri sona ekle
            for (int i = 0; i < listBox2.SelectedItems.Count; i++)
            {
                string sehir = listBox2.SelectedItems[i].ToString();
                if (!secilenler.Contains(sehir))
                    secilenler.Add(sehir);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();

            for (int i = 0; i < secilenler.Count; i++)
                listBox3.Items.Add(secilenler[i]);
        }
    }
}
