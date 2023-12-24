namespace Quizcim
{
    partial class dbedit
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
            this.btn_updt = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.checkD = new System.Windows.Forms.CheckBox();
            this.checkB = new System.Windows.Forms.CheckBox();
            this.checkC = new System.Windows.Forms.CheckBox();
            this.checkA = new System.Windows.Forms.CheckBox();
            this.txtasw_d = new System.Windows.Forms.TextBox();
            this.txtasw_b = new System.Windows.Forms.TextBox();
            this.txtasw_c = new System.Windows.Forms.TextBox();
            this.txtasw_a = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtquestion = new System.Windows.Forms.TextBox();
            this.cmb_quiz = new System.Windows.Forms.ComboBox();
            this.list_quest = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_updt
            // 
            this.btn_updt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_updt.Location = new System.Drawing.Point(903, 470);
            this.btn_updt.Name = "btn_updt";
            this.btn_updt.Size = new System.Drawing.Size(157, 51);
            this.btn_updt.TabIndex = 1;
            this.btn_updt.Text = "Soruyu Güncelle";
            this.btn_updt.UseVisualStyleBackColor = true;
            this.btn_updt.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Location = new System.Drawing.Point(903, 34);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(157, 28);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Testi Sil !";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // checkD
            // 
            this.checkD.AutoSize = true;
            this.checkD.Location = new System.Drawing.Point(532, 540);
            this.checkD.Name = "checkD";
            this.checkD.Size = new System.Drawing.Size(112, 20);
            this.checkD.TabIndex = 30;
            this.checkD.Text = "Doğru Cevap:";
            this.checkD.UseVisualStyleBackColor = true;
            // 
            // checkB
            // 
            this.checkB.AutoSize = true;
            this.checkB.Location = new System.Drawing.Point(532, 444);
            this.checkB.Name = "checkB";
            this.checkB.Size = new System.Drawing.Size(112, 20);
            this.checkB.TabIndex = 29;
            this.checkB.Text = "Doğru Cevap:";
            this.checkB.UseVisualStyleBackColor = true;
            // 
            // checkC
            // 
            this.checkC.AutoSize = true;
            this.checkC.Location = new System.Drawing.Point(90, 540);
            this.checkC.Name = "checkC";
            this.checkC.Size = new System.Drawing.Size(112, 20);
            this.checkC.TabIndex = 28;
            this.checkC.Text = "Doğru Cevap:";
            this.checkC.UseVisualStyleBackColor = true;
            // 
            // checkA
            // 
            this.checkA.AutoSize = true;
            this.checkA.Location = new System.Drawing.Point(90, 443);
            this.checkA.Name = "checkA";
            this.checkA.Size = new System.Drawing.Size(112, 20);
            this.checkA.TabIndex = 27;
            this.checkA.Text = "Doğru Cevap:";
            this.checkA.UseVisualStyleBackColor = true;
            // 
            // txtasw_d
            // 
            this.txtasw_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtasw_d.Location = new System.Drawing.Point(453, 566);
            this.txtasw_d.Multiline = true;
            this.txtasw_d.Name = "txtasw_d";
            this.txtasw_d.Size = new System.Drawing.Size(405, 51);
            this.txtasw_d.TabIndex = 26;
            this.txtasw_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtasw_b
            // 
            this.txtasw_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtasw_b.Location = new System.Drawing.Point(453, 470);
            this.txtasw_b.Multiline = true;
            this.txtasw_b.Name = "txtasw_b";
            this.txtasw_b.Size = new System.Drawing.Size(405, 51);
            this.txtasw_b.TabIndex = 25;
            this.txtasw_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtasw_c
            // 
            this.txtasw_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtasw_c.Location = new System.Drawing.Point(12, 566);
            this.txtasw_c.Multiline = true;
            this.txtasw_c.Name = "txtasw_c";
            this.txtasw_c.Size = new System.Drawing.Size(405, 51);
            this.txtasw_c.TabIndex = 24;
            this.txtasw_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtasw_a
            // 
            this.txtasw_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtasw_a.Location = new System.Drawing.Point(12, 470);
            this.txtasw_a.Multiline = true;
            this.txtasw_a.Name = "txtasw_a";
            this.txtasw_a.Size = new System.Drawing.Size(405, 51);
            this.txtasw_a.TabIndex = 19;
            this.txtasw_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "C Şıkkı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(450, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "D Şıkkı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(451, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "B Şıkkı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "A Şıkkı";
            // 
            // txtquestion
            // 
            this.txtquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtquestion.Location = new System.Drawing.Point(12, 85);
            this.txtquestion.Multiline = true;
            this.txtquestion.Name = "txtquestion";
            this.txtquestion.Size = new System.Drawing.Size(846, 335);
            this.txtquestion.TabIndex = 31;
            // 
            // cmb_quiz
            // 
            this.cmb_quiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_quiz.FormattingEnabled = true;
            this.cmb_quiz.Location = new System.Drawing.Point(12, 34);
            this.cmb_quiz.Name = "cmb_quiz";
            this.cmb_quiz.Size = new System.Drawing.Size(846, 28);
            this.cmb_quiz.TabIndex = 32;
            this.cmb_quiz.SelectedIndexChanged += new System.EventHandler(this.cmb_quiz_SelectedIndexChanged);
            // 
            // list_quest
            // 
            this.list_quest.FormattingEnabled = true;
            this.list_quest.ItemHeight = 16;
            this.list_quest.Items.AddRange(new object[] {
            "Soru 1",
            "Soru 2",
            "Soru 3",
            "Soru 4",
            "Soru 5",
            "Soru 6",
            "Soru 7",
            "Soru 8",
            "Soru 9",
            "Soru 10",
            "Soru 11",
            "Soru 12",
            "Soru 13",
            "Soru 14",
            "Soru 15",
            "Soru 16",
            "Soru 17",
            "Soru 18",
            "Soru 19",
            "Soru 20"});
            this.list_quest.Location = new System.Drawing.Point(903, 96);
            this.list_quest.Name = "list_quest";
            this.list_quest.Size = new System.Drawing.Size(157, 324);
            this.list_quest.TabIndex = 35;
            this.list_quest.SelectedIndexChanged += new System.EventHandler(this.list_quest_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Düzenlemek İstediğiniz Testi Seçiniz:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(902, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Soruyu Seçiniz:";
            // 
            // dbedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1072, 629);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_quest);
            this.Controls.Add(this.cmb_quiz);
            this.Controls.Add(this.txtquestion);
            this.Controls.Add(this.checkD);
            this.Controls.Add(this.checkB);
            this.Controls.Add(this.checkC);
            this.Controls.Add(this.checkA);
            this.Controls.Add(this.txtasw_d);
            this.Controls.Add(this.txtasw_b);
            this.Controls.Add(this.txtasw_c);
            this.Controls.Add(this.txtasw_a);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_updt);
            this.Name = "dbedit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "dbedit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dbedit_FormClosing);
            this.Load += new System.EventHandler(this.dbedit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_updt;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.CheckBox checkD;
        private System.Windows.Forms.CheckBox checkB;
        private System.Windows.Forms.CheckBox checkC;
        private System.Windows.Forms.CheckBox checkA;
        private System.Windows.Forms.TextBox txtasw_d;
        private System.Windows.Forms.TextBox txtasw_b;
        private System.Windows.Forms.TextBox txtasw_c;
        private System.Windows.Forms.TextBox txtasw_a;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtquestion;
        private System.Windows.Forms.ComboBox cmb_quiz;
        private System.Windows.Forms.ListBox list_quest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}