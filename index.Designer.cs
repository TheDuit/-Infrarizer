namespace Infrarizer
{
    partial class frmIndex
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRede = new System.Windows.Forms.Button();
            this.btnInstaller = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRede
            // 
            this.btnRede.Location = new System.Drawing.Point(25, 24);
            this.btnRede.Name = "btnRede";
            this.btnRede.Size = new System.Drawing.Size(141, 64);
            this.btnRede.TabIndex = 0;
            this.btnRede.Text = "Configuraçoes de rede";
            this.btnRede.UseVisualStyleBackColor = true;
            this.btnRede.Click += new System.EventHandler(this.BtnRede_Click);
            // 
            // btnInstaller
            // 
            this.btnInstaller.Location = new System.Drawing.Point(25, 94);
            this.btnInstaller.Name = "btnInstaller";
            this.btnInstaller.Size = new System.Drawing.Size(141, 64);
            this.btnInstaller.TabIndex = 1;
            this.btnInstaller.Text = "Instaladores";
            this.btnInstaller.UseVisualStyleBackColor = true;
            this.btnInstaller.Click += new System.EventHandler(this.btnInstaller_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnInstaller);
            this.Controls.Add(this.btnRede);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIndex";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Infrarizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRede;
        private System.Windows.Forms.Button btnInstaller;
    }
}

