namespace LINQ1
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
            this.lbxThings = new System.Windows.Forms.ListBox();
            this.lbxUniqueColors = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCountThings = new System.Windows.Forms.Label();
            this.lblUniqueThings = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPickedColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxThings
            // 
            this.lbxThings.FormattingEnabled = true;
            this.lbxThings.Location = new System.Drawing.Point(12, 107);
            this.lbxThings.Name = "lbxThings";
            this.lbxThings.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbxThings.Size = new System.Drawing.Size(120, 108);
            this.lbxThings.TabIndex = 0;
            // 
            // lbxUniqueColors
            // 
            this.lbxUniqueColors.FormattingEnabled = true;
            this.lbxUniqueColors.Location = new System.Drawing.Point(196, 107);
            this.lbxUniqueColors.Name = "lbxUniqueColors";
            this.lbxUniqueColors.Size = new System.Drawing.Size(145, 108);
            this.lbxUniqueColors.Sorted = true;
            this.lbxUniqueColors.TabIndex = 1;
            this.lbxUniqueColors.SelectedIndexChanged += new System.EventHandler(this.lbxUniqueColors_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of Colored Things";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ordered List of Unique Colors";
            // 
            // lblCountThings
            // 
            this.lblCountThings.AutoSize = true;
            this.lblCountThings.Location = new System.Drawing.Point(12, 236);
            this.lblCountThings.Name = "lblCountThings";
            this.lblCountThings.Size = new System.Drawing.Size(105, 13);
            this.lblCountThings.TabIndex = 4;
            this.lblCountThings.Text = "Number of things = 0";
            // 
            // lblUniqueThings
            // 
            this.lblUniqueThings.AutoSize = true;
            this.lblUniqueThings.Location = new System.Drawing.Point(193, 236);
            this.lblUniqueThings.Name = "lblUniqueThings";
            this.lblUniqueThings.Size = new System.Drawing.Size(140, 13);
            this.lblUniqueThings.TabIndex = 5;
            this.lblUniqueThings.Text = "Number of unique colors = 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pick a color from the list below";
            // 
            // lblPickedColor
            // 
            this.lblPickedColor.Location = new System.Drawing.Point(196, 264);
            this.lblPickedColor.Name = "lblPickedColor";
            this.lblPickedColor.Size = new System.Drawing.Size(137, 23);
            this.lblPickedColor.TabIndex = 7;
            this.lblPickedColor.Text = "Picked Color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 299);
            this.Controls.Add(this.lblPickedColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUniqueThings);
            this.Controls.Add(this.lblCountThings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxUniqueColors);
            this.Controls.Add(this.lbxThings);
            this.Name = "Form1";
            this.Text = "Pick a Color";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxThings;
        private System.Windows.Forms.ListBox lbxUniqueColors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCountThings;
        private System.Windows.Forms.Label lblUniqueThings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPickedColor;
    }
}

