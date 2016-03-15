namespace EP3_Agrawala
{
    partial class frmProcesso
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
            this.btnIniciarControle = new System.Windows.Forms.Button();
            this.btnReiniciarMovimento = new System.Windows.Forms.Button();
            this.btnLiberarControle = new System.Windows.Forms.Button();
            this.btnPausarMovimento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRepliesDeferidos = new System.Windows.Forms.Label();
            this.lblRepliesNaoRecebidos = new System.Windows.Forms.Label();
            this.lblSecao = new System.Windows.Forms.Label();
            this.lblSeqValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciarControle
            // 
            this.btnIniciarControle.Location = new System.Drawing.Point(37, 13);
            this.btnIniciarControle.Name = "btnIniciarControle";
            this.btnIniciarControle.Size = new System.Drawing.Size(117, 23);
            this.btnIniciarControle.TabIndex = 0;
            this.btnIniciarControle.Text = "Iniciar Controle";
            this.btnIniciarControle.UseVisualStyleBackColor = true;
            this.btnIniciarControle.Click += new System.EventHandler(this.btnIniciarControle_Click);
            // 
            // btnReiniciarMovimento
            // 
            this.btnReiniciarMovimento.Enabled = false;
            this.btnReiniciarMovimento.Location = new System.Drawing.Point(37, 93);
            this.btnReiniciarMovimento.Name = "btnReiniciarMovimento";
            this.btnReiniciarMovimento.Size = new System.Drawing.Size(117, 23);
            this.btnReiniciarMovimento.TabIndex = 1;
            this.btnReiniciarMovimento.Text = "Reiniciar Movimento";
            this.btnReiniciarMovimento.UseVisualStyleBackColor = true;
            this.btnReiniciarMovimento.Click += new System.EventHandler(this.btnReiniciarMovimento_Click);
            // 
            // btnLiberarControle
            // 
            this.btnLiberarControle.Enabled = false;
            this.btnLiberarControle.Location = new System.Drawing.Point(37, 133);
            this.btnLiberarControle.Name = "btnLiberarControle";
            this.btnLiberarControle.Size = new System.Drawing.Size(117, 23);
            this.btnLiberarControle.TabIndex = 2;
            this.btnLiberarControle.Text = "Liberar Controle";
            this.btnLiberarControle.UseVisualStyleBackColor = true;
            this.btnLiberarControle.Click += new System.EventHandler(this.btnLiberarControle_Click);
            // 
            // btnPausarMovimento
            // 
            this.btnPausarMovimento.Enabled = false;
            this.btnPausarMovimento.Location = new System.Drawing.Point(37, 53);
            this.btnPausarMovimento.Name = "btnPausarMovimento";
            this.btnPausarMovimento.Size = new System.Drawing.Size(117, 23);
            this.btnPausarMovimento.TabIndex = 3;
            this.btnPausarMovimento.Text = "Pausar Movimento";
            this.btnPausarMovimento.UseVisualStyleBackColor = true;
            this.btnPausarMovimento.Click += new System.EventHandler(this.btnPausarMovimento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sequência Local/Maior Ext:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seção crítica requisitada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Replies ainda não recebidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Replies deferidos:";
            // 
            // lblRepliesDeferidos
            // 
            this.lblRepliesDeferidos.AutoSize = true;
            this.lblRepliesDeferidos.Location = new System.Drawing.Point(102, 261);
            this.lblRepliesDeferidos.Name = "lblRepliesDeferidos";
            this.lblRepliesDeferidos.Size = new System.Drawing.Size(31, 13);
            this.lblRepliesDeferidos.TabIndex = 11;
            this.lblRepliesDeferidos.Text = "0 0 0";
            // 
            // lblRepliesNaoRecebidos
            // 
            this.lblRepliesNaoRecebidos.AutoSize = true;
            this.lblRepliesNaoRecebidos.Location = new System.Drawing.Point(155, 235);
            this.lblRepliesNaoRecebidos.Name = "lblRepliesNaoRecebidos";
            this.lblRepliesNaoRecebidos.Size = new System.Drawing.Size(13, 13);
            this.lblRepliesNaoRecebidos.TabIndex = 10;
            this.lblRepliesNaoRecebidos.Text = "0";
            // 
            // lblSecao
            // 
            this.lblSecao.AutoSize = true;
            this.lblSecao.Location = new System.Drawing.Point(139, 209);
            this.lblSecao.Name = "lblSecao";
            this.lblSecao.Size = new System.Drawing.Size(27, 13);
            this.lblSecao.TabIndex = 9;
            this.lblSecao.Text = "Não";
            // 
            // lblSeqValor
            // 
            this.lblSeqValor.AutoSize = true;
            this.lblSeqValor.Location = new System.Drawing.Point(151, 183);
            this.lblSeqValor.Name = "lblSeqValor";
            this.lblSeqValor.Size = new System.Drawing.Size(24, 13);
            this.lblSeqValor.TabIndex = 8;
            this.lblSeqValor.Text = "0/0";
            // 
            // frmProcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 289);
            this.Controls.Add(this.lblRepliesDeferidos);
            this.Controls.Add(this.lblRepliesNaoRecebidos);
            this.Controls.Add(this.lblSecao);
            this.Controls.Add(this.lblSeqValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPausarMovimento);
            this.Controls.Add(this.btnLiberarControle);
            this.Controls.Add(this.btnReiniciarMovimento);
            this.Controls.Add(this.btnIniciarControle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcesso";
            this.Text = "frmProcesso";
            this.Load += new System.EventHandler(this.frmProcesso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarControle;
        private System.Windows.Forms.Button btnReiniciarMovimento;
        private System.Windows.Forms.Button btnLiberarControle;
        private System.Windows.Forms.Button btnPausarMovimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRepliesDeferidos;
        private System.Windows.Forms.Label lblRepliesNaoRecebidos;
        private System.Windows.Forms.Label lblSecao;
        private System.Windows.Forms.Label lblSeqValor;
    }
}