namespace knowledge_hub
{
    partial class UpdateBookForm
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
            labelTitle = new Label();
            labelAuthor = new Label();
            labelPublisher = new Label();
            groupBox1 = new GroupBox();
            textBoxISBN = new TextBox();
            labelISBN = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            textBoxYearPublished = new TextBox();
            labelYearPublished = new Label();
            textBoxPublisher = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxTitle = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(28, 128);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(49, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new Point(28, 208);
            labelAuthor.Margin = new Padding(4, 0, 4, 0);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(70, 25);
            labelAuthor.TabIndex = 1;
            labelAuthor.Text = "Author";
            // 
            // labelPublisher
            // 
            labelPublisher.AutoSize = true;
            labelPublisher.Location = new Point(28, 291);
            labelPublisher.Margin = new Padding(4, 0, 4, 0);
            labelPublisher.Name = "labelPublisher";
            labelPublisher.Size = new Size(93, 25);
            labelPublisher.TabIndex = 2;
            labelPublisher.Text = "Publisher";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxISBN);
            groupBox1.Controls.Add(labelISBN);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(textBoxYearPublished);
            groupBox1.Controls.Add(labelYearPublished);
            groupBox1.Controls.Add(textBoxPublisher);
            groupBox1.Controls.Add(textBoxAuthor);
            groupBox1.Controls.Add(textBoxTitle);
            groupBox1.Controls.Add(labelTitle);
            groupBox1.Controls.Add(labelAuthor);
            groupBox1.Controls.Add(labelPublisher);
            groupBox1.Location = new Point(22, 26);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(572, 582);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Info";
            // 
            // textBoxISBN
            // 
            textBoxISBN.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxISBN.Location = new Point(28, 74);
            textBoxISBN.Margin = new Padding(4);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(505, 38);
            textBoxISBN.TabIndex = 0;
            // 
            // labelISBN
            // 
            labelISBN.AutoSize = true;
            labelISBN.Location = new Point(24, 45);
            labelISBN.Margin = new Padding(4, 0, 4, 0);
            labelISBN.Name = "labelISBN";
            labelISBN.Size = new Size(58, 25);
            labelISBN.TabIndex = 10;
            labelISBN.Text = "ISBN";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(332, 479);
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
            btnSave.Location = new Point(68, 479);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(156, 50);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // textBoxYearPublished
            // 
            textBoxYearPublished.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxYearPublished.Location = new Point(28, 400);
            textBoxYearPublished.Margin = new Padding(4);
            textBoxYearPublished.Name = "textBoxYearPublished";
            textBoxYearPublished.Size = new Size(505, 38);
            textBoxYearPublished.TabIndex = 4;
            // 
            // labelYearPublished
            // 
            labelYearPublished.AutoSize = true;
            labelYearPublished.Location = new Point(28, 371);
            labelYearPublished.Margin = new Padding(4, 0, 4, 0);
            labelYearPublished.Name = "labelYearPublished";
            labelYearPublished.Size = new Size(144, 25);
            labelYearPublished.TabIndex = 8;
            labelYearPublished.Text = "Year Published";
            // 
            // textBoxPublisher
            // 
            textBoxPublisher.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPublisher.Location = new Point(28, 320);
            textBoxPublisher.Margin = new Padding(4);
            textBoxPublisher.Name = "textBoxPublisher";
            textBoxPublisher.Size = new Size(505, 38);
            textBoxPublisher.TabIndex = 3;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAuthor.Location = new Point(28, 237);
            textBoxAuthor.Margin = new Padding(4);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(505, 38);
            textBoxAuthor.TabIndex = 2;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTitle.Location = new Point(28, 157);
            textBoxTitle.Margin = new Padding(4);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(505, 38);
            textBoxTitle.TabIndex = 1;
            // 
            // UpdateBookForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(625, 633);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "UpdateBookForm";
            Text = "Update Book Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private TextBox textBoxYearPublished;
        private Label labelYearPublished;
        private TextBox textBoxISBN;
        private Label labelISBN;
    }
}