namespace Rehber_Uygulaması
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxTEL = new System.Windows.Forms.MaskedTextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonEKLE = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAD = new System.Windows.Forms.TextBox();
            this.textBoxSOYAD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSIL = new System.Windows.Forms.Button();
            this.buttonGUNCELLE = new System.Windows.Forms.Button();
            this.buttonTEMIZLE = new System.Windows.Forms.Button();
            this.textBoxMAIL = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 489);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REHBER";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxMAIL);
            this.groupBox2.Controls.Add(this.buttonTEMIZLE);
            this.groupBox2.Controls.Add(this.buttonGUNCELLE);
            this.groupBox2.Controls.Add(this.buttonSIL);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxSOYAD);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxAD);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonEKLE);
            this.groupBox2.Controls.Add(this.maskedTextBoxTEL);
            this.groupBox2.Controls.Add(this.textBoxID);
            this.groupBox2.Location = new System.Drawing.Point(803, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 489);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "YENİ KİŞİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // maskedTextBoxTEL
            // 
            this.maskedTextBoxTEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.maskedTextBoxTEL.Location = new System.Drawing.Point(112, 186);
            this.maskedTextBoxTEL.Mask = "(999) 000-0000";
            this.maskedTextBoxTEL.Name = "maskedTextBoxTEL";
            this.maskedTextBoxTEL.Size = new System.Drawing.Size(270, 30);
            this.maskedTextBoxTEL.TabIndex = 3;
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxID.Location = new System.Drawing.Point(112, 54);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(270, 30);
            this.textBoxID.TabIndex = 15;
            // 
            // buttonEKLE
            // 
            this.buttonEKLE.Location = new System.Drawing.Point(113, 283);
            this.buttonEKLE.Name = "buttonEKLE";
            this.buttonEKLE.Size = new System.Drawing.Size(129, 39);
            this.buttonEKLE.TabIndex = 5;
            this.buttonEKLE.Text = "EKLE";
            this.buttonEKLE.UseVisualStyleBackColor = true;
            this.buttonEKLE.Click += new System.EventHandler(this.buttonEKLE_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(779, 460);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "AD:";
            // 
            // textBoxAD
            // 
            this.textBoxAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxAD.Location = new System.Drawing.Point(112, 96);
            this.textBoxAD.Name = "textBoxAD";
            this.textBoxAD.Size = new System.Drawing.Size(270, 30);
            this.textBoxAD.TabIndex = 1;
            // 
            // textBoxSOYAD
            // 
            this.textBoxSOYAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxSOYAD.Location = new System.Drawing.Point(112, 139);
            this.textBoxSOYAD.Name = "textBoxSOYAD";
            this.textBoxSOYAD.Size = new System.Drawing.Size(270, 30);
            this.textBoxSOYAD.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "SOYAD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "TEL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "MAİL:";
            // 
            // buttonSIL
            // 
            this.buttonSIL.Location = new System.Drawing.Point(248, 283);
            this.buttonSIL.Name = "buttonSIL";
            this.buttonSIL.Size = new System.Drawing.Size(134, 39);
            this.buttonSIL.TabIndex = 6;
            this.buttonSIL.Text = "SİL";
            this.buttonSIL.UseVisualStyleBackColor = true;
            this.buttonSIL.Click += new System.EventHandler(this.buttonSIL_Click);
            // 
            // buttonGUNCELLE
            // 
            this.buttonGUNCELLE.Location = new System.Drawing.Point(112, 328);
            this.buttonGUNCELLE.Name = "buttonGUNCELLE";
            this.buttonGUNCELLE.Size = new System.Drawing.Size(130, 39);
            this.buttonGUNCELLE.TabIndex = 7;
            this.buttonGUNCELLE.Text = "GÜNCELLE";
            this.buttonGUNCELLE.UseVisualStyleBackColor = true;
            this.buttonGUNCELLE.Click += new System.EventHandler(this.buttonGUNCELLE_Click);
            // 
            // buttonTEMIZLE
            // 
            this.buttonTEMIZLE.Location = new System.Drawing.Point(248, 328);
            this.buttonTEMIZLE.Name = "buttonTEMIZLE";
            this.buttonTEMIZLE.Size = new System.Drawing.Size(134, 39);
            this.buttonTEMIZLE.TabIndex = 8;
            this.buttonTEMIZLE.Text = "TEMİZLE";
            this.buttonTEMIZLE.UseVisualStyleBackColor = true;
            this.buttonTEMIZLE.Click += new System.EventHandler(this.buttonTEMIZLE_Click);
            // 
            // textBoxMAIL
            // 
            this.textBoxMAIL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxMAIL.Location = new System.Drawing.Point(112, 231);
            this.textBoxMAIL.Name = "textBoxMAIL";
            this.textBoxMAIL.Size = new System.Drawing.Size(270, 30);
            this.textBoxMAIL.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1263, 527);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Rehber";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxSOYAD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEKLE;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTEL;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonTEMIZLE;
        private System.Windows.Forms.Button buttonGUNCELLE;
        private System.Windows.Forms.Button buttonSIL;
        private System.Windows.Forms.TextBox textBoxMAIL;
    }
}

