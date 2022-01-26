
namespace PiedraPapelTijera
{
    partial class Form_ingresoNombre
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
            this.button1_ok = new System.Windows.Forms.Button();
            this.button2_cancel = new System.Windows.Forms.Button();
            this.textBox1_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_ok
            // 
            this.button1_ok.Location = new System.Drawing.Point(67, 193);
            this.button1_ok.Name = "button1_ok";
            this.button1_ok.Size = new System.Drawing.Size(75, 71);
            this.button1_ok.TabIndex = 0;
            this.button1_ok.Text = "OK";
            this.button1_ok.UseVisualStyleBackColor = true;
            this.button1_ok.Click += new System.EventHandler(this.button1_ok_Click);
            // 
            // button2_cancel
            // 
            this.button2_cancel.Location = new System.Drawing.Point(216, 193);
            this.button2_cancel.Name = "button2_cancel";
            this.button2_cancel.Size = new System.Drawing.Size(75, 71);
            this.button2_cancel.TabIndex = 1;
            this.button2_cancel.Text = "Salir del juego";
            this.button2_cancel.UseVisualStyleBackColor = true;
            this.button2_cancel.Click += new System.EventHandler(this.button2_cancel_Click);
            // 
            // textBox1_nombre
            // 
            this.textBox1_nombre.Location = new System.Drawing.Point(67, 103);
            this.textBox1_nombre.Name = "textBox1_nombre";
            this.textBox1_nombre.Size = new System.Drawing.Size(224, 23);
            this.textBox1_nombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresa tu nombre";
            // 
            // Form_ingresoNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(369, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_nombre);
            this.Controls.Add(this.button2_cancel);
            this.Controls.Add(this.button1_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_ingresoNombre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresa tu nombre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_ok;
        private System.Windows.Forms.Button button2_cancel;
        private System.Windows.Forms.TextBox textBox1_nombre;
        private System.Windows.Forms.Label label1;
    }
}