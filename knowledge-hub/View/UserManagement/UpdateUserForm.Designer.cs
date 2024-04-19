namespace knowledge_hub
{
    partial class UpdateUserForm
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
            labelPassword = new Label();
            labelUserType = new Label();
            labelName = new Label();
            groupBox1 = new GroupBox();
            comboBoxUserType = new ComboBox();
            textBoxPassword2 = new TextBox();
            labelPassword2 = new Label();
            textBoxUsername = new TextBox();
            labelUsername = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            textBoxContactDetails = new TextBox();
            labelContactDetails = new Label();
            textBoxName = new TextBox();
            textBoxPassword = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(28, 128);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(98, 25);
            labelPassword.TabIndex = 0;
            labelPassword.Text = "Password";
            // 
            // labelUserType
            // 
            labelUserType.AutoSize = true;
            labelUserType.Location = new Point(28, 305);
            labelUserType.Margin = new Padding(4, 0, 4, 0);
            labelUserType.Name = "labelUserType";
            labelUserType.Size = new Size(103, 25);
            labelUserType.TabIndex = 1;
            labelUserType.Text = "User Type";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(28, 390);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(64, 25);
            labelName.TabIndex = 2;
            labelName.Text = "Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxUserType);
            groupBox1.Controls.Add(textBoxPassword2);
            groupBox1.Controls.Add(labelPassword2);
            groupBox1.Controls.Add(textBoxUsername);
            groupBox1.Controls.Add(labelUsername);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(textBoxContactDetails);
            groupBox1.Controls.Add(labelContactDetails);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(labelPassword);
            groupBox1.Controls.Add(labelUserType);
            groupBox1.Controls.Add(labelName);
            groupBox1.Location = new Point(22, 26);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(566, 650);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Info";
            // 
            // comboBoxUserType
            // 
            comboBoxUserType.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxUserType.FormattingEnabled = true;
            comboBoxUserType.Items.AddRange(new object[] { "Librarian", "Patron" });
            comboBoxUserType.Location = new Point(28, 333);
            comboBoxUserType.Name = "comboBoxUserType";
            comboBoxUserType.Size = new Size(505, 39);
            comboBoxUserType.TabIndex = 3;
            // 
            // textBoxPassword2
            // 
            textBoxPassword2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword2.Location = new Point(28, 248);
            textBoxPassword2.Margin = new Padding(4);
            textBoxPassword2.Name = "textBoxPassword2";
            textBoxPassword2.Size = new Size(505, 38);
            textBoxPassword2.TabIndex = 2;
            textBoxPassword2.UseSystemPasswordChar = true;
            // 
            // labelPassword2
            // 
            labelPassword2.AutoSize = true;
            labelPassword2.Location = new Point(28, 219);
            labelPassword2.Margin = new Padding(4, 0, 4, 0);
            labelPassword2.Name = "labelPassword2";
            labelPassword2.Size = new Size(165, 25);
            labelPassword2.TabIndex = 11;
            labelPassword2.Text = "Repeat Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(28, 74);
            textBoxUsername.Margin = new Padding(4);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(505, 38);
            textBoxUsername.TabIndex = 0;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(24, 45);
            labelUsername.Margin = new Padding(4, 0, 4, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(102, 25);
            labelUsername.TabIndex = 10;
            labelUsername.Text = "Username";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(293, 576);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(156, 50);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(63, 576);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(156, 50);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // textBoxContactDetails
            // 
            textBoxContactDetails.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxContactDetails.Location = new Point(28, 512);
            textBoxContactDetails.Margin = new Padding(4);
            textBoxContactDetails.Name = "textBoxContactDetails";
            textBoxContactDetails.Size = new Size(505, 38);
            textBoxContactDetails.TabIndex = 5;
            // 
            // labelContactDetails
            // 
            labelContactDetails.AutoSize = true;
            labelContactDetails.Location = new Point(28, 483);
            labelContactDetails.Margin = new Padding(4, 0, 4, 0);
            labelContactDetails.Name = "labelContactDetails";
            labelContactDetails.Size = new Size(144, 25);
            labelContactDetails.TabIndex = 8;
            labelContactDetails.Text = "Contact Details";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(28, 419);
            textBoxName.Margin = new Padding(4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(505, 38);
            textBoxName.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(28, 157);
            textBoxPassword.Margin = new Padding(4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(505, 38);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // UpdateUserForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(622, 704);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "UpdateUserForm";
            Text = "Add User Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUserType;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private TextBox textBoxContactDetails;
        private Label labelContactDetails;
        private TextBox textBoxUsername;
        private Label labelUsername;
        private TextBox textBoxPassword2;
        private Label labelPassword2;
        private ComboBox comboBoxUserType;
    }
}