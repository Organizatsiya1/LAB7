using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        //public BusinessLogic.BusinessLogic Logic = LoginForm.Logic КАК ПРИВЯЗАТЬ ЛОГИКУ

        private void InitializeComponent()
        {
            NameBox = new TextBox();
            PhoneBox = new MaskedTextBox();
            StatusBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            RegistrationButton = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // NameBox
            // 
            NameBox.Location = new Point(347, 64);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(203, 27);
            NameBox.TabIndex = 1;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(347, 107);
            PhoneBox.Mask = "(999) 000-0000";
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(96, 27);
            PhoneBox.TabIndex = 2;
            // 
            // StatusBox
            // 
            StatusBox.FormattingEnabled = true;
            StatusBox.Location = new Point(347, 19);
            StatusBox.Name = "StatusBox";
            StatusBox.Size = new Size(203, 28);
            StatusBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(212, 19);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 4;
            label1.Text = "Должность";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(212, 63);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 5;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(212, 109);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 6;
            label3.Text = "Телефон";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(212, 175);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 7;
            label4.Text = "Ваш логин";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(212, 214);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 8;
            label5.Text = "Ваш пароль";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            LoginLabel.ForeColor = SystemColors.ControlLightLight;
            LoginLabel.Location = new Point(346, 179);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(0, 25);
            LoginLabel.TabIndex = 9;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            PasswordLabel.ForeColor = SystemColors.ControlLightLight;
            PasswordLabel.Location = new Point(346, 214);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(0, 25);
            PasswordLabel.TabIndex = 10;
            // 
            // RegistrationButton
            // 
            RegistrationButton.BackColor = Color.FromArgb(99, 58, 52);
            RegistrationButton.Cursor = Cursors.Hand;
            RegistrationButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RegistrationButton.ForeColor = SystemColors.ControlLightLight;
            RegistrationButton.Location = new Point(12, 194);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(172, 33);
            RegistrationButton.TabIndex = 12;
            RegistrationButton.Text = "Регистрация";
            RegistrationButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.menu_restaurant_coffee_icon_210208;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(RegistrationButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 264);
            panel1.TabIndex = 13;
            // 
            // Registration
            // 
            AutoSize = true;
            BackColor = Color.FromArgb(99, 58, 52);
            ClientSize = new Size(568, 264);
            Controls.Add(panel1);
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            ((ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Button RegistrationButton;
        private MaskedTextBox PhoneBox;
        private ComboBox StatusBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label LoginLabel;
        private Label PasswordLabel;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox NameBox;

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string phnumber = PhoneBox.Text;
            Model.UserStatus status = (Model.UserStatus)StatusBox.SelectedValue;

        }

    }
}
