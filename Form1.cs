using System;
using System.Windows.Forms;

/*
    Copyright (C) 2011-2013 Dmitry Brant <me@dmitrybrant.com>
  
    This software is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.
  
    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.
  
    You should have received a copy of the GNU General Public License along
    with this program; if not, write the Free Software Foundation, Inc., 51
    Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.

 */
namespace SevenSegTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "5";
            textBox2.Text = "3.14159";
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
