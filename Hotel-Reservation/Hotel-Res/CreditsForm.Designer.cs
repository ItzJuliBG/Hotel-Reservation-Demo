namespace Hotel_Res
{
    partial class CreditsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditsForm));
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            title = new Label();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Team", "Back-End Development", "Early Design Development", "Documentation & Presentation" });
            comboBox1.Location = new Point(149, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(493, 40);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(160, 140);
            label1.Name = "label1";
            label1.Size = new Size(493, 46);
            label1.TabIndex = 0;
            label1.Text = "Константин Христианов Ганев";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(160, 209);
            label2.Name = "label2";
            label2.Size = new Size(449, 46);
            label2.TabIndex = 4;
            label2.Text = "Юлиян Велиславов Наумов";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(243, 6);
            title.Name = "title";
            title.Size = new Size(99, 46);
            title.TabIndex = 5;
            title.Text = "Team";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Enabled = false;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(12, 9);
            button2.Name = "button2";
            button2.Size = new Size(68, 57);
            button2.TabIndex = 16;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(160, 281);
            label3.Name = "label3";
            label3.Size = new Size(466, 46);
            label3.TabIndex = 18;
            label3.Text = "Радослав Ивайлов Пангелов";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(160, 352);
            label4.Name = "label4";
            label4.Size = new Size(450, 46);
            label4.TabIndex = 19;
            label4.Text = "walentin valentinow malakov";
            // 
            // CreditsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(title);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "CreditsForm";
            Text = "CreditsForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label title;
        private PictureBox pictureBox2;
        private Button button2;
        private Label label3;
        private Label label4;
    }
}