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
            this.colomboToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insegnanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Accesso = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(210, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selezionaUnoStudenteToolStripMenuItem
            // 
            this.selezionaUnoStudenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colomboToolStripMenuItem,
            this.altroToolStripMenuItem,
            this.colomboToolStripMenuItem1});
            this.selezionaUnoStudenteToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selezionaUnoStudenteToolStripMenuItem.Name = "selezionaUnoStudenteToolStripMenuItem";
            this.selezionaUnoStudenteToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.selezionaUnoStudenteToolStripMenuItem.Text = "Studente";
            this.selezionaUnoStudenteToolStripMenuItem.Click += new System.EventHandler(this.selezionaUnoStudenteToolStripMenuItem_Click);
            // 
            // colomboToolStripMenuItem
            // 
            this.colomboToolStripMenuItem.Name = "colomboToolStripMenuItem";
            this.colomboToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.colomboToolStripMenuItem.Text = "Colombo Test";
            this.colomboToolStripMenuItem.Click += new System.EventHandler(this.colomboToolStripMenuItem_Click);
            // 
            // altroToolStripMenuItem
            // 
            this.altroToolStripMenuItem.Name = "altroToolStripMenuItem";
            this.altroToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.altroToolStripMenuItem.Text = "Altro";
            this.altroToolStripMenuItem.Click += new System.EventHandler(this.altroToolStripMenuItem_Click);
            // 
            // colomboToolStripMenuItem1
            // 
            this.colomboToolStripMenuItem1.Name = "colomboToolStripMenuItem1";
            this.colomboToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.colomboToolStripMenuItem1.Text = "Colombo";
            this.colomboToolStripMenuItem1.Click += new System.EventHandler(this.colomboToolStripMenuItem1_Click);
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
            this.insegnanteToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insegnanteToolStripMenuItem.Name = "insegnanteToolStripMenuItem";
            this.insegnanteToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.insegnanteToolStripMenuItem.Text = "Insegnante";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Accedi come...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Accesso
            // 
            this.Accesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accesso.Location = new System.Drawing.Point(56, 120);
            this.Accesso.Name = "Accesso";
            this.Accesso.Size = new System.Drawing.Size(85, 54);
            this.Accesso.TabIndex = 3;
            this.Accesso.Text = "Accedi";
            this.Accesso.UseVisualStyleBackColor = true;
            this.Accesso.Visible = false;
            this.Accesso.Click += new System.EventHandler(this.Accesso_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(12, 80);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(186, 20);
            this.Password.TabIndex = 4;
            this.Password.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(210, 251);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Accesso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
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
        private System.Windows.Forms.Button Accesso;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.ToolStripMenuItem colomboToolStripMenuItem1;
    }
}