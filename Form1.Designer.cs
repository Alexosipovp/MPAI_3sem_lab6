namespace Lab6
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(34, 34);
            label1.Margin = new Padding(25);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 0;
            label1.Text = "Скорость т.с.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(34, 116);
            label2.Margin = new Padding(25);
            label2.Name = "label2";
            label2.Size = new Size(216, 32);
            label2.TabIndex = 2;
            label2.Text = "Скорость машины";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(34, 198);
            label3.Margin = new Padding(25);
            label3.Name = "label3";
            label3.Size = new Size(189, 32);
            label3.TabIndex = 3;
            label3.Text = "Скорость лодки";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(34, 280);
            label4.Margin = new Padding(25);
            label4.Name = "label4";
            label4.Size = new Size(213, 32);
            label4.TabIndex = 4;
            label4.Text = "Скорость гибрида";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(287, 34);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 39);
            textBox1.TabIndex = 6;
            textBox1.Text = "0";
            textBox1.KeyDown += VehicleChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(287, 116);
            textBox2.Margin = new Padding(0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 39);
            textBox2.TabIndex = 8;
            textBox2.Text = "0";
            textBox2.KeyDown += CarChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14F);
            textBox3.Location = new Point(287, 198);
            textBox3.Margin = new Padding(0);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(201, 39);
            textBox3.TabIndex = 9;
            textBox3.Text = "0";
            textBox3.KeyDown += BoatChanged;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14F);
            textBox4.Location = new Point(287, 280);
            textBox4.Margin = new Padding(0);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(201, 39);
            textBox4.TabIndex = 10;
            textBox4.Text = "0";
            textBox4.KeyDown += FLChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(548, 448);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
