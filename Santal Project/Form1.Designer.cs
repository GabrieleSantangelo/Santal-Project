namespace Santal_Project
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
            this.languageList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.projectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.Gitselection = new System.Windows.Forms.CheckBox();
            this.FileOpen = new System.Windows.Forms.CheckBox();
            this.OpenFolder = new System.Windows.Forms.CheckBox();
            this.Add_Language = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // languageList
            // 
            this.languageList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageList.FormattingEnabled = true;
            this.languageList.Location = new System.Drawing.Point(12, 100);
            this.languageList.Name = "languageList";
            this.languageList.Size = new System.Drawing.Size(438, 28);
            this.languageList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Santal Project";
            // 
            // projectName
            // 
            this.projectName.Location = new System.Drawing.Point(12, 166);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(438, 27);
            this.projectName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Language:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Project Name:";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(356, 424);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(94, 29);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // Gitselection
            // 
            this.Gitselection.AutoSize = true;
            this.Gitselection.Location = new System.Drawing.Point(17, 221);
            this.Gitselection.Name = "Gitselection";
            this.Gitselection.Size = new System.Drawing.Size(50, 24);
            this.Gitselection.TabIndex = 6;
            this.Gitselection.Text = "Git";
            this.Gitselection.UseVisualStyleBackColor = true;
            // 
            // FileOpen
            // 
            this.FileOpen.AutoSize = true;
            this.FileOpen.Location = new System.Drawing.Point(16, 255);
            this.FileOpen.Name = "FileOpen";
            this.FileOpen.Size = new System.Drawing.Size(94, 24);
            this.FileOpen.TabIndex = 7;
            this.FileOpen.Text = "Open File";
            this.FileOpen.UseVisualStyleBackColor = true;
            // 
            // OpenFolder
            // 
            this.OpenFolder.AutoSize = true;
            this.OpenFolder.Location = new System.Drawing.Point(17, 285);
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.Size = new System.Drawing.Size(113, 24);
            this.OpenFolder.TabIndex = 8;
            this.OpenFolder.Text = "Open Folder";
            this.OpenFolder.UseVisualStyleBackColor = true;
            // 
            // Add_Language
            // 
            this.Add_Language.Location = new System.Drawing.Point(230, 424);
            this.Add_Language.Name = "Add_Language";
            this.Add_Language.Size = new System.Drawing.Size(120, 29);
            this.Add_Language.TabIndex = 9;
            this.Add_Language.Text = "Add Language";
            this.Add_Language.UseVisualStyleBackColor = true;
            this.Add_Language.Click += new System.EventHandler(this.Add_Language_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 465);
            this.Controls.Add(this.Add_Language);
            this.Controls.Add(this.OpenFolder);
            this.Controls.Add(this.FileOpen);
            this.Controls.Add(this.Gitselection);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.languageList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox languageList;
        private Label label1;
        private TextBox projectName;
        private Label label2;
        private Label label3;
        private Button createButton;
        private CheckBox Gitselection;
        private CheckBox FileOpen;
        private CheckBox OpenFolder;
        private Button Add_Language;
    }
}