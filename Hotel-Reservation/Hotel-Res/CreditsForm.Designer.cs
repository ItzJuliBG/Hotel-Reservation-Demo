namespace Hotel_Reservations
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
            label1 = new Label();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            label2 = new Label();
            progressBar3 = new ProgressBar();
            label3 = new Label();
            progressBar4 = new ProgressBar();
            label4 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();

            button7 = new Button();

            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(209, 52);
            label1.Name = "label1";
            label1.Size = new Size(374, 36);
            label1.TabIndex = 0;
            label1.Text = "Константин Христианов Ганев";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(0, 91);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(800, 10);
            progressBar1.TabIndex = 1;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(0, 268);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(800, 10);
            progressBar2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(219, 229);
            label2.Name = "label2";
            label2.Size = new Size(357, 36);
            label2.TabIndex = 2;
            label2.Text = "Радослав Ивайлов Пангелов";
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(0, 180);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(800, 10);
            progressBar3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(219, 141);
            label3.Name = "label3";
            label3.Size = new Size(343, 36);
            label3.TabIndex = 4;
            label3.Text = "Юлиян Велиславов Наумов";
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(0, 353);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(800, 10);
            progressBar4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(266, 314);
            label4.Name = "label4";
            label4.Size = new Size(258, 36);
            label4.TabIndex = 6;
            label4.Text = "Валентин ? Малаков";
            // 
            // button1
            // 

            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(12, 12);

            button1.Location = new Point(61, 12);

            button1.Name = "button1";
            button1.Size = new Size(58, 57);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;

            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Enabled = false;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);

            pictureBox1.Enabled = false;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 12);

            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
 
            button7.Cursor = Cursors.Hand;
            button7.Location = new Point(12, 397);
            button7.Name = "button7";
            button7.Size = new Size(117, 41);
            button7.TabIndex = 10;
            button7.Text = "Exit";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);

            Controls.Add(button7);

            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(progressBar4);
            Controls.Add(label4);
            Controls.Add(progressBar3);
            Controls.Add(label3);
            Controls.Add(progressBar2);
            Controls.Add(label2);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Name = "CreditsForm";
            Text = "CreditsForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private Label label2;
        private ProgressBar progressBar3;
        private Label label3;
        private ProgressBar progressBar4;
        private Label label4;
        private Button button1;
        private PictureBox pictureBox1;

        private Button button7;

    }
}