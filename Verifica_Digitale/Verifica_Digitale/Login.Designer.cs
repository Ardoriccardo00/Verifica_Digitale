namespace Verifica_Digitale
{
    partial class Login
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selezionaUnoStudenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colomboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insegnanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selezionaUnoStudenteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.insegnanteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(210, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selezionaUnoStudenteToolStripMenuItem
            // 
            this.selezionaUnoStudenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colomboToolStripMenuItem,
            this.altroToolStripMenuItem});
            this.selezionaUnoStudenteToolStripMenuItem.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selezionaUnoStudenteToolStripMenuItem.Name = "selezionaUnoStudenteToolStripMenuItem";
            this.selezionaUnoStudenteToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.selezionaUnoStudenteToolStripMenuItem.Text = "Studente";
            this.selezionaUnoStudenteToolStripMenuItem.Click += new System.EventHandler(this.selezionaUnoStudenteToolStripMenuItem_Click);
            // 
            // colomboToolStripMenuItem
            // 
            this.colomboToolStripMenuItem.Name = "colomboToolStripMenuItem";
            this.colomboToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colomboToolStripMenuItem.Text = "Colombo";
            this.colomboToolStripMenuItem.Click += new System.EventHandler(this.colomboToolStripMenuItem_Click);
            // 
            // altroToolStripMenuItem
            // 
            this.altroToolStripMenuItem.Name = "altroToolStripMenuItem";
            this.altroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altroToolStripMenuItem.Text = "Altro";
            this.altroToolStripMenuItem.Click += new System.EventHandler(this.altroToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // insegnanteToolStripMenuItem
            // 
            this.insegnanteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.insegnanteToolStripMenuItem.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insegnanteToolStripMenuItem.Name = "insegnanteToolStripMenuItem";
            this.insegnanteToolStripMenuItem.Size = new System.Drawing.Size(87, 21);
            this.insegnanteToolStripMenuItem.Text = "Insegnante";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Accedi come...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 251);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Login";
            this.Text = "Login";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selezionaUnoStudenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colomboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem altroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insegnanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}