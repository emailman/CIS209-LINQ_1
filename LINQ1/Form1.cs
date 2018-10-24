using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LINQ1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Generate a list of things
            var myList =
                new List<String> { "red", "red", "blue", "green", "yellow", "yellow"};

            // Add the list to a List Box and count the number of things
            lbxThings.Items.AddRange(myList.ToArray());
            lblCountThings.Text = $"Number of things = {lbxThings.Items.Count}";

            // Query the list for unique items
            var uniqueItems =
                (from item in myList
                select item).Distinct();

            // Display the query results in a list and count the results
            lbxUniqueColors.Items.AddRange(uniqueItems.ToArray());
            lblUniqueThings.Text =
                $"Number of unique colors = {lbxUniqueColors.Items.Count}";
        }

        private void lbxUniqueColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Report which item was selected from the list
            lblPickedColor.Text =
                $"You picked {lbxUniqueColors.SelectedItem}";
        }
    }
}
