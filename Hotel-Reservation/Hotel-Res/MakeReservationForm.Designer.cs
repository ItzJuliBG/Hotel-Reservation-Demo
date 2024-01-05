namespace Hotel_Res
{
    partial class MakeReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeReservationForm));
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(237, 19);
            label1.Name = "label1";
            label1.Size = new Size(446, 47);
            label1.TabIndex = 0;
            label1.Text = "Въведете номер на стаята:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(170, 73);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(538, 47);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(170, 229);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(538, 47);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(298, 175);
            label2.Name = "label2";
            label2.Size = new Size(345, 47);
            label2.TabIndex = 2;
            label2.Text = "Име на резервация:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(298, 328);
            label3.Name = "label3";
            label3.Size = new Size(305, 47);
            label3.TabIndex = 4;
            label3.Text = "Стая/Апартамент:";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Стая", "Апартамент" });
            comboBox1.Location = new Point(170, 383);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(538, 49);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Enabled = false;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 16);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(14, 16);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(78, 76);
            button2.TabIndex = 14;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(298, 475);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(291, 91);
            button1.TabIndex = 16;
            button1.Text = "Добавяне";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MakeReservationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MakeReservationForm";
            Text = "MakeReservationForm";
            Load += MakeReservationForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private PictureBox pictureBox2;
        private Button button2;
        private Button button1;
    }
}