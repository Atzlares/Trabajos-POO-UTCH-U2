namespace Login
{
    partial class Detalles
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
            this.cajaDeLista = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cajaDeLista
            // 
            this.cajaDeLista.FormattingEnabled = true;
            this.cajaDeLista.Location = new System.Drawing.Point(92, 27);
            this.cajaDeLista.Name = "cajaDeLista";
            this.cajaDeLista.Size = new System.Drawing.Size(470, 303);
            this.cajaDeLista.TabIndex = 0;
            this.cajaDeLista.SelectedIndexChanged += new System.EventHandler(this.cajaDeLista_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mostrar lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Detalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cajaDeLista);
            this.Name = "Detalles";
            this.Text = "Detalles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox cajaDeLista;
        private System.Windows.Forms.Button button1;
    }
}