namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sonucLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.oranLabel = new System.Windows.Forms.Label();
            this.sonucGosterBtn = new System.Windows.Forms.Button();
            this.evBox = new System.Windows.Forms.ComboBox();
            this.depBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(89, 337);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(896, 378);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(192, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "EV SAHİBİ TAKIM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(551, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "DEPLASMAN TAKIM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(161, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "HANGİ TAKIM KAZANIR: ";
            // 
            // sonucLabel
            // 
            this.sonucLabel.AutoSize = true;
            this.sonucLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sonucLabel.Location = new System.Drawing.Point(563, 156);
            this.sonucLabel.Name = "sonucLabel";
            this.sonucLabel.Size = new System.Drawing.Size(0, 31);
            this.sonucLabel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(244, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "KAZANMA ORANI: ";
            // 
            // oranLabel
            // 
            this.oranLabel.AutoSize = true;
            this.oranLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.oranLabel.Location = new System.Drawing.Point(564, 206);
            this.oranLabel.Name = "oranLabel";
            this.oranLabel.Size = new System.Drawing.Size(0, 31);
            this.oranLabel.TabIndex = 8;
            this.oranLabel.Click += new System.EventHandler(this.oranLabel_Click);
            // 
            // sonucGosterBtn
            // 
            this.sonucGosterBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sonucGosterBtn.Location = new System.Drawing.Point(403, 256);
            this.sonucGosterBtn.Name = "sonucGosterBtn";
            this.sonucGosterBtn.Size = new System.Drawing.Size(189, 60);
            this.sonucGosterBtn.TabIndex = 9;
            this.sonucGosterBtn.Text = "SONUÇ";
            this.sonucGosterBtn.UseVisualStyleBackColor = true;
            this.sonucGosterBtn.Click += new System.EventHandler(this.sonucGosterBtn_Click);
            // 
            // evBox
            // 
            this.evBox.FormattingEnabled = true;
            this.evBox.Location = new System.Drawing.Point(192, 110);
            this.evBox.Name = "evBox";
            this.evBox.Size = new System.Drawing.Size(260, 28);
            this.evBox.TabIndex = 10;
            this.evBox.SelectedIndexChanged += new System.EventHandler(this.evBox_SelectedIndexChanged);
            // 
            // depBox
            // 
            this.depBox.FormattingEnabled = true;
            this.depBox.Location = new System.Drawing.Point(551, 110);
            this.depBox.Name = "depBox";
            this.depBox.Size = new System.Drawing.Size(260, 28);
            this.depBox.TabIndex = 11;
            this.depBox.SelectedIndexChanged += new System.EventHandler(this.depBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 727);
            this.Controls.Add(this.depBox);
            this.Controls.Add(this.evBox);
            this.Controls.Add(this.sonucGosterBtn);
            this.Controls.Add(this.oranLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sonucLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label sonucLabel;
        private Label label4;
        private Label oranLabel;
        private Button sonucGosterBtn;
        private ComboBox evBox;
        private ComboBox depBox;
    }
}