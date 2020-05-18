namespace TicTacToe
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.T1 = new System.Windows.Forms.TextBox();
            this.T2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno prvního hráče: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(11, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jméno druhého hráče:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(269, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hrát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // T1
            // 
            this.T1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.T1.Location = new System.Drawing.Point(269, 176);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(332, 32);
            this.T1.TabIndex = 8;
            this.T1.TextChanged += new System.EventHandler(this.T1_TextChanged);
            // 
            // T2
            // 
            this.T2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.T2.Location = new System.Drawing.Point(269, 232);
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(332, 32);
            this.T2.TabIndex = 9;
            this.T2.TextChanged += new System.EventHandler(this.T2_TextChanged);
            this.T2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(9, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(695, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pokud chcete hrát proti počítači tak napište do DRUHÉHO Textboxu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(265, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 48);
            this.label4.TabIndex = 11;
            this.label4.Text = "Easy , Mid , Hard\r\n\r\n";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.T2);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(722, 489);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox T1;
        public System.Windows.Forms.TextBox T2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}