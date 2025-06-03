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
            RegistrationButton = new Button();
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
            SuspendLayout();
            // 
            // RegistrationButton
            // 
            RegistrationButton.Location = new Point(98, 164);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(149, 23);
            RegistrationButton.TabIndex = 0;
            RegistrationButton.Text = "Зарегистрировать";
            RegistrationButton.UseVisualStyleBackColor = true;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(98, 69);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(149, 23);
            NameBox.TabIndex = 1;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(98, 117);
            PhoneBox.Mask = "(999) 000-0000";
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(149, 23);
            PhoneBox.TabIndex = 2;
            // 
            // StatusBox
            // 
            StatusBox.FormattingEnabled = true;
            StatusBox.Location = new Point(98, 21);
            StatusBox.Name = "StatusBox";
            StatusBox.Size = new Size(149, 23);
            StatusBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 4;
            label1.Text = "Должность";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 72);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 5;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 120);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "Телефон";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 204);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 7;
            label4.Text = "Ваш логин";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 253);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 8;
            label5.Text = "Ваш пароль";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(98, 204);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(0, 15);
            LoginLabel.TabIndex = 9;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(98, 253);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(0, 15);
            PasswordLabel.TabIndex = 10;
            // 
            // Registration
            // 
            ClientSize = new Size(291, 323);
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
            Name = "Registration";
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
        private TextBox NameBox;

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string phnumber = PhoneBox.Text;
            UserStatus status = (UserStatus)StatusBox.SelectedValue;
            
        }
    }
}
