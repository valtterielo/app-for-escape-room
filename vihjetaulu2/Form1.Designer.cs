using System;

namespace vihjetaulu2
{
    partial class Tulossivu
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
            this.Vihje = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Vihje
            // 
            this.Vihje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vihje.Location = new System.Drawing.Point(22, 13);
            this.Vihje.Margin = new System.Windows.Forms.Padding(4);
            this.Vihje.Multiline = true;
            this.Vihje.Name = "Vihje";
            this.Vihje.ReadOnly = true;
            this.Vihje.Size = new System.Drawing.Size(762, 437);
            this.Vihje.TabIndex = 2;
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Location = new System.Drawing.Point(350, 457);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(117, 52);
            this.ok.TabIndex = 3;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // Tulossivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(810, 519);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.Vihje);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tulossivu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     

        #endregion
        private System.Windows.Forms.Button ok;
        public System.Windows.Forms.TextBox Vihje;
    }
}

