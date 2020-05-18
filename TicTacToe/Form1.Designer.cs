namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nováHraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.protiHráčiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hrátProtiNěkomuJinémuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dalšíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitVýsledkyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetnoutVýsledkyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.L1 = new System.Windows.Forms.Label();
            this.L3 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.X_Vyhra = new System.Windows.Forms.Label();
            this.Remiza = new System.Windows.Forms.Label();
            this.O_Vyhra = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nováHraToolStripMenuItem,
            this.dalšíToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(368, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nováHraToolStripMenuItem
            // 
            this.nováHraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.protiHráčiToolStripMenuItem,
            this.hrátProtiNěkomuJinémuToolStripMenuItem});
            this.nováHraToolStripMenuItem.Name = "nováHraToolStripMenuItem";
            this.nováHraToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.nováHraToolStripMenuItem.Text = "Nová Hra";
            // 
            // protiHráčiToolStripMenuItem
            // 
            this.protiHráčiToolStripMenuItem.Name = "protiHráčiToolStripMenuItem";
            this.protiHráčiToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.protiHráčiToolStripMenuItem.Text = "Reset";
            this.protiHráčiToolStripMenuItem.Click += new System.EventHandler(this.protiHráčiToolStripMenuItem_Click);
            // 
            // hrátProtiNěkomuJinémuToolStripMenuItem
            // 
            this.hrátProtiNěkomuJinémuToolStripMenuItem.Name = "hrátProtiNěkomuJinémuToolStripMenuItem";
            this.hrátProtiNěkomuJinémuToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.hrátProtiNěkomuJinémuToolStripMenuItem.Text = "Hrát proti někomu jinému";
            this.hrátProtiNěkomuJinémuToolStripMenuItem.Click += new System.EventHandler(this.hrátProtiNěkomuJinémuToolStripMenuItem_Click);
            // 
            // dalšíToolStripMenuItem
            // 
            this.dalšíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uložitVýsledkyToolStripMenuItem,
            this.resetnoutVýsledkyToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.dalšíToolStripMenuItem.Name = "dalšíToolStripMenuItem";
            this.dalšíToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.dalšíToolStripMenuItem.Text = "Další";
            // 
            // uložitVýsledkyToolStripMenuItem
            // 
            this.uložitVýsledkyToolStripMenuItem.Name = "uložitVýsledkyToolStripMenuItem";
            this.uložitVýsledkyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uložitVýsledkyToolStripMenuItem.Text = "Uložit výsledky";
            this.uložitVýsledkyToolStripMenuItem.Click += new System.EventHandler(this.uložitVýsledkyToolStripMenuItem_Click);
            // 
            // resetnoutVýsledkyToolStripMenuItem
            // 
            this.resetnoutVýsledkyToolStripMenuItem.Name = "resetnoutVýsledkyToolStripMenuItem";
            this.resetnoutVýsledkyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetnoutVýsledkyToolStripMenuItem.Text = "Resetnout výsledky";
            this.resetnoutVýsledkyToolStripMenuItem.Click += new System.EventHandler(this.resetnoutVýsledkyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A1.Location = new System.Drawing.Point(12, 27);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(110, 100);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_click);
            this.A1.MouseEnter += new System.EventHandler(this.button_enter);
            this.A1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A2.Location = new System.Drawing.Point(128, 27);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(110, 100);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            this.A2.MouseEnter += new System.EventHandler(this.button_enter);
            this.A2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A3.Location = new System.Drawing.Point(244, 27);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(110, 100);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            this.A3.MouseEnter += new System.EventHandler(this.button_enter);
            this.A3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B1.Location = new System.Drawing.Point(12, 133);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(110, 100);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_click);
            this.B1.MouseEnter += new System.EventHandler(this.button_enter);
            this.B1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B2.Location = new System.Drawing.Point(128, 133);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(110, 100);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_click);
            this.B2.MouseEnter += new System.EventHandler(this.button_enter);
            this.B2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B3.Location = new System.Drawing.Point(244, 133);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(110, 100);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_click);
            this.B3.MouseEnter += new System.EventHandler(this.button_enter);
            this.B3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.C3.Location = new System.Drawing.Point(244, 239);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(110, 100);
            this.C3.TabIndex = 7;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button_click);
            this.C3.MouseEnter += new System.EventHandler(this.button_enter);
            this.C3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.C2.Location = new System.Drawing.Point(128, 239);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(110, 100);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button_click);
            this.C2.MouseEnter += new System.EventHandler(this.button_enter);
            this.C2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.C1.Location = new System.Drawing.Point(12, 239);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(110, 100);
            this.C1.TabIndex = 9;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_click);
            this.C1.MouseEnter += new System.EventHandler(this.button_enter);
            this.C1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L1.Location = new System.Drawing.Point(24, 363);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(87, 24);
            this.L1.TabIndex = 10;
            this.L1.Text = "X výhra";
            this.L1.Click += new System.EventHandler(this.label1_Click);
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L3.Location = new System.Drawing.Point(255, 363);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(89, 24);
            this.L3.TabIndex = 11;
            this.L3.Text = "O výhra";
            this.L3.TextChanged += new System.EventHandler(this.L3_TextChanged);
            this.L3.Click += new System.EventHandler(this.label2_Click);
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L2.Location = new System.Drawing.Point(141, 363);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(84, 24);
            this.L2.TabIndex = 12;
            this.L2.Text = "Remíza";
            // 
            // X_Vyhra
            // 
            this.X_Vyhra.AutoSize = true;
            this.X_Vyhra.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.X_Vyhra.Location = new System.Drawing.Point(53, 405);
            this.X_Vyhra.Name = "X_Vyhra";
            this.X_Vyhra.Size = new System.Drawing.Size(22, 24);
            this.X_Vyhra.TabIndex = 13;
            this.X_Vyhra.Text = "0";
            this.X_Vyhra.Click += new System.EventHandler(this.X_vyhra_Click);
            // 
            // Remiza
            // 
            this.Remiza.AutoSize = true;
            this.Remiza.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Remiza.Location = new System.Drawing.Point(167, 405);
            this.Remiza.Name = "Remiza";
            this.Remiza.Size = new System.Drawing.Size(22, 24);
            this.Remiza.TabIndex = 14;
            this.Remiza.Text = "0";
            // 
            // O_Vyhra
            // 
            this.O_Vyhra.AutoSize = true;
            this.O_Vyhra.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.O_Vyhra.Location = new System.Drawing.Point(286, 405);
            this.O_Vyhra.Name = "O_Vyhra";
            this.O_Vyhra.Size = new System.Drawing.Size(22, 24);
            this.O_Vyhra.TabIndex = 15;
            this.O_Vyhra.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 452);
            this.Controls.Add(this.O_Vyhra);
            this.Controls.Add(this.Remiza);
            this.Controls.Add(this.X_Vyhra);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nováHraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem protiHráčiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dalšíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložitVýsledkyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
        public System.Windows.Forms.Label L1;
        public System.Windows.Forms.Label L3;
        public System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label X_Vyhra;
        private System.Windows.Forms.Label Remiza;
        private System.Windows.Forms.Label O_Vyhra;
        private System.Windows.Forms.ToolStripMenuItem resetnoutVýsledkyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hrátProtiNěkomuJinémuToolStripMenuItem;
    }
}

