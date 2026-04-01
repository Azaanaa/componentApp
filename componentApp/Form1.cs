using System.Windows.Forms;

namespace componentApp
{
    public partial class Form1 : Form
    {
        private ImageList myImageList;
        private int currentImageIndex = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeImageList();
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

        private void InitializeImageList()
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
        }

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
    }

}
