namespace WindowsFormsApp1
{
    partial class Form3
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
            this.btnEscanear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblEcuacion = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblDetectado = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEscanear
            // 
            this.btnEscanear.Image = global::WindowsFormsApp1.Properties.Resources._573deccccea38aef182e051bf6723224;
            this.btnEscanear.Location = new System.Drawing.Point(884, 22);
            this.btnEscanear.Name = "btnEscanear";
            this.btnEscanear.Size = new System.Drawing.Size(159, 72);
            this.btnEscanear.TabIndex = 1;
            this.btnEscanear.UseVisualStyleBackColor = true;
            this.btnEscanear.Click += new System.EventHandler(this.btnEscanear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(113, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(717, 318);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(884, 154);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(108, 51);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = "agregar ecuacion";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(946, 496);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(97, 59);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "atraz";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblEcuacion
            // 
            this.lblEcuacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEcuacion.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblEcuacion.Location = new System.Drawing.Point(300, 448);
            this.lblEcuacion.Name = "lblEcuacion";
            this.lblEcuacion.Size = new System.Drawing.Size(373, 107);
            this.lblEcuacion.TabIndex = 4;
            this.lblEcuacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEcuacion.Click += new System.EventHandler(this.lblEcuacion_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(884, 259);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 56);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblDetectado
            // 
            this.lblDetectado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDetectado.Location = new System.Drawing.Point(425, 354);
            this.lblDetectado.Name = "lblDetectado";
            this.lblDetectado.Size = new System.Drawing.Size(125, 59);
            this.lblDetectado.TabIndex = 6;
            this.lblDetectado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDetectado.Click += new System.EventHandler(this.lblDetectado_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(884, 338);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 49);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "LIMPIAR ECUACION";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 579);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblDetectado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblEcuacion);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnEscanear);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEscanear;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblEcuacion;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblDetectado;
        private System.Windows.Forms.Button btnLimpiar;
    }
}