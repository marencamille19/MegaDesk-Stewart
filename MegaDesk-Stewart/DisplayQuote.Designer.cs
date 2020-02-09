namespace MegaDesk_Stewart
{
    partial class DisplayQuote
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
            this.label1 = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.displayWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.displayDepth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.displayDrawers = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.displayMaterials = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.displayRushOrder = new System.Windows.Forms.ComboBox();
            this.btnAddQuote = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.displayTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.displayWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name:";
            // 
            // customerName
            // 
            this.customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.Location = new System.Drawing.Point(373, 66);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(222, 36);
            this.customerName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width (Inches):";
            // 
            // displayWidth
            // 
            this.displayWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayWidth.Location = new System.Drawing.Point(373, 108);
            this.displayWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.displayWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.displayWidth.Name = "displayWidth";
            this.displayWidth.Size = new System.Drawing.Size(222, 36);
            this.displayWidth.TabIndex = 4;
            this.displayWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.displayWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Depth (Inches): ";
            // 
            // displayDepth
            // 
            this.displayDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayDepth.Location = new System.Drawing.Point(373, 150);
            this.displayDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.displayDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.displayDepth.Name = "displayDepth";
            this.displayDepth.Size = new System.Drawing.Size(222, 36);
            this.displayDepth.TabIndex = 6;
            this.displayDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.displayDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Drawers:";
            // 
            // displayDrawers
            // 
            this.displayDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayDrawers.Location = new System.Drawing.Point(373, 192);
            this.displayDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.displayDrawers.Name = "displayDrawers";
            this.displayDrawers.Size = new System.Drawing.Size(222, 36);
            this.displayDrawers.TabIndex = 9;
            this.displayDrawers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(113, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Desktop Material:";
            // 
            // displayMaterials
            // 
            this.displayMaterials.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.displayMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayMaterials.FormattingEnabled = true;
            this.displayMaterials.Items.AddRange(new object[] {
            "laminate",
            "oak",
            "pine",
            "rosewood",
            "veneer"});
            this.displayMaterials.Location = new System.Drawing.Point(375, 234);
            this.displayMaterials.MaxDropDownItems = 5;
            this.displayMaterials.Name = "displayMaterials";
            this.displayMaterials.Size = new System.Drawing.Size(222, 37);
            this.displayMaterials.Sorted = true;
            this.displayMaterials.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Shipping Options:";
            // 
            // displayRushOrder
            // 
            this.displayRushOrder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.displayRushOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayRushOrder.FormattingEnabled = true;
            this.displayRushOrder.Items.AddRange(new object[] {
            "14-day shipping",
            "3-day shipping (fee)",
            "5-day shipping (fee)",
            "7-day shipping (fee)"});
            this.displayRushOrder.Location = new System.Drawing.Point(375, 277);
            this.displayRushOrder.MaxDropDownItems = 5;
            this.displayRushOrder.Name = "displayRushOrder";
            this.displayRushOrder.Size = new System.Drawing.Size(222, 37);
            this.displayRushOrder.Sorted = true;
            this.displayRushOrder.TabIndex = 13;
            // 
            // btnAddQuote
            // 
            this.btnAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuote.Location = new System.Drawing.Point(114, 320);
            this.btnAddQuote.Name = "btnAddQuote";
            this.btnAddQuote.Size = new System.Drawing.Size(483, 54);
            this.btnAddQuote.TabIndex = 14;
            this.btnAddQuote.Text = "Calculate Quote";
            this.btnAddQuote.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(109, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total:";
            // 
            // displayTotal
            // 
            this.displayTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTotal.Location = new System.Drawing.Point(373, 377);
            this.displayTotal.Name = "displayTotal";
            this.displayTotal.ReadOnly = true;
            this.displayTotal.Size = new System.Drawing.Size(224, 36);
            this.displayTotal.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(626, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.displayTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddQuote);
            this.Controls.Add(this.displayRushOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.displayMaterials);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.displayDrawers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.displayDepth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.displayWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.label1);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.exitDisplayQuote_Click);
            ((System.ComponentModel.ISupportInitialize)(this.displayWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayDrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown displayWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown displayDepth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown displayDrawers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox displayMaterials;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox displayRushOrder;
        private System.Windows.Forms.Button btnAddQuote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox displayTotal;
        private System.Windows.Forms.Button button1;
    }
}