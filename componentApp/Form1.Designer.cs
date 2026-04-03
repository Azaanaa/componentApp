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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            button4 = new Button();
            textBox1 = new TextBox();
            groupBox7 = new GroupBox();
            button5 = new Button();
            mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            groupBox8 = new GroupBox();
            label1 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mediaPlayer).BeginInit();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(7, 29);
            checkedListBox1.Margin = new Padding(3, 4, 3, 4);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(137, 180);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // lblCheckListBox
            // 
            lblCheckListBox.BorderStyle = BorderStyle.FixedSingle;
            lblCheckListBox.Location = new Point(7, 255);
            lblCheckListBox.Name = "lblCheckListBox";
            lblCheckListBox.Size = new Size(137, 70);
            lblCheckListBox.TabIndex = 1;
            lblCheckListBox.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(7, 29);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(245, 27);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblDatePicker
            // 
            lblDatePicker.BorderStyle = BorderStyle.FixedSingle;
            lblDatePicker.Location = new Point(7, 64);
            lblDatePicker.Name = "lblDatePicker";
            lblDatePicker.Size = new Size(245, 33);
            lblDatePicker.TabIndex = 3;
            lblDatePicker.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(7, 29);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(19, 179);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Controls.Add(lblCheckListBox);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(159, 366);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(lblDatePicker);
            groupBox2.Location = new Point(179, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(267, 115);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(179, 139);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(128, 243);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(button2);
            groupBox4.Location = new Point(314, 139);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(133, 243);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(17, 29);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(101, 169);
            button2.TabIndex = 0;
            button2.Text = "Color dialog";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 789);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1590, 27);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(151, 21);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(114, 19);
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.White;
            groupBox5.Controls.Add(button3);
            groupBox5.Location = new Point(454, 16);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(229, 133);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(7, 41);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(205, 73);
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
            groupBox6.Location = new Point(454, 151);
            groupBox6.Margin = new Padding(3, 4, 3, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 4, 3, 4);
            groupBox6.Size = new Size(229, 231);
            groupBox6.TabIndex = 12;
            groupBox6.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(7, 101);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(205, 73);
            button4.TabIndex = 1;
            button4.Text = "Change Font";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 44);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Show the TEXT on the text box";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox7
            // 
            groupBox7.BackColor = Color.White;
            groupBox7.Controls.Add(button5);
            groupBox7.Controls.Add(mediaPlayer);
            groupBox7.Location = new Point(690, 17);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(888, 365);
            groupBox7.TabIndex = 13;
            groupBox7.TabStop = false;
            // 
            // button5
            // 
            button5.Location = new Point(686, 26);
            button5.Name = "button5";
            button5.Size = new Size(173, 66);
            button5.TabIndex = 1;
            button5.Text = "Open video";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // mediaPlayer
            // 
            mediaPlayer.Enabled = true;
            mediaPlayer.Location = new Point(23, 23);
            mediaPlayer.Name = "mediaPlayer";
            mediaPlayer.OcxState = (AxHost.State)resources.GetObject("mediaPlayer.OcxState");
            mediaPlayer.Size = new Size(631, 309);
            mediaPlayer.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.BackColor = Color.White;
            groupBox8.Controls.Add(label1);
            groupBox8.Controls.Add(textBox2);
            groupBox8.Location = new Point(14, 398);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(293, 135);
            groupBox8.TabIndex = 14;
            groupBox8.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 83);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 15;
            label1.Text = "label1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 26);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 27);
            textBox2.TabIndex = 15;
            textBox2.Text = "Write and Press enter";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1590, 816);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
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
            groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mediaPlayer).EndInit();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
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
        private GroupBox groupBox7;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private Button button5;
        private GroupBox groupBox8;
        private Label label1;
        private TextBox textBox2;
    }
}
