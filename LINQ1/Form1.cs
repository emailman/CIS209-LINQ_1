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
            var myList =
                new List<String> { "red", "red", "blue", "green", "yellow", "yellow"};

            lbxThings.Items.AddRange(myList.ToArray());
            lblCountThings.Text = $"Number of things = {lbxThings.Items.Count}";

            var uniqueItems =
                (from item in myList
                select item).Distinct();
            
            lbxUniqueColors.Items.AddRange(uniqueItems.ToArray());
            lblUniqueThings.Text =
                $"Number of unique things = {lbxUniqueColors.Items.Count}";
        }

        private void lbxUniqueColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPickedColor.Text =
                $"You picked {lbxUniqueColors.SelectedItem}";
        }
    }
}
