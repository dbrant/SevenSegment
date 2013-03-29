namespace SevenSegTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDotOn = new System.Windows.Forms.CheckBox();
            this.chkDotShow = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sevenSegmentArray1 = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.sevenSegment1 = new DmitryBrant.CustomControls.SevenSegment();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Symbol:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 12);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(75, 38);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pattern:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDotOn);
            this.groupBox1.Controls.Add(this.chkDotShow);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Decimal point";
            // 
            // chkDotOn
            // 
            this.chkDotOn.AutoSize = true;
            this.chkDotOn.Location = new System.Drawing.Point(63, 21);
            this.chkDotOn.Name = "chkDotOn";
            this.chkDotOn.Size = new System.Drawing.Size(40, 17);
            this.chkDotOn.TabIndex = 3;
            this.chkDotOn.Text = "On";
            this.chkDotOn.UseVisualStyleBackColor = true;
            this.chkDotOn.CheckedChanged += new System.EventHandler(this.chkDotShow_CheckedChanged);
            // 
            // chkDotShow
            // 
            this.chkDotShow.AutoSize = true;
            this.chkDotShow.Checked = true;
            this.chkDotShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDotShow.Location = new System.Drawing.Point(10, 21);
            this.chkDotShow.Name = "chkDotShow";
            this.chkDotShow.Size = new System.Drawing.Size(53, 17);
            this.chkDotShow.TabIndex = 2;
            this.chkDotShow.Text = "Show";
            this.chkDotShow.UseVisualStyleBackColor = true;
            this.chkDotShow.CheckedChanged += new System.EventHandler(this.chkDotShow_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(71, 148);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown2.TabIndex = 10;
            this.numericUpDown2.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Elements:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Text:";
            // 
            // sevenSegmentArray1
            // 
            this.sevenSegmentArray1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sevenSegmentArray1.ArrayCount = 8;
            this.sevenSegmentArray1.ColorBackground = System.Drawing.Color.Black;
            this.sevenSegmentArray1.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sevenSegmentArray1.ColorLight = System.Drawing.Color.Red;
            this.sevenSegmentArray1.DecimalShow = true;
            this.sevenSegmentArray1.ElementPadding = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.sevenSegmentArray1.ElementWidth = 10;
            this.sevenSegmentArray1.ItalicFactor = -0.1F;
            this.sevenSegmentArray1.Location = new System.Drawing.Point(12, 174);
            this.sevenSegmentArray1.Name = "sevenSegmentArray1";
            this.sevenSegmentArray1.Size = new System.Drawing.Size(340, 69);
            this.sevenSegmentArray1.TabIndex = 8;
            this.sevenSegmentArray1.TabStop = false;
            this.sevenSegmentArray1.Value = "";
            // 
            // sevenSegment1
            // 
            this.sevenSegment1.ColorBackground = System.Drawing.Color.DimGray;
            this.sevenSegment1.ColorDark = System.Drawing.Color.DarkGray;
            this.sevenSegment1.ColorLight = System.Drawing.Color.Lime;
            this.sevenSegment1.CustomPattern = 0;
            this.sevenSegment1.DecimalOn = false;
            this.sevenSegment1.DecimalShow = true;
            this.sevenSegment1.ElementWidth = 10;
            this.sevenSegment1.ItalicFactor = -0.1F;
            this.sevenSegment1.Location = new System.Drawing.Point(146, 15);
            this.sevenSegment1.Name = "sevenSegment1";
            this.sevenSegment1.Padding = new System.Windows.Forms.Padding(12, 4, 8, 4);
            this.sevenSegment1.Size = new System.Drawing.Size(70, 98);
            this.sevenSegment1.TabIndex = 7;
            this.sevenSegment1.TabStop = false;
            this.sevenSegment1.Value = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 255);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.sevenSegmentArray1);
            this.Controls.Add(this.sevenSegment1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Seven-Segment Test";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkDotOn;
        private System.Windows.Forms.CheckBox chkDotShow;
        private DmitryBrant.CustomControls.SevenSegment sevenSegment1;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentArray1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;


    }
}

