
namespace CANCIONES
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wpm = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCancion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.wpm)).BeginInit();
            this.SuspendLayout();
            // 
            // wpm
            // 
            this.wpm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wpm.Enabled = true;
            this.wpm.Location = new System.Drawing.Point(15, 85);
            this.wpm.Name = "wpm";
            this.wpm.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wpm.OcxState")));
            this.wpm.Size = new System.Drawing.Size(658, 402);
            this.wpm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELECCIONE SU CANCION\r\n";
            // 
            // cbCancion
            // 
            this.cbCancion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCancion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCancion.FormattingEnabled = true;
            this.cbCancion.Location = new System.Drawing.Point(15, 47);
            this.cbCancion.Name = "cbCancion";
            this.cbCancion.Size = new System.Drawing.Size(655, 21);
            this.cbCancion.TabIndex = 2;
            this.cbCancion.SelectedIndexChanged += new System.EventHandler(this.cbCancion_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 501);
            this.Controls.Add(this.cbCancion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wpm);
            this.Name = "Form1";
            this.Text = "CANCIONES FAVORITAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wpm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wpm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCancion;
    }
}

