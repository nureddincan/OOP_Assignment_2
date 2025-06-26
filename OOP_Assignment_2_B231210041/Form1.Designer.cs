namespace OOP_Assignment_2_B231210041
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
            yukleButton = new Button();
            baslatButton = new Button();
            cikisButton = new Button();
            sozlukGroupBox = new GroupBox();
            sozlukComboBox = new ComboBox();
            sozlukGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // yukleButton
            // 
            yukleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            yukleButton.Location = new Point(275, 107);
            yukleButton.Name = "yukleButton";
            yukleButton.Size = new Size(94, 29);
            yukleButton.TabIndex = 0;
            yukleButton.Text = "Yükle";
            yukleButton.UseVisualStyleBackColor = true;
            yukleButton.Click += yukleButton_Click;
            // 
            // baslatButton
            // 
            baslatButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            baslatButton.Location = new Point(375, 107);
            baslatButton.Name = "baslatButton";
            baslatButton.Size = new Size(94, 29);
            baslatButton.TabIndex = 1;
            baslatButton.Text = "Başlat";
            baslatButton.UseVisualStyleBackColor = true;
            baslatButton.Click += baslatButton_Click;
            // 
            // cikisButton
            // 
            cikisButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cikisButton.Location = new Point(475, 107);
            cikisButton.Name = "cikisButton";
            cikisButton.Size = new Size(94, 29);
            cikisButton.TabIndex = 2;
            cikisButton.Text = "Çıkış";
            cikisButton.UseVisualStyleBackColor = true;
            cikisButton.Click += cikisButton_Click;
            // 
            // sozlukGroupBox
            // 
            sozlukGroupBox.Controls.Add(sozlukComboBox);
            sozlukGroupBox.Location = new Point(12, 12);
            sozlukGroupBox.Name = "sozlukGroupBox";
            sozlukGroupBox.Size = new Size(557, 79);
            sozlukGroupBox.TabIndex = 3;
            sozlukGroupBox.TabStop = false;
            sozlukGroupBox.Text = "Sözlük";
            // 
            // sozlukComboBox
            // 
            sozlukComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sozlukComboBox.FormattingEnabled = true;
            sozlukComboBox.Location = new Point(6, 32);
            sozlukComboBox.Name = "sozlukComboBox";
            sozlukComboBox.Size = new Size(545, 28);
            sozlukComboBox.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 147);
            Controls.Add(sozlukGroupBox);
            Controls.Add(cikisButton);
            Controls.Add(baslatButton);
            Controls.Add(yukleButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelime Ezber";
            Load += Form1_Load;
            sozlukGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button yukleButton;
        private Button baslatButton;
        private Button cikisButton;
        private GroupBox sozlukGroupBox;
        private ComboBox sozlukComboBox;
    }
}
