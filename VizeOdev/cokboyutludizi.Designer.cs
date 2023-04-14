
namespace VizeOdev
{
    partial class cokboyutludizi
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
            this.btnOlustur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDizi = new System.Windows.Forms.DataGridView();
            this.txtSatir = new System.Windows.Forms.TextBox();
            this.txtSutun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDizi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.Color.White;
            this.btnOlustur.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOlustur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOlustur.Location = new System.Drawing.Point(163, 345);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(139, 60);
            this.btnOlustur.TabIndex = 2;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(774, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "X";
            // 
            // dgvDizi
            // 
            this.dgvDizi.AllowUserToOrderColumns = true;
            this.dgvDizi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDizi.Location = new System.Drawing.Point(406, 91);
            this.dgvDizi.Name = "dgvDizi";
            this.dgvDizi.RowHeadersWidth = 51;
            this.dgvDizi.RowTemplate.Height = 24;
            this.dgvDizi.Size = new System.Drawing.Size(313, 314);
            this.dgvDizi.TabIndex = 23;
            // 
            // txtSatir
            // 
            this.txtSatir.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSatir.Location = new System.Drawing.Point(191, 95);
            this.txtSatir.Multiline = true;
            this.txtSatir.Name = "txtSatir";
            this.txtSatir.Size = new System.Drawing.Size(122, 36);
            this.txtSatir.TabIndex = 24;
            // 
            // txtSutun
            // 
            this.txtSutun.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSutun.Location = new System.Drawing.Point(191, 159);
            this.txtSutun.Multiline = true;
            this.txtSutun.Name = "txtSutun";
            this.txtSutun.Size = new System.Drawing.Size(122, 36);
            this.txtSutun.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(94, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "SATIR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(81, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 27;
            this.label2.Text = "SÜTUN:";
            // 
            // cokboyutludizi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSutun);
            this.Controls.Add(this.txtSatir);
            this.Controls.Add(this.dgvDizi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOlustur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cokboyutludizi";
            this.Text = "cokboyutludizi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDizi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDizi;
        private System.Windows.Forms.TextBox txtSatir;
        private System.Windows.Forms.TextBox txtSutun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}