
namespace WindowsFormQRCode
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
            this.lblQRCode = new System.Windows.Forms.Label();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.txtQRCode = new System.Windows.Forms.TextBox();
            this.btnGerarQRCode = new System.Windows.Forms.Button();
            this.btnLimparQRCode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQRCode
            // 
            this.lblQRCode.AutoSize = true;
            this.lblQRCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQRCode.Location = new System.Drawing.Point(40, 17);
            this.lblQRCode.Name = "lblQRCode";
            this.lblQRCode.Size = new System.Drawing.Size(55, 15);
            this.lblQRCode.TabIndex = 0;
            this.lblQRCode.Text = "QR Code";
            // 
            // picQRCode
            // 
            this.picQRCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picQRCode.Location = new System.Drawing.Point(40, 48);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(311, 325);
            this.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picQRCode.TabIndex = 1;
            this.picQRCode.TabStop = false;
            // 
            // txtQRCode
            // 
            this.txtQRCode.Location = new System.Drawing.Point(378, 48);
            this.txtQRCode.Multiline = true;
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQRCode.Size = new System.Drawing.Size(244, 219);
            this.txtQRCode.TabIndex = 2;
            // 
            // btnGerarQRCode
            // 
            this.btnGerarQRCode.Location = new System.Drawing.Point(378, 290);
            this.btnGerarQRCode.Name = "btnGerarQRCode";
            this.btnGerarQRCode.Size = new System.Drawing.Size(115, 23);
            this.btnGerarQRCode.TabIndex = 3;
            this.btnGerarQRCode.Text = "Gerar Código";
            this.btnGerarQRCode.UseVisualStyleBackColor = true;
            this.btnGerarQRCode.Click += new System.EventHandler(this.btnGerarQRCode_Click);
            // 
            // btnLimparQRCode
            // 
            this.btnLimparQRCode.Location = new System.Drawing.Point(378, 329);
            this.btnLimparQRCode.Name = "btnLimparQRCode";
            this.btnLimparQRCode.Size = new System.Drawing.Size(115, 23);
            this.btnLimparQRCode.TabIndex = 3;
            this.btnLimparQRCode.Text = "Limpar Código";
            this.btnLimparQRCode.UseVisualStyleBackColor = true;
            this.btnLimparQRCode.Click += new System.EventHandler(this.btnLimparQRCode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.btnLimparQRCode);
            this.Controls.Add(this.btnGerarQRCode);
            this.Controls.Add(this.txtQRCode);
            this.Controls.Add(this.picQRCode);
            this.Controls.Add(this.lblQRCode);
            this.Name = "Form1";
            this.Text = "Gerador QR Code";
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQRCode;
        private System.Windows.Forms.PictureBox picQRCode;
        private System.Windows.Forms.TextBox txtQRCode;
        private System.Windows.Forms.Button btnGerarQRCode;
        private System.Windows.Forms.Button btnLimparQRCode;
    }
}

