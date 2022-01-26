
namespace PiedraPapelTijera
{
    partial class Form_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_piedra = new System.Windows.Forms.Button();
            this.btn_papel = new System.Windows.Forms.Button();
            this.btn_tijera = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_eleccionBoti = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenid@";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(320, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // btn_piedra
            // 
            this.btn_piedra.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_piedra.Location = new System.Drawing.Point(66, 187);
            this.btn_piedra.Name = "btn_piedra";
            this.btn_piedra.Size = new System.Drawing.Size(124, 101);
            this.btn_piedra.TabIndex = 2;
            this.btn_piedra.Text = "Piedra";
            this.btn_piedra.UseVisualStyleBackColor = false;
            this.btn_piedra.Click += new System.EventHandler(this.btn_piedra_Click);
            // 
            // btn_papel
            // 
            this.btn_papel.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_papel.Location = new System.Drawing.Point(253, 187);
            this.btn_papel.Name = "btn_papel";
            this.btn_papel.Size = new System.Drawing.Size(124, 101);
            this.btn_papel.TabIndex = 3;
            this.btn_papel.Text = "Papel";
            this.btn_papel.UseVisualStyleBackColor = false;
            this.btn_papel.Click += new System.EventHandler(this.btn_papel_Click);
            // 
            // btn_tijera
            // 
            this.btn_tijera.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_tijera.Location = new System.Drawing.Point(437, 187);
            this.btn_tijera.Name = "btn_tijera";
            this.btn_tijera.Size = new System.Drawing.Size(124, 101);
            this.btn_tijera.TabIndex = 4;
            this.btn_tijera.Text = "Tijera";
            this.btn_tijera.UseVisualStyleBackColor = false;
            this.btn_tijera.Click += new System.EventHandler(this.btn_tijera_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(184, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Elegi una opcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Boti eligio";
            // 
            // lbl_eleccionBoti
            // 
            this.lbl_eleccionBoti.AutoSize = true;
            this.lbl_eleccionBoti.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_eleccionBoti.Location = new System.Drawing.Point(276, 363);
            this.lbl_eleccionBoti.Name = "lbl_eleccionBoti";
            this.lbl_eleccionBoti.Size = new System.Drawing.Size(101, 34);
            this.lbl_eleccionBoti.TabIndex = 7;
            this.lbl_eleccionBoti.Text = "label5";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_resultado.Location = new System.Drawing.Point(460, 363);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(101, 34);
            this.lbl_resultado.TabIndex = 8;
            this.lbl_resultado.Text = "label6";
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_eleccionBoti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_tijera);
            this.Controls.Add(this.btn_papel);
            this.Controls.Add(this.btn_piedra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Principal";
            this.Text = ".:. Juego .:.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_piedra;
        private System.Windows.Forms.Button btn_papel;
        private System.Windows.Forms.Button btn_tijera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_eleccionBoti;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

