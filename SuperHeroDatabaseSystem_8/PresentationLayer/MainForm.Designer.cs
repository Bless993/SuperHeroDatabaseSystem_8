namespace SuperHeroDatabaseSystem_8.PresentationLayer
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpAddHero = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtExamScore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSuperpower = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeroID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHeroes = new System.Windows.Forms.DataGridView();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.txtHeroesPerRank = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAverageAge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalHeroes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpAddHero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeroes)).BeginInit();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(350, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(384, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Superhero Database System";
            // 
            // grpAddHero
            // 
            this.grpAddHero.Controls.Add(this.btnDelete);
            this.grpAddHero.Controls.Add(this.btnUpdate);
            this.grpAddHero.Controls.Add(this.btnAdd);
            this.grpAddHero.Controls.Add(this.txtExamScore);
            this.grpAddHero.Controls.Add(this.label5);
            this.grpAddHero.Controls.Add(this.txtSuperpower);
            this.grpAddHero.Controls.Add(this.label4);
            this.grpAddHero.Controls.Add(this.txtAge);
            this.grpAddHero.Controls.Add(this.label3);
            this.grpAddHero.Controls.Add(this.txtName);
            this.grpAddHero.Controls.Add(this.label2);
            this.grpAddHero.Controls.Add(this.txtHeroID);
            this.grpAddHero.Controls.Add(this.label1);
            this.grpAddHero.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddHero.Location = new System.Drawing.Point(30, 70);
            this.grpAddHero.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpAddHero.Name = "grpAddHero";
            this.grpAddHero.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpAddHero.Size = new System.Drawing.Size(410, 316);
            this.grpAddHero.TabIndex = 1;
            this.grpAddHero.TabStop = false;
            this.grpAddHero.Text = "Add / Update Superhero";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(249, 240);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 32);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete Hero";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(128, 240);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 32);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update Hero";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 240);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 32);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Hero";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtExamScore
            // 
            this.txtExamScore.Location = new System.Drawing.Point(128, 200);
            this.txtExamScore.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtExamScore.Name = "txtExamScore";
            this.txtExamScore.Size = new System.Drawing.Size(178, 30);
            this.txtExamScore.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Exam Score:";
            // 
            // txtSuperpower
            // 
            this.txtSuperpower.Location = new System.Drawing.Point(128, 154);
            this.txtSuperpower.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSuperpower.Name = "txtSuperpower";
            this.txtSuperpower.Size = new System.Drawing.Size(178, 30);
            this.txtSuperpower.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Superpower:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(90, 114);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(155, 30);
            this.txtAge.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 68);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 30);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // txtHeroID
            // 
            this.txtHeroID.Location = new System.Drawing.Point(90, 23);
            this.txtHeroID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtHeroID.Name = "txtHeroID";
            this.txtHeroID.Size = new System.Drawing.Size(155, 30);
            this.txtHeroID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hero ID:";
            // 
            // dgvHeroes
            // 
            this.dgvHeroes.AllowUserToAddRows = false;
            this.dgvHeroes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHeroes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHeroes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHeroes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHeroes.Location = new System.Drawing.Point(480, 70);
            this.dgvHeroes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvHeroes.Name = "dgvHeroes";
            this.dgvHeroes.ReadOnly = true;
            this.dgvHeroes.RowHeadersWidth = 51;
            this.dgvHeroes.RowTemplate.Height = 24;
            this.dgvHeroes.Size = new System.Drawing.Size(566, 316);
            this.dgvHeroes.TabIndex = 2;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.btnView);
            this.grpSummary.Controls.Add(this.btnSummary);
            this.grpSummary.Controls.Add(this.txtHeroesPerRank);
            this.grpSummary.Controls.Add(this.label9);
            this.grpSummary.Controls.Add(this.txtAverageScore);
            this.grpSummary.Controls.Add(this.label8);
            this.grpSummary.Controls.Add(this.txtAverageAge);
            this.grpSummary.Controls.Add(this.label7);
            this.grpSummary.Controls.Add(this.txtTotalHeroes);
            this.grpSummary.Controls.Add(this.label6);
            this.grpSummary.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSummary.Location = new System.Drawing.Point(30, 447);
            this.grpSummary.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpSummary.Size = new System.Drawing.Size(1162, 209);
            this.grpSummary.TabIndex = 3;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary Report";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(631, 140);
            this.btnView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(369, 38);
            this.btnView.TabIndex = 9;
            this.btnView.Text = "View All";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(127, 140);
            this.btnSummary.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(296, 38);
            this.btnSummary.TabIndex = 8;
            this.btnSummary.Text = "Generate Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // txtHeroesPerRank
            // 
            this.txtHeroesPerRank.Location = new System.Drawing.Point(262, 77);
            this.txtHeroesPerRank.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtHeroesPerRank.Name = "txtHeroesPerRank";
            this.txtHeroesPerRank.ReadOnly = true;
            this.txtHeroesPerRank.Size = new System.Drawing.Size(162, 30);
            this.txtHeroesPerRank.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Heroes per Rank (S/A/B/C):";
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Location = new System.Drawing.Point(921, 26);
            this.txtAverageScore.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.ReadOnly = true;
            this.txtAverageScore.Size = new System.Drawing.Size(154, 30);
            this.txtAverageScore.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(718, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Average Exam Score:";
            // 
            // txtAverageAge
            // 
            this.txtAverageAge.Location = new System.Drawing.Point(461, 23);
            this.txtAverageAge.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAverageAge.Name = "txtAverageAge";
            this.txtAverageAge.ReadOnly = true;
            this.txtAverageAge.Size = new System.Drawing.Size(213, 30);
            this.txtAverageAge.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Average Age:";
            // 
            // txtTotalHeroes
            // 
            this.txtTotalHeroes.Location = new System.Drawing.Point(127, 23);
            this.txtTotalHeroes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTotalHeroes.Name = "txtTotalHeroes";
            this.txtTotalHeroes.ReadOnly = true;
            this.txtTotalHeroes.Size = new System.Drawing.Size(178, 30);
            this.txtTotalHeroes.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Heroes:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1286, 724);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.dgvHeroes);
            this.Controls.Add(this.grpAddHero);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Superhero Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpAddHero.ResumeLayout(false);
            this.grpAddHero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeroes)).EndInit();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpAddHero;
        private System.Windows.Forms.TextBox txtHeroID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtExamScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSuperpower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvHeroes;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.TextBox txtAverageAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalHeroes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHeroesPerRank;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnView;
    }
}