namespace EP3_Agrawala
{
    partial class frmMovimento
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
            this.lblTrem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTrem
            // 
            this.lblTrem.AutoSize = true;
            this.lblTrem.Location = new System.Drawing.Point(178, 51);
            this.lblTrem.Name = "lblTrem";
            this.lblTrem.Size = new System.Drawing.Size(65, 13);
            this.lblTrem.TabIndex = 0;
            this.lblTrem.Text = "ABCDEFGH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recebendo mensagens através das portas UDP ... até ...";
            // 
            // frmMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 117);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTrem);
            this.Name = "frmMovimento";
            this.Text = "Processo Trem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrem;
        private System.Windows.Forms.Label label1;
    }
}