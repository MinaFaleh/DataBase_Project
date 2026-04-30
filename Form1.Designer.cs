namespace AirlinePhase2
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
            btnAddPassenger = new Button();
            btnDeletePassenger = new Button();
            txtNationalId = new TextBox();
            txtPassport = new TextBox();
            txtNationality = new TextBox();
            txtGender = new TextBox();
            txtPhone = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnAddPassenger
            // 
            btnAddPassenger.Location = new Point(363, 691);
            btnAddPassenger.Name = "btnAddPassenger";
            btnAddPassenger.Size = new Size(240, 51);
            btnAddPassenger.TabIndex = 0;
            btnAddPassenger.Text = "Add Passenger";
            btnAddPassenger.UseVisualStyleBackColor = true;
            btnAddPassenger.Click += button1_Click;
            // 
            // btnDeletePassenger
            // 
            btnDeletePassenger.Location = new Point(1023, 691);
            btnDeletePassenger.Name = "btnDeletePassenger";
            btnDeletePassenger.Size = new Size(239, 51);
            btnDeletePassenger.TabIndex = 1;
            btnDeletePassenger.Text = "Delete Passenger";
            btnDeletePassenger.UseVisualStyleBackColor = true;
            btnDeletePassenger.Click += btnDeletePassenger_Click;
            // 
            // txtNationalId
            // 
            txtNationalId.Location = new Point(78, 45);
            txtNationalId.Name = "txtNationalId";
            txtNationalId.Size = new Size(150, 31);
            txtNationalId.TabIndex = 2;
            txtNationalId.TextChanged += txtNationalId_TextChanged;
            // 
            // txtPassport
            // 
            txtPassport.Location = new Point(78, 153);
            txtPassport.Name = "txtPassport";
            txtPassport.Size = new Size(150, 31);
            txtPassport.TabIndex = 2;
            // 
            // txtNationality
            // 
            txtNationality.Location = new Point(78, 247);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(150, 31);
            txtNationality.TabIndex = 2;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(78, 348);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(150, 31);
            txtGender.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(501, 247);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 31);
            txtPhone.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(501, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(501, 153);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 17);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 3;
            label1.Text = "National ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 125);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 3;
            label2.Text = "Passport No";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 219);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 3;
            label3.Text = "Nationality";
            label3.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 320);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            label4.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(549, 17);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 3;
            label5.Text = "Name";
            label5.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(549, 125);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 3;
            label6.Text = "Email";
            label6.Click += label2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(549, 219);
            label7.Name = "label7";
            label7.Size = new Size(62, 25);
            label7.TabIndex = 3;
            label7.Text = "Phone";
            label7.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1589, 793);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtPhone);
            Controls.Add(txtGender);
            Controls.Add(txtNationality);
            Controls.Add(txtPassport);
            Controls.Add(txtNationalId);
            Controls.Add(btnDeletePassenger);
            Controls.Add(btnAddPassenger);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddPassenger;
        private Button btnDeletePassenger;
        private TextBox txtNationalId;
        private TextBox txtPassport;
        private TextBox txtNationality;
        private TextBox txtGender;
        private TextBox txtPhone;
        private TextBox txtName;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
