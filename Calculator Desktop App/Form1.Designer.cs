namespace Calculator_Desktop_App
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtPercent = new System.Windows.Forms.Button();
            this.BtClear = new System.Windows.Forms.Button();
            this.BtMode = new System.Windows.Forms.Button();
            this.BtPlus = new System.Windows.Forms.Button();
            this.BtMinus = new System.Windows.Forms.Button();
            this.BtMultiplic = new System.Windows.Forms.Button();
            this.BtDecimal = new System.Windows.Forms.Button();
            this.BtResult = new System.Windows.Forms.Button();
            this.BtMinOrPlus = new System.Windows.Forms.Button();
            this.BtNum7 = new System.Windows.Forms.Button();
            this.Bt8 = new System.Windows.Forms.Button();
            this.Bt9 = new System.Windows.Forms.Button();
            this.Bt4 = new System.Windows.Forms.Button();
            this.Bt5 = new System.Windows.Forms.Button();
            this.Bt6 = new System.Windows.Forms.Button();
            this.Bt1 = new System.Windows.Forms.Button();
            this.Bt2 = new System.Windows.Forms.Button();
            this.Bt3 = new System.Windows.Forms.Button();
            this.BtZero = new System.Windows.Forms.Button();
            this.BtDote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOperation = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(2, 72);
            this.richTextBox1.MaxLength = 15;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(364, 82);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // BtPercent
            // 
            this.BtPercent.BackColor = System.Drawing.Color.DarkGray;
            this.BtPercent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtPercent.Location = new System.Drawing.Point(188, 162);
            this.BtPercent.Name = "BtPercent";
            this.BtPercent.Size = new System.Drawing.Size(82, 56);
            this.BtPercent.TabIndex = 1;
            this.BtPercent.Text = "%";
            this.BtPercent.UseVisualStyleBackColor = false;
            this.BtPercent.Click += new System.EventHandler(this.BtPercent_Click);
            // 
            // BtClear
            // 
            this.BtClear.BackColor = System.Drawing.Color.DarkGray;
            this.BtClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtClear.Location = new System.Drawing.Point(12, 161);
            this.BtClear.Name = "BtClear";
            this.BtClear.Size = new System.Drawing.Size(82, 56);
            this.BtClear.TabIndex = 2;
            this.BtClear.Text = "C";
            this.BtClear.UseVisualStyleBackColor = false;
            this.BtClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // BtMode
            // 
            this.BtMode.BackColor = System.Drawing.Color.DarkOrange;
            this.BtMode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtMode.Location = new System.Drawing.Point(276, 160);
            this.BtMode.Name = "BtMode";
            this.BtMode.Size = new System.Drawing.Size(82, 56);
            this.BtMode.TabIndex = 3;
            this.BtMode.Text = "Mode";
            this.BtMode.UseVisualStyleBackColor = false;
            this.BtMode.Click += new System.EventHandler(this.BtMode_Click);
            // 
            // BtPlus
            // 
            this.BtPlus.BackColor = System.Drawing.Color.DarkOrange;
            this.BtPlus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtPlus.Location = new System.Drawing.Point(276, 223);
            this.BtPlus.Name = "BtPlus";
            this.BtPlus.Size = new System.Drawing.Size(82, 56);
            this.BtPlus.TabIndex = 5;
            this.BtPlus.Text = "+";
            this.BtPlus.UseVisualStyleBackColor = false;
            this.BtPlus.Click += new System.EventHandler(this.BtPlus_Click);
            // 
            // BtMinus
            // 
            this.BtMinus.BackColor = System.Drawing.Color.DarkOrange;
            this.BtMinus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtMinus.Location = new System.Drawing.Point(276, 285);
            this.BtMinus.Name = "BtMinus";
            this.BtMinus.Size = new System.Drawing.Size(82, 56);
            this.BtMinus.TabIndex = 6;
            this.BtMinus.Text = "-";
            this.BtMinus.UseVisualStyleBackColor = false;
            this.BtMinus.Click += new System.EventHandler(this.BtMinus_Click);
            // 
            // BtMultiplic
            // 
            this.BtMultiplic.BackColor = System.Drawing.Color.DarkOrange;
            this.BtMultiplic.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtMultiplic.Location = new System.Drawing.Point(276, 347);
            this.BtMultiplic.Name = "BtMultiplic";
            this.BtMultiplic.Size = new System.Drawing.Size(82, 56);
            this.BtMultiplic.TabIndex = 7;
            this.BtMultiplic.Text = "*";
            this.BtMultiplic.UseVisualStyleBackColor = false;
            this.BtMultiplic.Click += new System.EventHandler(this.BtMultiplic_Click);
            // 
            // BtDecimal
            // 
            this.BtDecimal.BackColor = System.Drawing.Color.DarkOrange;
            this.BtDecimal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtDecimal.Location = new System.Drawing.Point(276, 409);
            this.BtDecimal.Name = "BtDecimal";
            this.BtDecimal.Size = new System.Drawing.Size(82, 56);
            this.BtDecimal.TabIndex = 8;
            this.BtDecimal.Text = "/";
            this.BtDecimal.UseVisualStyleBackColor = false;
            this.BtDecimal.Click += new System.EventHandler(this.BtDecimal_Click);
            // 
            // BtResult
            // 
            this.BtResult.BackColor = System.Drawing.Color.DarkOrange;
            this.BtResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtResult.Location = new System.Drawing.Point(276, 471);
            this.BtResult.Name = "BtResult";
            this.BtResult.Size = new System.Drawing.Size(82, 89);
            this.BtResult.TabIndex = 9;
            this.BtResult.Text = "=";
            this.BtResult.UseVisualStyleBackColor = false;
            this.BtResult.Click += new System.EventHandler(this.BtResult_Click);
            // 
            // BtMinOrPlus
            // 
            this.BtMinOrPlus.BackColor = System.Drawing.Color.DarkGray;
            this.BtMinOrPlus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtMinOrPlus.Location = new System.Drawing.Point(100, 163);
            this.BtMinOrPlus.Name = "BtMinOrPlus";
            this.BtMinOrPlus.Size = new System.Drawing.Size(82, 56);
            this.BtMinOrPlus.TabIndex = 10;
            this.BtMinOrPlus.Text = "+/-";
            this.BtMinOrPlus.UseVisualStyleBackColor = false;
            this.BtMinOrPlus.Click += new System.EventHandler(this.BtMinOrPlus_Click);
            // 
            // BtNum7
            // 
            this.BtNum7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtNum7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtNum7.Location = new System.Drawing.Point(12, 273);
            this.BtNum7.Name = "BtNum7";
            this.BtNum7.Size = new System.Drawing.Size(82, 56);
            this.BtNum7.TabIndex = 11;
            this.BtNum7.Text = "7";
            this.BtNum7.UseVisualStyleBackColor = false;
            this.BtNum7.Click += new System.EventHandler(this.BtNum7_Click);
            // 
            // Bt8
            // 
            this.Bt8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Bt8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt8.Location = new System.Drawing.Point(100, 273);
            this.Bt8.Name = "Bt8";
            this.Bt8.Size = new System.Drawing.Size(82, 56);
            this.Bt8.TabIndex = 12;
            this.Bt8.Text = "8";
            this.Bt8.UseVisualStyleBackColor = false;
            this.Bt8.Click += new System.EventHandler(this.Bt8_Click);
            // 
            // Bt9
            // 
            this.Bt9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Bt9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt9.Location = new System.Drawing.Point(188, 273);
            this.Bt9.Name = "Bt9";
            this.Bt9.Size = new System.Drawing.Size(82, 56);
            this.Bt9.TabIndex = 13;
            this.Bt9.Text = "9";
            this.Bt9.UseVisualStyleBackColor = false;
            this.Bt9.Click += new System.EventHandler(this.Bt9_Click);
            // 
            // Bt4
            // 
            this.Bt4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Bt4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt4.Location = new System.Drawing.Point(12, 347);
            this.Bt4.Name = "Bt4";
            this.Bt4.Size = new System.Drawing.Size(82, 56);
            this.Bt4.TabIndex = 14;
            this.Bt4.Text = "4";
            this.Bt4.UseVisualStyleBackColor = false;
            this.Bt4.Click += new System.EventHandler(this.Bt4_Click);
            // 
            // Bt5
            // 
            this.Bt5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Bt5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt5.Location = new System.Drawing.Point(100, 347);
            this.Bt5.Name = "Bt5";
            this.Bt5.Size = new System.Drawing.Size(82, 56);
            this.Bt5.TabIndex = 15;
            this.Bt5.Text = "5";
            this.Bt5.UseVisualStyleBackColor = false;
            this.Bt5.Click += new System.EventHandler(this.Bt5_Click);
            // 
            // Bt6
            // 
            this.Bt6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Bt6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt6.Location = new System.Drawing.Point(188, 347);
            this.Bt6.Name = "Bt6";
            this.Bt6.Size = new System.Drawing.Size(82, 56);
            this.Bt6.TabIndex = 16;
            this.Bt6.Text = "6";
            this.Bt6.UseVisualStyleBackColor = false;
            this.Bt6.Click += new System.EventHandler(this.Bt6_Click);
            // 
            // Bt1
            // 
            this.Bt1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Bt1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt1.Location = new System.Drawing.Point(12, 425);
            this.Bt1.Name = "Bt1";
            this.Bt1.Size = new System.Drawing.Size(82, 56);
            this.Bt1.TabIndex = 17;
            this.Bt1.Text = "1";
            this.Bt1.UseVisualStyleBackColor = false;
            this.Bt1.Click += new System.EventHandler(this.Bt1_Click);
            // 
            // Bt2
            // 
            this.Bt2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Bt2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt2.Location = new System.Drawing.Point(100, 425);
            this.Bt2.Name = "Bt2";
            this.Bt2.Size = new System.Drawing.Size(82, 56);
            this.Bt2.TabIndex = 18;
            this.Bt2.Text = "2";
            this.Bt2.UseVisualStyleBackColor = false;
            this.Bt2.Click += new System.EventHandler(this.Bt2_Click);
            // 
            // Bt3
            // 
            this.Bt3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Bt3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt3.Location = new System.Drawing.Point(188, 425);
            this.Bt3.Name = "Bt3";
            this.Bt3.Size = new System.Drawing.Size(82, 56);
            this.Bt3.TabIndex = 19;
            this.Bt3.Text = "3";
            this.Bt3.UseVisualStyleBackColor = false;
            this.Bt3.Click += new System.EventHandler(this.Bt3_Click);
            // 
            // BtZero
            // 
            this.BtZero.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtZero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtZero.Location = new System.Drawing.Point(12, 504);
            this.BtZero.Name = "BtZero";
            this.BtZero.Size = new System.Drawing.Size(152, 56);
            this.BtZero.TabIndex = 20;
            this.BtZero.Text = "0";
            this.BtZero.UseVisualStyleBackColor = false;
            this.BtZero.Click += new System.EventHandler(this.BtZero_Click);
            // 
            // BtDote
            // 
            this.BtDote.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtDote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtDote.Location = new System.Drawing.Point(188, 504);
            this.BtDote.Name = "BtDote";
            this.BtDote.Size = new System.Drawing.Size(82, 56);
            this.BtDote.TabIndex = 21;
            this.BtDote.Text = ".";
            this.BtDote.UseVisualStyleBackColor = false;
            this.BtDote.Click += new System.EventHandler(this.BtDote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "      CALCULATOR         ";
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.BackColor = System.Drawing.Color.Black;
            this.labelOperation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOperation.ForeColor = System.Drawing.Color.White;
            this.labelOperation.Location = new System.Drawing.Point(2, 48);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(0, 21);
            this.labelOperation.TabIndex = 23;
            this.labelOperation.Click += new System.EventHandler(this.labelOperation_Click);
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.BackColor = System.Drawing.Color.Black;
            this.labelNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNum.ForeColor = System.Drawing.Color.White;
            this.labelNum.Location = new System.Drawing.Point(2, 23);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(0, 21);
            this.labelNum.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(368, 572);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.labelOperation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtDote);
            this.Controls.Add(this.BtZero);
            this.Controls.Add(this.Bt3);
            this.Controls.Add(this.Bt2);
            this.Controls.Add(this.Bt1);
            this.Controls.Add(this.Bt6);
            this.Controls.Add(this.Bt5);
            this.Controls.Add(this.Bt4);
            this.Controls.Add(this.Bt9);
            this.Controls.Add(this.Bt8);
            this.Controls.Add(this.BtNum7);
            this.Controls.Add(this.BtMinOrPlus);
            this.Controls.Add(this.BtResult);
            this.Controls.Add(this.BtDecimal);
            this.Controls.Add(this.BtMultiplic);
            this.Controls.Add(this.BtMinus);
            this.Controls.Add(this.BtPlus);
            this.Controls.Add(this.BtMode);
            this.Controls.Add(this.BtClear);
            this.Controls.Add(this.BtPercent);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private Button BtPercent;
        private Button BtClear;
        private Button BtMode;
        private Button BtPlus;
        private Button BtMinus;
        private Button BtMultiplic;
        private Button BtDecimal;
        private Button BtResult;
        private Button BtMinOrPlus;
        private Button BtNum7;
        private Button Bt8;
        private Button Bt9;
        private Button Bt4;
        private Button Bt5;
        private Button Bt6;
        private Button Bt1;
        private Button Bt2;
        private Button Bt3;
        private Button BtZero;
        private Button BtDote;
        private Label label1;
        private Label labelOperation;
        private Label labelNum;
    }
}