namespace Verifica_Digitale
{
    partial class Nome_e_descrizione
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
            this.Nome = new System.Windows.Forms.TextBox();
            this.Descrizione = new System.Windows.Forms.TextBox();
            this.Invia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(12, 12);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(391, 38);
            this.Nome.TabIndex = 2;
            // 
            // Descrizione
            // 
            this.Descrizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descrizione.Location = new System.Drawing.Point(12, 80);
            this.Descrizione.Multiline = true;
            this.Descrizione.Name = "Descrizione";
            this.Descrizione.Size = new System.Drawing.Size(741, 422);
            this.Descrizione.TabIndex = 3;
            // 
            // Invia
            // 
            this.Invia.Location = new System.Drawing.Point(465, 12);
            this.Invia.Name = "Invia";
            this.Invia.Size = new System.Drawing.Size(75, 38);
            this.Invia.TabIndex = 4;
            this.Invia.Text = "Invia";
            this.Invia.UseVisualStyleBackColor = true;
            this.Invia.Click += new System.EventHandler(this.Invia_Click);
            // 
            // Nome_e_descrizione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(765, 514);
            this.Controls.Add(this.Invia);
            this.Controls.Add(this.Descrizione);
            this.Controls.Add(this.Nome);
            this.Name = "Nome_e_descrizione";
            this.Text = "Nome_e_descrizione";
            this.Load += new System.EventHandler(this.Nome_e_descrizione_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Nome_e_descrizione_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Descrizione;
        private System.Windows.Forms.Button Invia;
    }
}