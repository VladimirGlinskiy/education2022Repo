using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace VGlinskii.WinForms.Exam
{

    public partial class KartinkerForm : Form
    {
        int imageIndex = 0;
        int imagesAmount = FileSystemHelpers.picturesNamesArray.Length;
        string userName;

        public struct SImageInfo
        {
            public int pictureRate;
            public double averagePictureRate; 

        };

        public KartinkerForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            userName = ConnectionHelpers.getUserName();
            Text = $"{userName}, Welcome to Kartinker 2.0";
            string imagePath = FileSystemHelpers.picturesNamesArray[imageIndex];
            SImageInfo imageInfo = ConnectionHelpers.getImageRating(FileSystemHelpers.getFileName(imagePath), userName); 
            
            //Show picture
            try
            {
                Image newImage = Image.FromFile(imagePath);
                PictureBox.Image = newImage;
            }
            catch (FileNotFoundException exception) {
                MessageBox.Show(exception.Message);
            }

            //Show rating 

            int rating =  imageInfo.pictureRate;
            
            if (rating > 0)
            {
                chooseRatingBox.Text = rating.ToString();
            }
            else {
                chooseRatingBox.Text = "Rate the picture";
            }

            //Show average rating 
            double averageRating = imageInfo.averagePictureRate;

            if (averageRating > 0)
            {
                averageRate.Text = averageRating.ToString();
            }
            else {
                averageRate.Text = "The picture \n hasn't been rated yet";
            }

            pictureIndex.Text = $"{imageIndex+1} out of {imagesAmount}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string imagePath = FileSystemHelpers.picturesNamesArray[imageIndex];
            SImageInfo imageInfo = ConnectionHelpers.setImageRating(FileSystemHelpers.getFileName(imagePath), userName, Convert.ToInt32(chooseRatingBox.Text));
            averageRate.Text = imageInfo.averagePictureRate.ToString();
        }

        private void goRightButton_Click(object sender, EventArgs e)
        {
            if (imageIndex == imagesAmount-1) {
                imageIndex = 0;
            } 
            else { 
                imageIndex++; 
            }
            Form1_Load(sender, e);
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            {
                if (imageIndex == 0)
                {
                    imageIndex = imagesAmount - 1;
                }
                else
                {
                    imageIndex--;
                }

                Form1_Load(sender, e);
            }
        }

        private void getRandomPictureButton_Click(object sender, EventArgs e)
        {
            imageIndex = FileSystemHelpers.getRandomPictureIndex();
            Form1_Load(sender, e);
        }

        private void KartinkerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
