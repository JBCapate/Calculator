using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(Formula.getSum);
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show(delegateAnswer(num1,num2).ToString());
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(Formula.getDivide);
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show(delegateAnswer(num1, num2).ToString());
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(Formula.getMultiply);
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show(delegateAnswer(num1, num2).ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(Formula.getSub);
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show(delegateAnswer(num1, num2).ToString());
        }
    }
}
