namespace EP3_Agrawala
{
    partial class frmConfig
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnderecoTrem = new System.Windows.Forms.TextBox();
            this.txtEnderecoUm = new System.Windows.Forms.TextBox();
            this.txtEnderecoDois = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.ddlNumProcesso = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endereço do Trem (IP/Hostname)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço de um processo Ci (IP/Hostname)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número deste processo Ci";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Endereço do outro processo Ci (IP/Hostname)";
            // 
            // txtEnderecoTrem
            // 
            this.txtEnderecoTrem.Enabled = false;
            this.txtEnderecoTrem.Location = new System.Drawing.Point(253, 19);
            this.txtEnderecoTrem.Name = "txtEnderecoTrem";
            this.txtEnderecoTrem.Size = new System.Drawing.Size(100, 20);
            this.txtEnderecoTrem.TabIndex = 3;
            this.txtEnderecoTrem.Text = "127.0.0.1";
            // 
            // txtEnderecoUm
            // 
            this.txtEnderecoUm.Enabled = false;
            this.txtEnderecoUm.Location = new System.Drawing.Point(253, 53);
            this.txtEnderecoUm.Name = "txtEnderecoUm";
            this.txtEnderecoUm.Size = new System.Drawing.Size(100, 20);
            this.txtEnderecoUm.TabIndex = 4;
            this.txtEnderecoUm.Text = "127.0.0.1";
            // 
            // txtEnderecoDois
            // 
            this.txtEnderecoDois.Enabled = false;
            this.txtEnderecoDois.Location = new System.Drawing.Point(253, 87);
            this.txtEnderecoDois.Name = "txtEnderecoDois";
            this.txtEnderecoDois.Size = new System.Drawing.Size(100, 20);
            this.txtEnderecoDois.TabIndex = 5;
            this.txtEnderecoDois.Text = "127.0.0.1";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(29, 158);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(324, 38);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // ddlNumProcesso
            // 
            this.ddlNumProcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlNumProcesso.FormattingEnabled = true;
            this.ddlNumProcesso.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.ddlNumProcesso.Location = new System.Drawing.Point(253, 120);
            this.ddlNumProcesso.Name = "ddlNumProcesso";
            this.ddlNumProcesso.Size = new System.Drawing.Size(100, 21);
            this.ddlNumProcesso.TabIndex = 8;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 208);
            this.Controls.Add(this.ddlNumProcesso);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtEnderecoDois);
            this.Controls.Add(this.txtEnderecoUm);
            this.Controls.Add(this.txtEnderecoTrem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.Text = "Ricart Agrawala";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnderecoTrem;
        private System.Windows.Forms.TextBox txtEnderecoUm;
        private System.Windows.Forms.TextBox txtEnderecoDois;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ComboBox ddlNumProcesso;
    }
}

