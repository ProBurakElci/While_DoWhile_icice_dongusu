namespace _1_While_DoWhile
{
    partial class Form1
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
            this.btnWhileDongusu = new System.Windows.Forms.Button();
            this.btnDoWhileDongusu = new System.Windows.Forms.Button();
            this.btnIcIceDongu = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnWhileDongusu
            // 
            this.btnWhileDongusu.Location = new System.Drawing.Point(16, 32);
            this.btnWhileDongusu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWhileDongusu.Name = "btnWhileDongusu";
            this.btnWhileDongusu.Size = new System.Drawing.Size(144, 26);
            this.btnWhileDongusu.TabIndex = 0;
            this.btnWhileDongusu.Text = "WHILE DONGUSU";
            this.btnWhileDongusu.UseVisualStyleBackColor = true;
            this.btnWhileDongusu.Click += new System.EventHandler(this.btnWhileDongusu_Click);
            // 
            // btnDoWhileDongusu
            // 
            this.btnDoWhileDongusu.Location = new System.Drawing.Point(16, 81);
            this.btnDoWhileDongusu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDoWhileDongusu.Name = "btnDoWhileDongusu";
            this.btnDoWhileDongusu.Size = new System.Drawing.Size(144, 33);
            this.btnDoWhileDongusu.TabIndex = 1;
            this.btnDoWhileDongusu.Text = "DO WHİLE DÖNGÜSÜ";
            this.btnDoWhileDongusu.UseVisualStyleBackColor = true;
            this.btnDoWhileDongusu.Click += new System.EventHandler(this.btnDoWhileDongusu_Click);
            // 
            // btnIcIceDongu
            // 
            this.btnIcIceDongu.Location = new System.Drawing.Point(16, 133);
            this.btnIcIceDongu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIcIceDongu.Name = "btnIcIceDongu";
            this.btnIcIceDongu.Size = new System.Drawing.Size(144, 28);
            this.btnIcIceDongu.TabIndex = 2;
            this.btnIcIceDongu.Text = "İÇ İÇE DÖNGÜ";
            this.btnIcIceDongu.UseVisualStyleBackColor = true;
            this.btnIcIceDongu.Click += new System.EventHandler(this.btnIcIceDongu_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 190);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 116);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnIcIceDongu);
            this.Controls.Add(this.btnDoWhileDongusu);
            this.Controls.Add(this.btnWhileDongusu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWhileDongusu;
        private System.Windows.Forms.Button btnDoWhileDongusu;
        private System.Windows.Forms.Button btnIcIceDongu;
        private System.Windows.Forms.ListBox listBox1;
    }
}

