namespace componentApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkedListBox1 = new CheckedListBox();
            lblCheckListBox = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblDatePicker = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            button2 = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            groupBox5 = new GroupBox();
            button3 = new Button();
            groupBox6 = new GroupBox();
            textBox1 = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(6, 22);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 148);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // lblCheckListBox
            // 
            lblCheckListBox.BorderStyle = BorderStyle.FixedSingle;
            lblCheckListBox.Location = new Point(6, 191);
            lblCheckListBox.Name = "lblCheckListBox";
            lblCheckListBox.Size = new Size(120, 53);
            lblCheckListBox.TabIndex = 1;
            lblCheckListBox.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 23);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblDatePicker
            // 
            lblDatePicker.BorderStyle = BorderStyle.FixedSingle;
            lblDatePicker.Location = new Point(6, 48);
            lblDatePicker.Name = "lblDatePicker";
            lblDatePicker.Size = new Size(215, 25);
            lblDatePicker.TabIndex = 3;
            lblDatePicker.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(6, 114);
            button1.Name = "button1";
            button1.Size = new Size(88, 35);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Controls.Add(lblCheckListBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(139, 258);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(lblDatePicker);
            groupBox2.Location = new Point(157, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 86);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(157, 104);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(112, 166);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(button2);
            groupBox4.Location = new Point(275, 104);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(116, 166);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(15, 22);
            button2.Name = "button2";
            button2.Size = new Size(88, 127);
            button2.TabIndex = 0;
            button2.Text = "Color dialog";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 590);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1391, 22);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.White;
            groupBox5.Controls.Add(button3);
            groupBox5.Location = new Point(397, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(200, 100);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(6, 31);
            button3.Name = "button3";
            button3.Size = new Size(179, 55);
            button3.TabIndex = 0;
            button3.Text = "Taskbar process";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.White;
            groupBox6.Controls.Add(button4);
            groupBox6.Controls.Add(textBox1);
            groupBox6.Location = new Point(397, 113);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(200, 157);
            groupBox6.TabIndex = 12;
            groupBox6.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Show the TEXT on the text box";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button4
            // 
            button4.Location = new Point(6, 76);
            button4.Name = "button4";
            button4.Size = new Size(179, 55);
            button4.TabIndex = 1;
            button4.Text = "Change Font";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1391, 612);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "COMPONENT";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Label lblCheckListBox;
        private DateTimePicker dateTimePicker1;
        private Label lblDatePicker;
        private PictureBox pictureBox1;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button button2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private GroupBox groupBox5;
        private Button button3;
        private ToolStripProgressBar toolStripProgressBar1;
        private GroupBox groupBox6;
        private Button button4;
        private TextBox textBox1;
    }
}
