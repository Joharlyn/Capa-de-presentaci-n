namespace Presentación_Proyecto_I
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
            this.btn_paintApp = new System.Windows.Forms.Button();
            this.btn_calculator = new System.Windows.Forms.Button();
            this.btn_textEditor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_paintApp
            // 
            this.btn_paintApp.Location = new System.Drawing.Point(53, 88);
            this.btn_paintApp.Name = "btn_paintApp";
            this.btn_paintApp.Size = new System.Drawing.Size(178, 51);
            this.btn_paintApp.TabIndex = 0;
            this.btn_paintApp.Text = "Paint";
            this.btn_paintApp.UseVisualStyleBackColor = true;
            this.btn_paintApp.Click += new System.EventHandler(this.btn_paintApp_Click);
            // 
            // btn_calculator
            // 
            this.btn_calculator.Location = new System.Drawing.Point(53, 169);
            this.btn_calculator.Name = "btn_calculator";
            this.btn_calculator.Size = new System.Drawing.Size(178, 51);
            this.btn_calculator.TabIndex = 1;
            this.btn_calculator.Text = "Calculadora";
            this.btn_calculator.UseVisualStyleBackColor = true;
            this.btn_calculator.Click += new System.EventHandler(this.btn_calculator_Click);
            // 
            // btn_textEditor
            // 
            this.btn_textEditor.Location = new System.Drawing.Point(53, 250);
            this.btn_textEditor.Name = "btn_textEditor";
            this.btn_textEditor.Size = new System.Drawing.Size(178, 51);
            this.btn_textEditor.TabIndex = 2;
            this.btn_textEditor.Text = "Editor de texto";
            this.btn_textEditor.UseVisualStyleBackColor = true;
            this.btn_textEditor.Click += new System.EventHandler(this.btn_textEditor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Elige el programa que deseas abrir:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_textEditor);
            this.Controls.Add(this.btn_calculator);
            this.Controls.Add(this.btn_paintApp);
            this.Name = "Form1";
            this.Text = "Menú de selección";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_paintApp;
        private System.Windows.Forms.Button btn_calculator;
        private System.Windows.Forms.Button btn_textEditor;
        private System.Windows.Forms.Label label1;
    }
}

