namespace TicTacToe2
{
    partial class StartWindow
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
            this.HeightNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WidthNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ScaleNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CircleButton = new System.Windows.Forms.RadioButton();
            this.CrossButton = new System.Windows.Forms.RadioButton();
            this.HowMuchToWinNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.UkazatelZdaSeNacitaForms = new System.Windows.Forms.Label();
            this.LabelCelkem = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HowMuchToWinNum)).BeginInit();
            this.SuspendLayout();
            // 
            // HeightNum
            // 
            this.HeightNum.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeightNum.Location = new System.Drawing.Point(31, 68);
            this.HeightNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightNum.Name = "HeightNum";
            this.HeightNum.Size = new System.Drawing.Size(264, 46);
            this.HeightNum.TabIndex = 0;
            this.HeightNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.HeightNum.ValueChanged += new System.EventHandler(this.ChangeCelkemValue);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Výška";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Šířka";
            // 
            // WidthNum
            // 
            this.WidthNum.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WidthNum.Location = new System.Drawing.Point(31, 160);
            this.WidthNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthNum.Name = "WidthNum";
            this.WidthNum.Size = new System.Drawing.Size(264, 46);
            this.WidthNum.TabIndex = 2;
            this.WidthNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.WidthNum.ValueChanged += new System.EventHandler(this.ChangeCelkemValue);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Velikost políčka";
            // 
            // ScaleNum
            // 
            this.ScaleNum.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScaleNum.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ScaleNum.Location = new System.Drawing.Point(31, 303);
            this.ScaleNum.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ScaleNum.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ScaleNum.Name = "ScaleNum";
            this.ScaleNum.Size = new System.Drawing.Size(264, 46);
            this.ScaleNum.TabIndex = 4;
            this.ScaleNum.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CircleButton);
            this.groupBox1.Controls.Add(this.CrossButton);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(332, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 90);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kdo začíná?";
            // 
            // CircleButton
            // 
            this.CircleButton.AutoSize = true;
            this.CircleButton.Location = new System.Drawing.Point(90, 34);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(101, 34);
            this.CircleButton.TabIndex = 1;
            this.CircleButton.Text = "Kolečka";
            this.CircleButton.UseVisualStyleBackColor = true;
            // 
            // CrossButton
            // 
            this.CrossButton.AutoSize = true;
            this.CrossButton.Checked = true;
            this.CrossButton.Location = new System.Drawing.Point(6, 34);
            this.CrossButton.Name = "CrossButton";
            this.CrossButton.Size = new System.Drawing.Size(85, 34);
            this.CrossButton.TabIndex = 0;
            this.CrossButton.TabStop = true;
            this.CrossButton.Text = "Křížky";
            this.CrossButton.UseVisualStyleBackColor = true;
            // 
            // HowMuchToWinNum
            // 
            this.HowMuchToWinNum.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HowMuchToWinNum.Location = new System.Drawing.Point(362, 183);
            this.HowMuchToWinNum.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.HowMuchToWinNum.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.HowMuchToWinNum.Name = "HowMuchToWinNum";
            this.HowMuchToWinNum.Size = new System.Drawing.Size(120, 39);
            this.HowMuchToWinNum.TabIndex = 7;
            this.HowMuchToWinNum.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(338, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kolik je potřeba na výhru";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(321, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 89);
            this.button1.TabIndex = 9;
            this.button1.Text = "Vytvořit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SpustHru);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 374);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(560, 40);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Visible = false;
            // 
            // UkazatelZdaSeNacitaForms
            // 
            this.UkazatelZdaSeNacitaForms.AutoSize = true;
            this.UkazatelZdaSeNacitaForms.BackColor = System.Drawing.Color.Transparent;
            this.UkazatelZdaSeNacitaForms.Location = new System.Drawing.Point(229, 417);
            this.UkazatelZdaSeNacitaForms.Name = "UkazatelZdaSeNacitaForms";
            this.UkazatelZdaSeNacitaForms.Size = new System.Drawing.Size(126, 15);
            this.UkazatelZdaSeNacitaForms.TabIndex = 11;
            this.UkazatelZdaSeNacitaForms.Text = "Tic Tac Toe is starting...";
            this.UkazatelZdaSeNacitaForms.Visible = false;
            // 
            // LabelCelkem
            // 
            this.LabelCelkem.AutoSize = true;
            this.LabelCelkem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelCelkem.Location = new System.Drawing.Point(31, 209);
            this.LabelCelkem.Name = "LabelCelkem";
            this.LabelCelkem.Size = new System.Drawing.Size(96, 21);
            this.LabelCelkem.TabIndex = 12;
            this.LabelCelkem.Text = "Celkem: 100";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(340, 329);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 19);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Automaticky Zmaximalizovat";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(189, -3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 45);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tic Tac Toe 2";
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 444);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.LabelCelkem);
            this.Controls.Add(this.UkazatelZdaSeNacitaForms);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HowMuchToWinNum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ScaleNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WidthNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeightNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartWindow";
            this.Text = "Piškvorky";
            ((System.ComponentModel.ISupportInitialize)(this.HeightNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HowMuchToWinNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown HeightNum;
        private Label label1;
        private Label label2;
        private NumericUpDown WidthNum;
        private Label label3;
        private NumericUpDown ScaleNum;
        private GroupBox groupBox1;
        private RadioButton CircleButton;
        private RadioButton CrossButton;
        private NumericUpDown HowMuchToWinNum;
        private Label label4;
        private Button button1;
        private ProgressBar progressBar1;
        private Label UkazatelZdaSeNacitaForms;
        private Label LabelCelkem;
        private CheckBox checkBox1;
        private Label label5;
    }
}