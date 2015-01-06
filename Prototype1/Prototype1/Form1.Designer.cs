namespace Prototype1
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
            this.liberalLinkLabel = new System.Windows.Forms.LinkLabel();
            this.conservativeDescriptionBox = new System.Windows.Forms.TextBox();
            this.liberalDescriptionBox = new System.Windows.Forms.TextBox();
            this.conservativeListBox = new System.Windows.Forms.ListBox();
            this.liberalListBox = new System.Windows.Forms.ListBox();
            this.startButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.conservativeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // liberalLinkLabel
            // 
            this.liberalLinkLabel.AutoSize = true;
            this.liberalLinkLabel.Location = new System.Drawing.Point(950, 201);
            this.liberalLinkLabel.Name = "liberalLinkLabel";
            this.liberalLinkLabel.Size = new System.Drawing.Size(46, 13);
            this.liberalLinkLabel.TabIndex = 34;
            this.liberalLinkLabel.TabStop = true;
            this.liberalLinkLabel.Text = "Go To:  ";
            this.liberalLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.destinationLinkLabel_LinkClicked);
            // 
            // conservativeDescriptionBox
            // 
            this.conservativeDescriptionBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.conservativeDescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conservativeDescriptionBox.Enabled = false;
            this.conservativeDescriptionBox.Location = new System.Drawing.Point(3, 490);
            this.conservativeDescriptionBox.Multiline = true;
            this.conservativeDescriptionBox.Name = "conservativeDescriptionBox";
            this.conservativeDescriptionBox.Size = new System.Drawing.Size(910, 147);
            this.conservativeDescriptionBox.TabIndex = 33;
            // 
            // liberalDescriptionBox
            // 
            this.liberalDescriptionBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.liberalDescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.liberalDescriptionBox.Enabled = false;
            this.liberalDescriptionBox.Location = new System.Drawing.Point(3, 201);
            this.liberalDescriptionBox.Multiline = true;
            this.liberalDescriptionBox.Name = "liberalDescriptionBox";
            this.liberalDescriptionBox.Size = new System.Drawing.Size(910, 156);
            this.liberalDescriptionBox.TabIndex = 32;
            // 
            // conservativeListBox
            // 
            this.conservativeListBox.FormattingEnabled = true;
            this.conservativeListBox.Location = new System.Drawing.Point(3, 363);
            this.conservativeListBox.Name = "conservativeListBox";
            this.conservativeListBox.Size = new System.Drawing.Size(910, 121);
            this.conservativeListBox.TabIndex = 31;
            this.conservativeListBox.SelectedIndexChanged += new System.EventHandler(this.conservativeListBox_SelectedIndexChanged);
            // 
            // liberalListBox
            // 
            this.liberalListBox.FormattingEnabled = true;
            this.liberalListBox.Location = new System.Drawing.Point(3, 61);
            this.liberalListBox.Name = "liberalListBox";
            this.liberalListBox.Size = new System.Drawing.Size(910, 134);
            this.liberalListBox.TabIndex = 30;
            this.liberalListBox.SelectedIndexChanged += new System.EventHandler(this.liberalListBox_SelectedIndexChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(3, 31);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(910, 23);
            this.startButton.TabIndex = 29;
            this.startButton.Text = "Enter search term above and then click me";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(3, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(910, 20);
            this.searchTextBox.TabIndex = 28;
            // 
            // conservativeLinkLabel
            // 
            this.conservativeLinkLabel.AutoSize = true;
            this.conservativeLinkLabel.Location = new System.Drawing.Point(950, 471);
            this.conservativeLinkLabel.Name = "conservativeLinkLabel";
            this.conservativeLinkLabel.Size = new System.Drawing.Size(46, 13);
            this.conservativeLinkLabel.TabIndex = 35;
            this.conservativeLinkLabel.TabStop = true;
            this.conservativeLinkLabel.Text = "Go To:  ";
            this.conservativeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.conservativeLinkLabel_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 669);
            this.Controls.Add(this.conservativeLinkLabel);
            this.Controls.Add(this.liberalLinkLabel);
            this.Controls.Add(this.conservativeDescriptionBox);
            this.Controls.Add(this.liberalDescriptionBox);
            this.Controls.Add(this.conservativeListBox);
            this.Controls.Add(this.liberalListBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.searchTextBox);
            this.Name = "Form1";
            this.Text = "This is a test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel liberalLinkLabel;
        private System.Windows.Forms.TextBox conservativeDescriptionBox;
        private System.Windows.Forms.TextBox liberalDescriptionBox;
        private System.Windows.Forms.ListBox conservativeListBox;
        private System.Windows.Forms.ListBox liberalListBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.LinkLabel conservativeLinkLabel;
    }
}

