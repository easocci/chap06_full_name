using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Full_Name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The FullName method accepts arguments for a first
        // name, a middle name, and a last name. It returns
        // the full name.
        private string FullName(string first, string middle, string last)
        {
            return first + " " + middle + " " + last;
        }

        private void showFullNameButton_Click(object sender, EventArgs e)
        {
            ShowFullName();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            AppExit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppExit();
        }

        private void applicationShowFullNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFullName();

        }

        private void contextShowFullNameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowFullName();
        }


        private void ShowFullName()
        {
            // Variables to hold the first, middle, last, and full names
            string first, middle, last, full;

            // Get the first, middle, and last names.
            first = firstNameTextBox.Text;
            middle = middleNameTextBox.Text;
            last = lastNameTextBox.Text;

            // Get the full name.
            full = FullName(first, middle, last);

            // Display the full name.
            fullNameLabel.Text = full;

        }

        private void AppExit()
        {
            this.Close();
        }

        private void contextExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppExit();

        }
        private string ShowReverseFullName()
        {
            // Convert the name parts to be in reverse
            // order.

            string fullNameReversed = "";

            // Verify all three name parts are present.
            if ((lastNameTextBox.Text == "") ||
                (firstNameTextBox.Text == "") ||
                (middleNameTextBox.Text == ""))
            {
                MessageBox.Show("Sorry, but all three name " +
                    "parts must be present.");
                lastNameTextBox.Focus();
                return "";
            }
            else
            {

            }

                fullNameReversed = lastNameTextBox.Text +
                ", " +
                firstNameTextBox.Text +
                " " +
                middleNameTextBox.Text;
            // Obtain the string length.
            int fullNameReversedLength = 0;
            fullNameReversedLength = fullNameReversed.Length;
            return fullNameReversed +
                " (" +
                fullNameReversedLength.ToString() +
                ")";

        }
        private void applicationShowReverseFullNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fullNameLabel.Text = ShowReverseFullName();
        }

        private void contextShowReverseFullNameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fullNameLabel.Text = ShowReverseFullName();
        }
    }   





}
