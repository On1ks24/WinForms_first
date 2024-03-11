using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLogic;


namespace ekurs_5_semestr2_p2
{
    public partial class Form1 : Form
    {
        Logic logic { get; set; }

        public Form1()
        {
            InitializeComponent();
            logic = new Logic();
            logic.GeneratePeople();
            listBox1.Items.AddRange(logic.Print(logic.allpeoples));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logic.vsehnavac();
            listBox1.DataSource = null;
            listBox1.DataSource = logic.Print(logic.allpeoples);
            listBox2.DataSource = null;
            listBox2.DataSource = logic.Print(logic.peoplesonvac);
            listBox3.DataSource = null;
            listBox3.DataSource = logic.Print(logic.peoplewithsert);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logic.vsehnaperv();
            listBox1.DataSource = null;
            listBox1.DataSource = logic.Print(logic.allpeoples);
            listBox2.DataSource = null;
            listBox2.DataSource = logic.Print(logic.peoplesonvac);
            listBox3.DataSource = null;
            listBox3.DataSource = logic.Print(logic.peoplewithsert);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            logic.vsehnapovtor();
            listBox1.DataSource = null;
            listBox1.DataSource = logic.Print(logic.allpeoples);
            listBox2.DataSource = null;
            listBox2.DataSource = logic.Print(logic.peoplesonvac);
            listBox3.DataSource = null;
            listBox3.DataSource = logic.Print(logic.peoplewithsert);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            logic.vac();
            listBox1.DataSource = null;
            listBox1.DataSource = logic.Print(logic.allpeoples);
            listBox2.DataSource = null;
            listBox2.DataSource = logic.Print(logic.peoplesonvac);
            listBox3.DataSource = null;
            listBox3.DataSource = logic.Print(logic.peoplewithsert);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
