namespace Quizcim
{
    partial class QuizForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_D = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_A = new System.Windows.Forms.Button();
            this.txt_question = new System.Windows.Forms.TextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.lbl_tpl = new System.Windows.Forms.Label();
            this.lbl_puan = new System.Windows.Forms.Label();
            this.btnElipsA1 = new Quizcim.Buttonellips();
            this.btnElipsC1 = new Quizcim.Buttonellips();
            this.btnElipsD1 = new Quizcim.Buttonellips();
            this.btnElipsB1 = new Quizcim.Buttonellips();
            this.btnElipsD = new Quizcim.ButtonEllipse();
            this.btnElipsB = new Quizcim.ButtonEllipse();
            this.btnElipsC = new Quizcim.ButtonEllipse();
            this.btnElipsA = new Quizcim.ButtonEllipse();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Quizcim.Properties.Resources.millionairepics;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = global::Quizcim.Properties.Resources.millionairepics;
            this.pictureBox1.Image = global::Quizcim.Properties.Resources.millionairepics;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1214, 648);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_D
            // 
            this.btn_D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(62)))), ((int)(((byte)(149)))));
            this.btn_D.FlatAppearance.BorderSize = 0;
            this.btn_D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_D.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_D.Location = new System.Drawing.Point(661, 552);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(407, 57);
            this.btn_D.TabIndex = 3;
            this.btn_D.TabStop = false;
            this.btn_D.Text = "D Sıkkı";
            this.btn_D.UseVisualStyleBackColor = false;
            this.btn_D.Click += new System.EventHandler(this.btn_D_Click);
            // 
            // btn_B
            // 
            this.btn_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(62)))), ((int)(((byte)(149)))));
            this.btn_B.FlatAppearance.BorderSize = 0;
            this.btn_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_B.Location = new System.Drawing.Point(661, 465);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(407, 57);
            this.btn_B.TabIndex = 1;
            this.btn_B.TabStop = false;
            this.btn_B.Text = "B Sıkkı";
            this.btn_B.UseVisualStyleBackColor = false;
            this.btn_B.Click += new System.EventHandler(this.btn_B_Click);
            this.btn_B.MouseHover += new System.EventHandler(this.btn_B_MouseHover);
            // 
            // btn_C
            // 
            this.btn_C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(62)))), ((int)(((byte)(149)))));
            this.btn_C.FlatAppearance.BorderSize = 0;
            this.btn_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_C.Location = new System.Drawing.Point(143, 549);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(411, 61);
            this.btn_C.TabIndex = 4;
            this.btn_C.TabStop = false;
            this.btn_C.Text = "C Sıkkı";
            this.btn_C.UseVisualStyleBackColor = false;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_A
            // 
            this.btn_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(62)))), ((int)(((byte)(149)))));
            this.btn_A.FlatAppearance.BorderSize = 0;
            this.btn_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_A.Location = new System.Drawing.Point(143, 465);
            this.btn_A.Name = "btn_A";
            this.btn_A.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_A.Size = new System.Drawing.Size(411, 57);
            this.btn_A.TabIndex = 2;
            this.btn_A.TabStop = false;
            this.btn_A.Text = "A Sıkkı";
            this.btn_A.UseVisualStyleBackColor = false;
            this.btn_A.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // txt_question
            // 
            this.txt_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(62)))), ((int)(((byte)(149)))));
            this.txt_question.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_question.Location = new System.Drawing.Point(172, 332);
            this.txt_question.Multiline = true;
            this.txt_question.Name = "txt_question";
            this.txt_question.ReadOnly = true;
            this.txt_question.Size = new System.Drawing.Size(874, 92);
            this.txt_question.TabIndex = 5;
            this.txt_question.TabStop = false;
            this.txt_question.Text = "Soru: ";
            this.txt_question.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_next.Location = new System.Drawing.Point(1099, 257);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(115, 57);
            this.btn_next.TabIndex = 6;
            this.btn_next.Text = "Sonraki Soru ->";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Visible = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lbl_tpl
            // 
            this.lbl_tpl.AutoSize = true;
            this.lbl_tpl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.lbl_tpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tpl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(4)))));
            this.lbl_tpl.Location = new System.Drawing.Point(1103, 9);
            this.lbl_tpl.Name = "lbl_tpl";
            this.lbl_tpl.Size = new System.Drawing.Size(104, 18);
            this.lbl_tpl.TabIndex = 7;
            this.lbl_tpl.Text = "Toplam Puan: ";
            // 
            // lbl_puan
            // 
            this.lbl_puan.AutoSize = true;
            this.lbl_puan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.lbl_puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_puan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(4)))));
            this.lbl_puan.Location = new System.Drawing.Point(1103, 41);
            this.lbl_puan.Name = "lbl_puan";
            this.lbl_puan.Size = new System.Drawing.Size(16, 18);
            this.lbl_puan.TabIndex = 8;
            this.lbl_puan.Text = "0";
            this.lbl_puan.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnElipsA1
            // 
            this.btnElipsA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(62)))), ((int)(((byte)(149)))));
            this.btnElipsA1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnElipsA1.Enabled = false;
            this.btnElipsA1.FlatAppearance.BorderSize = 0;
            this.btnElipsA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElipsA1.Location = new System.Drawing.Point(521, 464);
            this.btnElipsA1.Margin = new System.Windows.Forms.Padding(0);
            this.btnElipsA1.Name = "btnElipsA1";
            this.btnElipsA1.Size = new System.Drawing.Size(61, 58);
            this.btnElipsA1.TabIndex = 16;
            this.btnElipsA1.UseVisualStyleBackColor = false;
            // 
            // btnElipsC1
            // 
            this.btnElipsC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(62)))), ((int)(((byte)(149)))));
            this.btnElipsC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnElipsC1.Enabled = false;
            this.btnElipsC1.FlatAppearance.BorderSize = 0;
            this.btnElipsC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElipsC1.Location = new System.Drawing.Point(521, 549);
            this.btnElipsC1.Margin = new System.Windows.Forms.Padding(0);
            this.btnElipsC1.Name = "btnElipsC1";
            this.btnElipsC1.Size = new System.Drawing.Size(60, 61);
            this.btnElipsC1.TabIndex = 15;
            this.btnElipsC1.UseVisualStyleBackColor = false;
            // 
            // btnElipsD1
            // 
            this.btnElipsD1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(62)))), ((int)(((byte)(149)))));
            this.btnElipsD1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnElipsD1.Enabled = false;
            this.btnElipsD1.FlatAppearance.BorderSize = 0;
            this.btnElipsD1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElipsD1.Location = new System.Drawing.Point(1029, 549);
            this.btnElipsD1.Margin = new System.Windows.Forms.Padding(0);
            this.btnElipsD1.Name = "btnElipsD1";
            this.btnElipsD1.Size = new System.Drawing.Size(65, 59);
            this.btnElipsD1.TabIndex = 14;
            this.btnElipsD1.UseVisualStyleBackColor = false;
            // 
            // btnElipsB1
            // 
            this.btnElipsB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(62)))), ((int)(((byte)(149)))));
            this.btnElipsB1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnElipsB1.Enabled = false;
            this.btnElipsB1.FlatAppearance.BorderSize = 0;
            this.btnElipsB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElipsB1.Location = new System.Drawing.Point(1029, 465);
            this.btnElipsB1.Margin = new System.Windows.Forms.Padding(0);
            this.btnElipsB1.Name = "btnElipsB1";
            this.btnElipsB1.Size = new System.Drawing.Size(65, 57);
            this.btnElipsB1.TabIndex = 13;
            this.btnElipsB1.UseVisualStyleBackColor = false;
            // 
            // btnElipsD
            // 
            this.btnElipsD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(62)))), ((int)(((byte)(149)))));
            this.btnElipsD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnElipsD.Enabled = false;
            this.btnElipsD.FlatAppearance.BorderSize = 0;
            this.btnElipsD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElipsD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnElipsD.Location = new System.Drawing.Point(607, 549);
            this.btnElipsD.Name = "btnElipsD";
            this.btnElipsD.Size = new System.Drawing.Size(94, 60);
            this.btnElipsD.TabIndex = 12;
            this.btnElipsD.UseVisualStyleBackColor = false;
            // 
            // btnElipsB
            // 
            this.btnElipsB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(62)))), ((int)(((byte)(149)))));
            this.btnElipsB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnElipsB.Enabled = false;
            this.btnElipsB.FlatAppearance.BorderSize = 0;
            this.btnElipsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElipsB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnElipsB.Location = new System.Drawing.Point(606, 461);
            this.btnElipsB.Name = "btnElipsB";
            this.btnElipsB.Size = new System.Drawing.Size(94, 61);
            this.btnElipsB.TabIndex = 11;
            this.btnElipsB.UseVisualStyleBackColor = false;
            // 
            // btnElipsC
            // 
            this.btnElipsC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(62)))), ((int)(((byte)(149)))));
            this.btnElipsC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnElipsC.Enabled = false;
            this.btnElipsC.FlatAppearance.BorderSize = 0;
            this.btnElipsC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElipsC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnElipsC.Location = new System.Drawing.Point(97, 549);
            this.btnElipsC.Name = "btnElipsC";
            this.btnElipsC.Size = new System.Drawing.Size(94, 60);
            this.btnElipsC.TabIndex = 10;
            this.btnElipsC.UseVisualStyleBackColor = false;
            // 
            // btnElipsA
            // 
            this.btnElipsA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(62)))), ((int)(((byte)(149)))));
            this.btnElipsA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnElipsA.Enabled = false;
            this.btnElipsA.FlatAppearance.BorderSize = 0;
            this.btnElipsA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElipsA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnElipsA.Location = new System.Drawing.Point(92, 461);
            this.btnElipsA.Name = "btnElipsA";
            this.btnElipsA.Size = new System.Drawing.Size(94, 61);
            this.btnElipsA.TabIndex = 9;
            this.btnElipsA.UseVisualStyleBackColor = false;
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 648);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_A);
            this.Controls.Add(this.btn_D);
            this.Controls.Add(this.btn_B);
            this.Controls.Add(this.btnElipsA1);
            this.Controls.Add(this.btnElipsC1);
            this.Controls.Add(this.btnElipsD1);
            this.Controls.Add(this.btnElipsB1);
            this.Controls.Add(this.btnElipsD);
            this.Controls.Add(this.btnElipsB);
            this.Controls.Add(this.btnElipsC);
            this.Controls.Add(this.btnElipsA);
            this.Controls.Add(this.lbl_puan);
            this.Controls.Add(this.lbl_tpl);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.txt_question);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuizForm_FormClosing);
            this.Load += new System.EventHandler(this.QuizForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.TextBox txt_question;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label lbl_tpl;
        private System.Windows.Forms.Label lbl_puan;
        private ButtonEllipse btnElipsA;
        private ButtonEllipse btnElipsC;
        private ButtonEllipse btnElipsB;
        private ButtonEllipse btnElipsD;
        private Buttonellips btnElipsB1;
        private Buttonellips btnElipsD1;
        private Buttonellips btnElipsC1;
        private Buttonellips btnElipsA1;
    }
}