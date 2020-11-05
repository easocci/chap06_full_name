namespace Full_Name
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
            this.components = new System.ComponentModel.Container();
            this.firstNamePromptLabel = new System.Windows.Forms.Label();
            this.middleNamePromptLabel = new System.Windows.Forms.Label();
            this.lastNamePromptLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.fullNameGroupBox = new System.Windows.Forms.GroupBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.showFullNameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationShowFullNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationShowReverseFullNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationLine1ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.applicationExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextShowFullNameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextShowReverseFullNameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextLineToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.contextExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullNameGroupBox.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.mainContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNamePromptLabel
            // 
            this.firstNamePromptLabel.AutoSize = true;
            this.firstNamePromptLabel.Location = new System.Drawing.Point(37, 27);
            this.firstNamePromptLabel.Name = "firstNamePromptLabel";
            this.firstNamePromptLabel.Size = new System.Drawing.Size(106, 13);
            this.firstNamePromptLabel.TabIndex = 0;
            this.firstNamePromptLabel.Text = "Enter your first name:";
            // 
            // middleNamePromptLabel
            // 
            this.middleNamePromptLabel.AutoSize = true;
            this.middleNamePromptLabel.Location = new System.Drawing.Point(23, 55);
            this.middleNamePromptLabel.Name = "middleNamePromptLabel";
            this.middleNamePromptLabel.Size = new System.Drawing.Size(120, 13);
            this.middleNamePromptLabel.TabIndex = 1;
            this.middleNamePromptLabel.Text = "Enter your middle name:";
            // 
            // lastNamePromptLabel
            // 
            this.lastNamePromptLabel.AutoSize = true;
            this.lastNamePromptLabel.Location = new System.Drawing.Point(37, 86);
            this.lastNamePromptLabel.Name = "lastNamePromptLabel";
            this.lastNamePromptLabel.Size = new System.Drawing.Size(106, 13);
            this.lastNamePromptLabel.TabIndex = 2;
            this.lastNamePromptLabel.Text = "Enter your last name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(153, 24);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(153, 51);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.middleNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(153, 82);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // fullNameGroupBox
            // 
            this.fullNameGroupBox.Controls.Add(this.fullNameLabel);
            this.fullNameGroupBox.Location = new System.Drawing.Point(26, 120);
            this.fullNameGroupBox.Name = "fullNameGroupBox";
            this.fullNameGroupBox.Size = new System.Drawing.Size(237, 66);
            this.fullNameGroupBox.TabIndex = 6;
            this.fullNameGroupBox.TabStop = false;
            this.fullNameGroupBox.Text = "Your Full Name";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameLabel.Location = new System.Drawing.Point(14, 25);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(207, 23);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showFullNameButton
            // 
            this.showFullNameButton.Location = new System.Drawing.Point(68, 203);
            this.showFullNameButton.Name = "showFullNameButton";
            this.showFullNameButton.Size = new System.Drawing.Size(75, 36);
            this.showFullNameButton.TabIndex = 7;
            this.showFullNameButton.Text = "Show Full Name";
            this.showFullNameButton.UseVisualStyleBackColor = true;
            this.showFullNameButton.Click += new System.EventHandler(this.showFullNameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(149, 203);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 36);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(294, 24);
            this.mainMenuStrip.TabIndex = 9;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationShowFullNameToolStripMenuItem,
            this.applicationShowReverseFullNameToolStripMenuItem,
            this.applicationLine1ToolStripSeparator1,
            this.applicationExitToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "&Application";
            // 
            // applicationShowFullNameToolStripMenuItem
            // 
            this.applicationShowFullNameToolStripMenuItem.Name = "applicationShowFullNameToolStripMenuItem";
            this.applicationShowFullNameToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.applicationShowFullNameToolStripMenuItem.Text = "Show &Full Name";
            this.applicationShowFullNameToolStripMenuItem.Click += new System.EventHandler(this.applicationShowFullNameToolStripMenuItem_Click);
            // 
            // applicationShowReverseFullNameToolStripMenuItem
            // 
            this.applicationShowReverseFullNameToolStripMenuItem.Name = "applicationShowReverseFullNameToolStripMenuItem";
            this.applicationShowReverseFullNameToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.applicationShowReverseFullNameToolStripMenuItem.Text = "Show &Reverse Full Name";
            this.applicationShowReverseFullNameToolStripMenuItem.Click += new System.EventHandler(this.applicationShowReverseFullNameToolStripMenuItem_Click);
            // 
            // applicationLine1ToolStripSeparator1
            // 
            this.applicationLine1ToolStripSeparator1.Name = "applicationLine1ToolStripSeparator1";
            this.applicationLine1ToolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // applicationExitToolStripMenuItem
            // 
            this.applicationExitToolStripMenuItem.Name = "applicationExitToolStripMenuItem";
            this.applicationExitToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.applicationExitToolStripMenuItem.Text = "E&xit";
            this.applicationExitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpAboutToolStripMenuItem
            // 
            this.helpAboutToolStripMenuItem.Name = "helpAboutToolStripMenuItem";
            this.helpAboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.helpAboutToolStripMenuItem.Text = "&About...";
            // 
            // mainContextMenuStrip
            // 
            this.mainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextShowFullNameToolStripMenuItem1,
            this.contextShowReverseFullNameToolStripMenuItem1,
            this.contextLineToolStripSeparator,
            this.contextExitToolStripMenuItem});
            this.mainContextMenuStrip.Name = "mainContextMenuStrip";
            this.mainContextMenuStrip.Size = new System.Drawing.Size(204, 98);
            // 
            // contextShowFullNameToolStripMenuItem1
            // 
            this.contextShowFullNameToolStripMenuItem1.Name = "contextShowFullNameToolStripMenuItem1";
            this.contextShowFullNameToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.contextShowFullNameToolStripMenuItem1.Text = "Show &Full Name";
            this.contextShowFullNameToolStripMenuItem1.Click += new System.EventHandler(this.contextShowFullNameToolStripMenuItem1_Click);
            // 
            // contextShowReverseFullNameToolStripMenuItem1
            // 
            this.contextShowReverseFullNameToolStripMenuItem1.Name = "contextShowReverseFullNameToolStripMenuItem1";
            this.contextShowReverseFullNameToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.contextShowReverseFullNameToolStripMenuItem1.Text = "Show &Reverse Full Name";
            this.contextShowReverseFullNameToolStripMenuItem1.Click += new System.EventHandler(this.contextShowReverseFullNameToolStripMenuItem1_Click);
            // 
            // contextLineToolStripSeparator
            // 
            this.contextLineToolStripSeparator.Name = "contextLineToolStripSeparator";
            this.contextLineToolStripSeparator.Size = new System.Drawing.Size(200, 6);
            // 
            // contextExitToolStripMenuItem
            // 
            this.contextExitToolStripMenuItem.Name = "contextExitToolStripMenuItem";
            this.contextExitToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.contextExitToolStripMenuItem.Text = "E&xit";
            this.contextExitToolStripMenuItem.Click += new System.EventHandler(this.contextExitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 271);
            this.ContextMenuStrip = this.mainContextMenuStrip;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showFullNameButton);
            this.Controls.Add(this.fullNameGroupBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNamePromptLabel);
            this.Controls.Add(this.middleNamePromptLabel);
            this.Controls.Add(this.firstNamePromptLabel);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapter 6 - Full Name";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.fullNameGroupBox.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNamePromptLabel;
        private System.Windows.Forms.Label middleNamePromptLabel;
        private System.Windows.Forms.Label lastNamePromptLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.GroupBox fullNameGroupBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Button showFullNameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationShowFullNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationShowReverseFullNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator applicationLine1ToolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem applicationExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpAboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip mainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem contextShowFullNameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contextShowReverseFullNameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator contextLineToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem contextExitToolStripMenuItem;
    }
}

