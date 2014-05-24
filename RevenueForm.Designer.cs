namespace LemonadeStand
{
    partial class RevenueForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.lemonsTextBox = new System.Windows.Forms.TextBox();
            this.sugarTextBox = new System.Windows.Forms.TextBox();
            this.iceTextBox = new System.Windows.Forms.TextBox();
            this.lemonadeTextBox = new System.Windows.Forms.TextBox();
            this.profitsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.revenueTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price Per Cup:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lemons per pitcher:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cups of sugar per pitcher:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ice cube per pitcher:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cups of lemonade that can be made:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(143, 96);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 5;
            // 
            // lemonsTextBox
            // 
            this.lemonsTextBox.Location = new System.Drawing.Point(143, 13);
            this.lemonsTextBox.Name = "lemonsTextBox";
            this.lemonsTextBox.Size = new System.Drawing.Size(100, 20);
            this.lemonsTextBox.TabIndex = 6;
            // 
            // sugarTextBox
            // 
            this.sugarTextBox.Location = new System.Drawing.Point(143, 39);
            this.sugarTextBox.Name = "sugarTextBox";
            this.sugarTextBox.Size = new System.Drawing.Size(100, 20);
            this.sugarTextBox.TabIndex = 7;
            // 
            // iceTextBox
            // 
            this.iceTextBox.Location = new System.Drawing.Point(143, 65);
            this.iceTextBox.Name = "iceTextBox";
            this.iceTextBox.Size = new System.Drawing.Size(100, 20);
            this.iceTextBox.TabIndex = 8;
            // 
            // lemonadeTextBox
            // 
            this.lemonadeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lemonadeTextBox.Location = new System.Drawing.Point(464, 134);
            this.lemonadeTextBox.Name = "lemonadeTextBox";
            this.lemonadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.lemonadeTextBox.TabIndex = 9;
            // 
            // profitsTextBox
            // 
            this.profitsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.profitsTextBox.Location = new System.Drawing.Point(464, 191);
            this.profitsTextBox.Name = "profitsTextBox";
            this.profitsTextBox.Size = new System.Drawing.Size(100, 20);
            this.profitsTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Potentail Profits:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.iceTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sugarTextBox);
            this.groupBox1.Controls.Add(this.lemonsTextBox);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Location = new System.Drawing.Point(14, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 132);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Potentail Revenue:";
            // 
            // revenueTextBox
            // 
            this.revenueTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.revenueTextBox.Location = new System.Drawing.Point(464, 160);
            this.revenueTextBox.Name = "revenueTextBox";
            this.revenueTextBox.Size = new System.Drawing.Size(100, 20);
            this.revenueTextBox.TabIndex = 14;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(74, 256);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 15;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(221, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 55);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sales";
            // 
            // RevenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 291);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.revenueTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lemonadeTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.profitsTextBox);
            this.Name = "RevenueForm";
            this.Text = "RevenueForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lemonsTextBox;
        private System.Windows.Forms.TextBox sugarTextBox;
        private System.Windows.Forms.TextBox iceTextBox;
        private System.Windows.Forms.TextBox lemonadeTextBox;
        private System.Windows.Forms.TextBox profitsTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox revenueTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label8;
    }
}