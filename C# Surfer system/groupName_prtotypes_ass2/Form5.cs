using groupName_prototypes_ass2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupName_prtotypes_ass2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void LogOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 showDriverDetails = new Form1();
            showDriverDetails.Show();
        }

        private void HireASurfBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 HireASurfBoard = new Form3();
            HireASurfBoard.Show();
        }

        private void BeginnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 showPayment = new Form3();
            showPayment.Show();
        }

        private void AdvancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 showPayment = new Form3();
            showPayment.Show();
        }

        private void ResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 showResults = new Form4();
            showResults.Show();
        }

        private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 showDetails = new Form2();
            showDetails.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
        
}
