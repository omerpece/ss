namespace Metotlarr
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
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.btnornek1 = new System.Windows.Forms.Button();
            this.btnornek2 = new System.Windows.Forms.Button();
            this.btnornek3 = new System.Windows.Forms.Button();
            this.btnornek4 = new System.Windows.Forms.Button();
            this.btnornek5 = new System.Windows.Forms.Button();
            this.btnornek7 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(13, 13);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(100, 20);
            this.txtbox1.TabIndex = 0;
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(119, 13);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(100, 20);
            this.txtbox2.TabIndex = 0;
            // 
            // btnornek1
            // 
            this.btnornek1.Location = new System.Drawing.Point(13, 39);
            this.btnornek1.Name = "btnornek1";
            this.btnornek1.Size = new System.Drawing.Size(206, 23);
            this.btnornek1.TabIndex = 1;
            this.btnornek1.Text = "kadar saydır";
            this.btnornek1.UseVisualStyleBackColor = true;
            this.btnornek1.Click += new System.EventHandler(this.Btnornek1_Click);
            // 
            // btnornek2
            // 
            this.btnornek2.Location = new System.Drawing.Point(12, 68);
            this.btnornek2.Name = "btnornek2";
            this.btnornek2.Size = new System.Drawing.Size(206, 23);
            this.btnornek2.TabIndex = 1;
            this.btnornek2.Text = "toplamın küpü";
            this.btnornek2.UseVisualStyleBackColor = true;
            this.btnornek2.Click += new System.EventHandler(this.Btnornek2_Click);
            // 
            // btnornek3
            // 
            this.btnornek3.Location = new System.Drawing.Point(12, 97);
            this.btnornek3.Name = "btnornek3";
            this.btnornek3.Size = new System.Drawing.Size(206, 23);
            this.btnornek3.TabIndex = 1;
            this.btnornek3.Text = "son üç harfi kırp";
            this.btnornek3.UseVisualStyleBackColor = true;
            this.btnornek3.Click += new System.EventHandler(this.Btnornek3_Click);
            // 
            // btnornek4
            // 
            this.btnornek4.Location = new System.Drawing.Point(12, 126);
            this.btnornek4.Name = "btnornek4";
            this.btnornek4.Size = new System.Drawing.Size(206, 23);
            this.btnornek4.TabIndex = 1;
            this.btnornek4.Text = "girilen mailleri ayrıştır";
            this.btnornek4.UseVisualStyleBackColor = true;
            this.btnornek4.Click += new System.EventHandler(this.Btnornek4_Click);
            // 
            // btnornek5
            // 
            this.btnornek5.Location = new System.Drawing.Point(12, 155);
            this.btnornek5.Name = "btnornek5";
            this.btnornek5.Size = new System.Drawing.Size(206, 23);
            this.btnornek5.TabIndex = 1;
            this.btnornek5.Text = "seslileri göster";
            this.btnornek5.UseVisualStyleBackColor = true;
            this.btnornek5.Click += new System.EventHandler(this.Btnornek5_Click);
            // 
            // btnornek7
            // 
            this.btnornek7.Location = new System.Drawing.Point(13, 213);
            this.btnornek7.Name = "btnornek7";
            this.btnornek7.Size = new System.Drawing.Size(206, 23);
            this.btnornek7.TabIndex = 1;
            this.btnornek7.Text = "arkaplan degistir";
            this.btnornek7.UseVisualStyleBackColor = true;
            this.btnornek7.Click += new System.EventHandler(this.Btnornek7_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(245, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 212);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(382, 23);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 212);
            this.listBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Black",
            "blue",
            "Yellow",
            "Maroon",
            "Orange",
            "Grey",
            "White"});
            this.comboBox1.Location = new System.Drawing.Point(13, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 324);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnornek7);
            this.Controls.Add(this.btnornek5);
            this.Controls.Add(this.btnornek4);
            this.Controls.Add(this.btnornek3);
            this.Controls.Add(this.btnornek2);
            this.Controls.Add(this.btnornek1);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.txtbox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.Button btnornek1;
        private System.Windows.Forms.Button btnornek2;
        private System.Windows.Forms.Button btnornek3;
        private System.Windows.Forms.Button btnornek4;
        private System.Windows.Forms.Button btnornek5;
        private System.Windows.Forms.Button btnornek7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}