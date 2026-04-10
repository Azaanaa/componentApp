using System.Diagnostics;
using System.Drawing;
using System.Net.Mime;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace componentApp
{
    public partial class Form1 : Form
    {
        private ImageList myImageList;
        private int currentImageIndex = 0;

        public Form1()
        {
            InitializeComponent();
            //InitializeImageList();
            toolStripStatusLabel1.Text = "Ready";
            PopulateTreeView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkListBox();
        }

        private void checkListBox()
        {
            checkedListBox1.Items.Add("Option 1");
            checkedListBox1.Items.Add("Option 2", true); // Add item and check it by default
            checkedListBox1.Items.Add("Option 3");
            checkedListBox1.Items.Add("Option 4");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCheckListBox.Text = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    lblCheckListBox.Text = lblCheckListBox.Text + " " + checkedListBox1.Items[i].ToString();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblDatePicker.Text = dateTimePicker1.Value.ToString();
        }

        /*        private void InitializeImageList()
                {
                    // 1. Create an instance of the ImageList.
                    myImageList = new ImageList();

                    // 2. Set the properties for the images (e.g., size and color depth).
                    myImageList.ImageSize = new Size(64, 64);
                    myImageList.ColorDepth = ColorDepth.Depth32Bit;

                    // 3. Add images to the ImageList's Images collection.
                    // Replace the file paths with the actual paths to your image files.
                    try
                    {
                        myImageList.Images.Add(Image.FromFile(Environment.CurrentDirectory + "/images/img1.jpg"));
                        myImageList.Images.Add(Image.FromFile(Environment.CurrentDirectory + "/images/img2.jpg"));
                        myImageList.Images.Add(Image.FromFile(Environment.CurrentDirectory + "/images/img3.jpg"));
                    }
                    catch (System.IO.FileNotFoundException)
                    {
                        MessageBox.Show("Image files not found. Please update the file paths.");
                    }
                }

                private void button1_Click(object sender, EventArgs e)
                {
                    // Change the image in the PictureBox on each button click
                    if (myImageList.Images.Count > 0)
                    {
                        // Set the Image property of the PictureBox to the current image from the ImageList
                        pictureBox1.Image = myImageList.Images[currentImageIndex];

                        // Cycle through the images
                        currentImageIndex++;
                        if (currentImageIndex >= myImageList.Images.Count)
                        {
                            currentImageIndex = 0;
                        }
                    }
                } */

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog myDialog = new ColorDialog();

            // Optional: Set some properties
            myDialog.AllowFullOpen = true; // Allows the "Define Custom Colors" section
            myDialog.ShowHelp = false;     // Hides the help button (default)
            myDialog.Color = Color.Red;    // Sets the initial selected color

            // Show the dialog and check for a positive result (OK button clicked).
            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                // Apply the selected color to a control (e.g., the Form's background)
                button2.BackColor = myDialog.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Starting process...";
            toolStripProgressBar1.Value = 0; // Assuming toolStripProgressBar1 is added in the designer

            // Simulate progress
            for (int i = 0; i <= 100; i += 10)
            {
                toolStripProgressBar1.Value = i;
                // In a real application, you might use a BackgroundWorker or Task to prevent UI freezing
                System.Threading.Thread.Sleep(200);
            }

            toolStripStatusLabel1.Text = "Process finished.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 1. Create an instance of the FontDialog component.
            FontDialog fontDialog1 = new FontDialog();

            // 2. Optional: Set initial properties.
            // Set the initial font of the dialog to the current font of the TextBox
            fontDialog1.Font = textBox1.Font;

            // Allow the user to select a color in the dialog box
            fontDialog1.ShowColor = true;

            // Set the initial color of the dialog to the current color of the TextBox
            fontDialog1.Color = textBox1.ForeColor;

            // 3. Display the dialog box and check the result.
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                // 4. Apply the selected font and color to the TextBox if the user clicked OK.
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;
            }

            // Code following ShowDialog will not execute until the dialog is closed.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //mediaPlayer.URL = "e:\\stack.mp4";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "video files (*.mp4)|*.mp4";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    mediaPlayer.URL = filePath;

                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Return)
            {
                label1.Text = textBox2.Text;
                e.Handled = true; // Prevents the beep sound
            }

        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.Text = "Hover";
            label2.BackColor = Color.Navy;
            label2.ForeColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "Click";
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "HELLO";
            label2.BackColor = Color.Yellow;
            label2.ForeColor = Color.Red;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1 second
            timer1.Tick += new EventHandler(MyTimer_Tick);
            timer1.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            labelStatus.Text = "Updated at " + DateTime.Now.ToLongTimeString();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void PopulateTreeView()
        {
            // 1. Clear existing nodes
            treeView1.Nodes.Clear();

            // 2. Add a root node
            TreeNode rootNode = new TreeNode("My Computer");
            treeView1.Nodes.Add(rootNode);

            // 3. Add child nodes to the root
            TreeNode driveC = new TreeNode("Local Disk (C:)");
            TreeNode driveD = new TreeNode("Local Disk (D:)");
            rootNode.Nodes.Add(driveC);
            rootNode.Nodes.Add(driveD);

            // 4. Add sub-child nodes
            driveC.Nodes.Add(new TreeNode("Program Files"));
            driveC.Nodes.Add(new TreeNode("Users"));

            // Expand the root by default
            rootNode.Expand();
        }

        // Handle selection events
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show("Selected: " + e.Node.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.youtube.com/watch?v=D7GDTOSNQSk&list=RDD7GDTOSNQSk&start_radio=1");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.youtube.com/watch?v=D7GDTOSNQSk&list=RDD7GDTOSNQSk&start_radio=1")
            {
                UseShellExecute = true
            });
         
        }
    }

}
