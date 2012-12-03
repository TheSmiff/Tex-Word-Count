namespace TeX_Word_Count
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
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SubTitleLabel = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.Words = new System.Windows.Forms.Label();
            this.Diagnostic = new System.Windows.Forms.CheckBox();
            this.DiagnosticPane = new System.Windows.Forms.ListBox();
            this.WriteDiagnostics = new System.Windows.Forms.CheckBox();
            this.Record = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(524, 55);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Tom\'s TeX Word Count";
            // 
            // SubTitleLabel
            // 
            this.SubTitleLabel.AutoSize = true;
            this.SubTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTitleLabel.Location = new System.Drawing.Point(58, 64);
            this.SubTitleLabel.Name = "SubTitleLabel";
            this.SubTitleLabel.Size = new System.Drawing.Size(435, 25);
            this.SubTitleLabel.TabIndex = 1;
            this.SubTitleLabel.Text = "Simple utility to count the words in a TeX file";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(418, 110);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 2;
            this.Open.Text = "Open File";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // FileName
            // 
            this.FileName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName.Location = new System.Drawing.Point(75, 110);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(337, 26);
            this.FileName.TabIndex = 3;
            this.FileName.Text = "Write file trail here or click Open File";
            // 
            // RunButton
            // 
            this.RunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunButton.Location = new System.Drawing.Point(191, 152);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(163, 76);
            this.RunButton.TabIndex = 4;
            this.RunButton.Text = "Count My Words";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // Words
            // 
            this.Words.AutoSize = true;
            this.Words.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Words.Location = new System.Drawing.Point(163, 231);
            this.Words.Name = "Words";
            this.Words.Size = new System.Drawing.Size(217, 73);
            this.Words.TabIndex = 5;
            this.Words.Text = "Words";
            this.Words.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Words.Visible = false;
            // 
            // Diagnostic
            // 
            this.Diagnostic.AutoSize = true;
            this.Diagnostic.Location = new System.Drawing.Point(418, 152);
            this.Diagnostic.Name = "Diagnostic";
            this.Diagnostic.Size = new System.Drawing.Size(111, 17);
            this.Diagnostic.TabIndex = 6;
            this.Diagnostic.Text = "Show Diagnostics";
            this.Diagnostic.UseVisualStyleBackColor = true;
            this.Diagnostic.CheckedChanged += new System.EventHandler(this.Diagnostic_CheckedChanged);
            // 
            // DiagnosticPane
            // 
            this.DiagnosticPane.FormattingEnabled = true;
            this.DiagnosticPane.Location = new System.Drawing.Point(22, 307);
            this.DiagnosticPane.Name = "DiagnosticPane";
            this.DiagnosticPane.Size = new System.Drawing.Size(488, 173);
            this.DiagnosticPane.TabIndex = 9;
            this.DiagnosticPane.Visible = false;
            // 
            // WriteDiagnostics
            // 
            this.WriteDiagnostics.AutoSize = true;
            this.WriteDiagnostics.Location = new System.Drawing.Point(418, 205);
            this.WriteDiagnostics.Name = "WriteDiagnostics";
            this.WriteDiagnostics.Size = new System.Drawing.Size(125, 17);
            this.WriteDiagnostics.TabIndex = 11;
            this.WriteDiagnostics.Text = "Include Diagnostics?";
            this.WriteDiagnostics.UseVisualStyleBackColor = true;
            // 
            // Record
            // 
            this.Record.AutoSize = true;
            this.Record.Checked = true;
            this.Record.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Record.Location = new System.Drawing.Point(418, 176);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(99, 17);
            this.Record.TabIndex = 12;
            this.Record.Text = "Update Record";
            this.Record.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 491);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.WriteDiagnostics);
            this.Controls.Add(this.DiagnosticPane);
            this.Controls.Add(this.Diagnostic);
            this.Controls.Add(this.Words);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.SubTitleLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SubTitleLabel;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Label Words;
        private System.Windows.Forms.CheckBox Diagnostic;
        private System.Windows.Forms.ListBox DiagnosticPane;
        private System.Windows.Forms.CheckBox WriteDiagnostics;
        private System.Windows.Forms.CheckBox Record;
    }
}

