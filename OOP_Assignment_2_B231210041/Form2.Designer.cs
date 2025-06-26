namespace OOP_Assignment_2_B231210041
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            option1Button = new Button();
            option2Button = new Button();
            option3Button = new Button();
            option4Button = new Button();
            progressLabel = new Label();
            panel1 = new Panel();
            scoreLabel = new Label();
            wordLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // option1Button
            // 
            option1Button.BackColor = SystemColors.ButtonFace;
            option1Button.Location = new Point(12, 208);
            option1Button.Name = "option1Button";
            option1Button.Size = new Size(368, 106);
            option1Button.TabIndex = 0;
            option1Button.Text = "button1";
            option1Button.UseVisualStyleBackColor = false;
            option1Button.Click += Secenek_Click;
            // 
            // option2Button
            // 
            option2Button.BackColor = SystemColors.ButtonFace;
            option2Button.Location = new Point(395, 208);
            option2Button.Name = "option2Button";
            option2Button.Size = new Size(368, 106);
            option2Button.TabIndex = 1;
            option2Button.Text = "button2";
            option2Button.UseVisualStyleBackColor = false;
            option2Button.Click += Secenek_Click;
            // 
            // option3Button
            // 
            option3Button.BackColor = SystemColors.ButtonFace;
            option3Button.Location = new Point(12, 331);
            option3Button.Name = "option3Button";
            option3Button.Size = new Size(368, 106);
            option3Button.TabIndex = 3;
            option3Button.Text = "button3";
            option3Button.UseVisualStyleBackColor = false;
            option3Button.Click += Secenek_Click;
            // 
            // option4Button
            // 
            option4Button.BackColor = SystemColors.ButtonFace;
            option4Button.Location = new Point(395, 331);
            option4Button.Name = "option4Button";
            option4Button.Size = new Size(368, 106);
            option4Button.TabIndex = 2;
            option4Button.Text = "button4";
            option4Button.UseVisualStyleBackColor = false;
            option4Button.Click += Secenek_Click;
            // 
            // progressLabel
            // 
            progressLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            progressLabel.ForeColor = Color.White;
            progressLabel.Location = new Point(12, 11);
            progressLabel.Name = "progressLabel";
            progressLabel.Size = new Size(140, 60);
            progressLabel.TabIndex = 4;
            progressLabel.Text = "1/999";
            progressLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(scoreLabel);
            panel1.Controls.Add(progressLabel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(751, 83);
            panel1.TabIndex = 5;
            // 
            // scoreLabel
            // 
            scoreLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            scoreLabel.ForeColor = Color.White;
            scoreLabel.Location = new Point(597, 11);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(140, 60);
            scoreLabel.TabIndex = 6;
            scoreLabel.Text = "0";
            scoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wordLabel
            // 
            wordLabel.BackColor = Color.LightSkyBlue;
            wordLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            wordLabel.ForeColor = Color.White;
            wordLabel.Location = new Point(12, 109);
            wordLabel.Name = "wordLabel";
            wordLabel.Size = new Size(751, 82);
            wordLabel.TabIndex = 7;
            wordLabel.Text = "Word";
            wordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 453);
            Controls.Add(wordLabel);
            Controls.Add(panel1);
            Controls.Add(option3Button);
            Controls.Add(option4Button);
            Controls.Add(option2Button);
            Controls.Add(option1Button);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Çoktan Seçmeli Sorular";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button option1Button;
        private Button option2Button;
        private Button option3Button;
        private Button option4Button;
        private Label progressLabel;
        private Panel panel1;
        private Label scoreLabel;
        private Label wordLabel;
    }
}