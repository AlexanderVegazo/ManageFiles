namespace ManageFiles
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
            this.lblRuta = new System.Windows.Forms.Label();
            this.btnCrearArchivo = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnRuta = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(25, 28);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(30, 13);
            this.lblRuta.TabIndex = 0;
            this.lblRuta.Text = "Ruta";
            this.lblRuta.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCrearArchivo
            // 
            this.btnCrearArchivo.Location = new System.Drawing.Point(274, 63);
            this.btnCrearArchivo.Name = "btnCrearArchivo";
            this.btnCrearArchivo.Size = new System.Drawing.Size(97, 23);
            this.btnCrearArchivo.TabIndex = 1;
            this.btnCrearArchivo.Text = "Crear archivo";
            this.btnCrearArchivo.UseVisualStyleBackColor = true;
            this.btnCrearArchivo.Click += new System.EventHandler(this.btnCrearArchivo_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(67, 28);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(222, 20);
            this.txtRuta.TabIndex = 2;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 63);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(172, 127);
            this.txtContent.TabIndex = 3;
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(296, 26);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(75, 23);
            this.btnRuta.TabIndex = 4;
            this.btnRuta.Text = "Guardar en";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 246);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnCrearArchivo);
            this.Controls.Add(this.lblRuta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Button btnCrearArchivo;
        private System.Windows.Forms.TextBox txtRuta;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtContent;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

