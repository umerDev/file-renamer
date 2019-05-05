namespace file_renamer
{
    partial class FileRenamer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FilePathsList = new System.Windows.Forms.ListBox();
            this.CurrentFileLbl = new System.Windows.Forms.Label();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.NewNameInput = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.EnterNameLbl = new System.Windows.Forms.Label();
            this.RenameBtn = new System.Windows.Forms.Button();
            this.CounterInput = new System.Windows.Forms.Label();
            this.CInput = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FilePathsList);
            this.panel1.Controls.Add(this.CurrentFileLbl);
            this.panel1.Controls.Add(this.OpenBtn);
            this.panel1.Location = new System.Drawing.Point(54, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 100);
            this.panel1.TabIndex = 0;
            // 
            // FilePathsList
            // 
            this.FilePathsList.FormattingEnabled = true;
            this.FilePathsList.Location = new System.Drawing.Point(6, 2);
            this.FilePathsList.Name = "FilePathsList";
            this.FilePathsList.Size = new System.Drawing.Size(451, 95);
            this.FilePathsList.Sorted = true;
            this.FilePathsList.TabIndex = 1;
            // 
            // CurrentFileLbl
            // 
            this.CurrentFileLbl.AutoSize = true;
            this.CurrentFileLbl.Location = new System.Drawing.Point(460, 27);
            this.CurrentFileLbl.Name = "CurrentFileLbl";
            this.CurrentFileLbl.Size = new System.Drawing.Size(91, 13);
            this.CurrentFileLbl.TabIndex = 5;
            this.CurrentFileLbl.Text = "Directory to open:";
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(463, 43);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenBtn.TabIndex = 3;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // NewNameInput
            // 
            this.NewNameInput.Location = new System.Drawing.Point(109, 3);
            this.NewNameInput.Name = "NewNameInput";
            this.NewNameInput.Size = new System.Drawing.Size(231, 30);
            this.NewNameInput.TabIndex = 1;
            this.NewNameInput.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.EnterNameLbl);
            this.flowLayoutPanel1.Controls.Add(this.NewNameInput);
            this.flowLayoutPanel1.Controls.Add(this.RenameBtn);
            this.flowLayoutPanel1.Controls.Add(this.CounterInput);
            this.flowLayoutPanel1.Controls.Add(this.CInput);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(54, 224);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(457, 100);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // EnterNameLbl
            // 
            this.EnterNameLbl.AutoSize = true;
            this.EnterNameLbl.Location = new System.Drawing.Point(3, 0);
            this.EnterNameLbl.Name = "EnterNameLbl";
            this.EnterNameLbl.Size = new System.Drawing.Size(100, 13);
            this.EnterNameLbl.TabIndex = 4;
            this.EnterNameLbl.Text = "Naming Convention";
            // 
            // RenameBtn
            // 
            this.RenameBtn.Location = new System.Drawing.Point(346, 3);
            this.RenameBtn.Name = "RenameBtn";
            this.RenameBtn.Size = new System.Drawing.Size(75, 23);
            this.RenameBtn.TabIndex = 6;
            this.RenameBtn.Text = "Rename";
            this.RenameBtn.UseVisualStyleBackColor = true;
            this.RenameBtn.Click += new System.EventHandler(this.RenameBtn_Click);
            // 
            // CounterInput
            // 
            this.CounterInput.AutoSize = true;
            this.CounterInput.Location = new System.Drawing.Point(3, 36);
            this.CounterInput.Name = "CounterInput";
            this.CounterInput.Size = new System.Drawing.Size(50, 13);
            this.CounterInput.TabIndex = 8;
            this.CounterInput.Text = "Counter: ";
            // 
            // CInput
            // 
            this.CInput.Location = new System.Drawing.Point(59, 39);
            this.CInput.Name = "CInput";
            this.CInput.Size = new System.Drawing.Size(61, 30);
            this.CInput.TabIndex = 7;
            this.CInput.Text = "1";
            // 
            // FileRenamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "FileRenamer";
            this.Text = "File Renamer";
            this.Load += new System.EventHandler(this.FileRenamer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox NewNameInput;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label EnterNameLbl;
        private System.Windows.Forms.Label CurrentFileLbl;
        private System.Windows.Forms.ListBox FilePathsList;
        private System.Windows.Forms.Button RenameBtn;
        private System.Windows.Forms.Label CounterInput;
        private System.Windows.Forms.RichTextBox CInput;
    }
}

