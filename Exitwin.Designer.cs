
namespace KuzProject
{
    partial class Exitwin
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
            this.confex = new System.Windows.Forms.Button();
            this.cancex = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confex
            // 
            this.confex.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confex.Location = new System.Drawing.Point(12, 70);
            this.confex.Name = "confex";
            this.confex.Size = new System.Drawing.Size(168, 65);
            this.confex.TabIndex = 0;
            this.confex.Text = "Да";
            this.confex.UseVisualStyleBackColor = true;
            this.confex.Click += new System.EventHandler(this.confex_Click);
            // 
            // cancex
            // 
            this.cancex.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancex.Location = new System.Drawing.Point(189, 70);
            this.cancex.Name = "cancex";
            this.cancex.Size = new System.Drawing.Size(168, 65);
            this.cancex.TabIndex = 1;
            this.cancex.Text = "Нет";
            this.cancex.UseVisualStyleBackColor = true;
            this.cancex.Click += new System.EventHandler(this.cancex_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вы точно хотите выйти?";
            // 
            // Exitwin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 150);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancex);
            this.Controls.Add(this.confex);
            this.Name = "Exitwin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exitwin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button confex;
        private System.Windows.Forms.Button cancex;
        private System.Windows.Forms.Label label1;
    }
}