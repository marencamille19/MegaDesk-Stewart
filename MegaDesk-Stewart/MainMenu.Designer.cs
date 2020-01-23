namespace MegaDesk_Stewart
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.BtnAddNewForm = new System.Windows.Forms.Button();
            this.BtnViewQuotes = new System.Windows.Forms.Button();
            this.BtnSearchQuotes = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAddNewForm
            // 
            this.BtnAddNewForm.Location = new System.Drawing.Point(38, 38);
            this.BtnAddNewForm.Name = "BtnAddNewForm";
            this.BtnAddNewForm.Size = new System.Drawing.Size(258, 90);
            this.BtnAddNewForm.TabIndex = 0;
            this.BtnAddNewForm.Text = "Add New Quote";
            this.BtnAddNewForm.UseVisualStyleBackColor = true;
            this.BtnAddNewForm.Click += new System.EventHandler(this.BtnAddNewForm_Click);
            // 
            // BtnViewQuotes
            // 
            this.BtnViewQuotes.Location = new System.Drawing.Point(38, 134);
            this.BtnViewQuotes.Name = "BtnViewQuotes";
            this.BtnViewQuotes.Size = new System.Drawing.Size(258, 90);
            this.BtnViewQuotes.TabIndex = 1;
            this.BtnViewQuotes.Text = "View Quotes";
            this.BtnViewQuotes.UseVisualStyleBackColor = true;
            // 
            // BtnSearchQuotes
            // 
            this.BtnSearchQuotes.Location = new System.Drawing.Point(38, 230);
            this.BtnSearchQuotes.Name = "BtnSearchQuotes";
            this.BtnSearchQuotes.Size = new System.Drawing.Size(258, 90);
            this.BtnSearchQuotes.TabIndex = 2;
            this.BtnSearchQuotes.Text = "Search Quotes";
            this.BtnSearchQuotes.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(38, 326);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(258, 90);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(336, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 155);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSearchQuotes);
            this.Controls.Add(this.BtnViewQuotes);
            this.Controls.Add(this.BtnAddNewForm);
            this.Name = "MainMenu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddNewForm;
        private System.Windows.Forms.Button BtnViewQuotes;
        private System.Windows.Forms.Button BtnSearchQuotes;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

