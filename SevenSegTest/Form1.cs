using System;
using System.Windows.Forms;

namespace SevenSegTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "5";
            textBox2.Text = "3.1415";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sevenSegment1.Value = textBox1.Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            sevenSegment1.CustomPattern = (int)numericUpDown1.Value;
        }

        private void chkDotShow_CheckedChanged(object sender, EventArgs e)
        {
            sevenSegment1.DecimalShow = chkDotShow.Checked;
            sevenSegment1.DecimalOn = chkDotOn.Checked;
            sevenSegment1.ColonShow = chkColonShow.Checked;
            sevenSegment1.ColonOn = chkColonOn.Checked;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sevenSegmentArray1.Value = textBox2.Text;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            sevenSegmentArray1.ArrayCount = (int)numericUpDown2.Value;
        }

    }
}
