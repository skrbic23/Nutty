
namespace Nutty2._0
{
    partial class Racun
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
            this.Pica = new System.Windows.Forms.CheckedListBox();
            this.Jelo = new System.Windows.Forms.CheckedListBox();
            this.Desert = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pica
            // 
            this.Pica.FormattingEnabled = true;
            this.Pica.Location = new System.Drawing.Point(46, 36);
            this.Pica.Name = "Pica";
            this.Pica.Size = new System.Drawing.Size(180, 169);
            this.Pica.TabIndex = 0;
            // 
            // Jelo
            // 
            this.Jelo.FormattingEnabled = true;
            this.Jelo.Location = new System.Drawing.Point(272, 36);
            this.Jelo.Name = "Jelo";
            this.Jelo.Size = new System.Drawing.Size(180, 169);
            this.Jelo.TabIndex = 1;
            // 
            // Desert
            // 
            this.Desert.FormattingEnabled = true;
            this.Desert.Location = new System.Drawing.Point(495, 36);
            this.Desert.Name = "Desert";
            this.Desert.Size = new System.Drawing.Size(180, 169);
            this.Desert.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Stampaj racun";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Racun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Desert);
            this.Controls.Add(this.Jelo);
            this.Controls.Add(this.Pica);
            this.Name = "Racun";
            this.Text = "Racun";
            this.Load += new System.EventHandler(this.Racun_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Pica;
        private System.Windows.Forms.CheckedListBox Jelo;
        private System.Windows.Forms.CheckedListBox Desert;
        private System.Windows.Forms.Button button1;
    }
}