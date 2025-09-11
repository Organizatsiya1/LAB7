namespace Lab_7
{
    partial class Registration
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
            PasswordLabel = new Label();
            LoginLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            StatusBox = new ComboBox();
            PhoneBox = new MaskedTextBox();
            NameBox = new TextBox();
            RegistrationButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            PasswordLabel.ForeColor = SystemColors.ControlLightLight;
            PasswordLabel.Location = new Point(217, 231);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(0, 38);
            PasswordLabel.TabIndex = 25;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            LoginLabel.ForeColor = SystemColors.ControlLightLight;
            LoginLabel.Location = new Point(217, 183);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(0, 38);
            LoginLabel.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(12, 228);
            label5.Name = "label5";
            label5.Size = new Size(189, 38);
            label5.TabIndex = 23;
            label5.Text = "Ваш пароль:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(14, 180);
            label4.Name = "label4";
            label4.Size = new Size(170, 38);
            label4.TabIndex = 22;
            label4.Text = "Ваш логин:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(205, 111);
            label3.Name = "label3";
            label3.Size = new Size(134, 38);
            label3.TabIndex = 21;
            label3.Text = "Телефон";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(205, 59);
            label2.Name = "label2";
            label2.Size = new Size(77, 38);
            label2.TabIndex = 20;
            label2.Text = "Имя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(205, 12);
            label1.Name = "label1";
            label1.Size = new Size(173, 38);
            label1.TabIndex = 19;
            label1.Text = "Должность";
            // 
            // StatusBox
            // 
            StatusBox.FormattingEnabled = true;
            StatusBox.Location = new Point(418, 22);
            StatusBox.Name = "StatusBox";
            StatusBox.Size = new Size(184, 28);
            StatusBox.TabIndex = 18;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(418, 122);
            PhoneBox.Mask = "(999) 000-0000";
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(184, 27);
            PhoneBox.TabIndex = 17;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(418, 70);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(184, 27);
            NameBox.TabIndex = 16;
            // 
            // RegistrationButton
            // 
            RegistrationButton.Location = new Point(418, 193);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(149, 38);
            RegistrationButton.TabIndex = 15;
            RegistrationButton.Text = "Зарегистрировать";
            RegistrationButton.UseVisualStyleBackColor = true;
            RegistrationButton.Click += registrationButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.menu_restaurant_coffee_icon_210208;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(99, 58, 52);
            ClientSize = new Size(615, 278);
            Controls.Add(pictureBox1);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(StatusBox);
            Controls.Add(PhoneBox);
            Controls.Add(NameBox);
            Controls.Add(RegistrationButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.MaskedTextBox PhoneBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button RegistrationButton;
        private PictureBox pictureBox1;
    }
}