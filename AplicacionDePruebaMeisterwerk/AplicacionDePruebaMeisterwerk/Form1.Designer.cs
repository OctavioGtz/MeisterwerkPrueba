namespace AplicacionDePruebaMeisterwerk
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
            this.BTN_DameClick = new System.Windows.Forms.Button();
            this.CB_Test1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_DameClick
            // 
            this.BTN_DameClick.Location = new System.Drawing.Point(104, 137);
            this.BTN_DameClick.Name = "BTN_DameClick";
            this.BTN_DameClick.Size = new System.Drawing.Size(75, 23);
            this.BTN_DameClick.TabIndex = 0;
            this.BTN_DameClick.Text = "Este Boton";
            this.BTN_DameClick.UseVisualStyleBackColor = true;
            this.BTN_DameClick.Click += new System.EventHandler(this.BTN_DameClick_Click);
            // 
            // CB_Test1
            // 
            this.CB_Test1.AutoSize = true;
            this.CB_Test1.Location = new System.Drawing.Point(96, 102);
            this.CB_Test1.Name = "CB_Test1";
            this.CB_Test1.Size = new System.Drawing.Size(80, 17);
            this.CB_Test1.TabIndex = 1;
            this.CB_Test1.Text = "Dame Click";
            this.CB_Test1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "BTN_Rev1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CB_Test1);
            this.Controls.Add(this.BTN_DameClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_DameClick;
        private System.Windows.Forms.CheckBox CB_Test1;
        private System.Windows.Forms.Button button1;
    }
}

