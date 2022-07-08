namespace Generador_Lorem_Ipsum
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblLetrasTotales = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblContOracioness = new System.Windows.Forms.Label();
            this.lblContParrafos = new System.Windows.Forms.Label();
            this.lblContPalabras = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPalabras = new System.Windows.Forms.Label();
            this.bttGenerar = new System.Windows.Forms.Button();
            this.txtContainer = new System.Windows.Forms.TextBox();
            this.lblContainer = new System.Windows.Forms.Label();
            this.rdoPalabras = new System.Windows.Forms.RadioButton();
            this.rdoParrafos = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPizarra = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.acercaDeToolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(588, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.acercaDeToolStripMenuItem.Text = "Opciones";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem2
            // 
            this.acercaDeToolStripMenuItem2.Name = "acercaDeToolStripMenuItem2";
            this.acercaDeToolStripMenuItem2.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem2.Text = "Acerca de";
            this.acercaDeToolStripMenuItem2.Click += new System.EventHandler(this.acercaDeToolStripMenuItem2_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblLetrasTotales);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.lblContOracioness);
            this.splitContainer1.Panel1.Controls.Add(this.lblContParrafos);
            this.splitContainer1.Panel1.Controls.Add(this.lblContPalabras);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.lblPalabras);
            this.splitContainer1.Panel1.Controls.Add(this.bttGenerar);
            this.splitContainer1.Panel1.Controls.Add(this.txtContainer);
            this.splitContainer1.Panel1.Controls.Add(this.lblContainer);
            this.splitContainer1.Panel1.Controls.Add(this.rdoPalabras);
            this.splitContainer1.Panel1.Controls.Add(this.rdoParrafos);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.txtPizarra);
            this.splitContainer1.Size = new System.Drawing.Size(588, 342);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.TabIndex = 3;
            // 
            // lblLetrasTotales
            // 
            this.lblLetrasTotales.AutoSize = true;
            this.lblLetrasTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetrasTotales.Location = new System.Drawing.Point(118, 258);
            this.lblLetrasTotales.Name = "lblLetrasTotales";
            this.lblLetrasTotales.Size = new System.Drawing.Size(14, 13);
            this.lblLetrasTotales.TabIndex = 15;
            this.lblLetrasTotales.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "LETRAS TOTALES:";
            // 
            // lblContOracioness
            // 
            this.lblContOracioness.AutoSize = true;
            this.lblContOracioness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContOracioness.Location = new System.Drawing.Point(171, 232);
            this.lblContOracioness.Name = "lblContOracioness";
            this.lblContOracioness.Size = new System.Drawing.Size(14, 13);
            this.lblContOracioness.TabIndex = 13;
            this.lblContOracioness.Text = "0";
            // 
            // lblContParrafos
            // 
            this.lblContParrafos.AutoSize = true;
            this.lblContParrafos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContParrafos.Location = new System.Drawing.Point(171, 187);
            this.lblContParrafos.Name = "lblContParrafos";
            this.lblContParrafos.Size = new System.Drawing.Size(14, 13);
            this.lblContParrafos.TabIndex = 12;
            this.lblContParrafos.Text = "0";
            // 
            // lblContPalabras
            // 
            this.lblContPalabras.AutoSize = true;
            this.lblContPalabras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContPalabras.Location = new System.Drawing.Point(166, 209);
            this.lblContPalabras.Name = "lblContPalabras";
            this.lblContPalabras.Size = new System.Drawing.Size(14, 13);
            this.lblContPalabras.TabIndex = 11;
            this.lblContPalabras.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "CANTIDAD DE PARRAFOS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "CANTIDAD DE ORACIONES:";
            // 
            // lblPalabras
            // 
            this.lblPalabras.AutoSize = true;
            this.lblPalabras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabras.Location = new System.Drawing.Point(3, 209);
            this.lblPalabras.Name = "lblPalabras";
            this.lblPalabras.Size = new System.Drawing.Size(167, 13);
            this.lblPalabras.TabIndex = 8;
            this.lblPalabras.Text = "CANTIDAD DE PALABRAS: ";
            // 
            // bttGenerar
            // 
            this.bttGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttGenerar.Location = new System.Drawing.Point(12, 132);
            this.bttGenerar.Name = "bttGenerar";
            this.bttGenerar.Size = new System.Drawing.Size(159, 34);
            this.bttGenerar.TabIndex = 7;
            this.bttGenerar.Text = "GENERAR";
            this.bttGenerar.UseVisualStyleBackColor = true;
            this.bttGenerar.Click += new System.EventHandler(this.bttGenerar_Click);
            // 
            // txtContainer
            // 
            this.txtContainer.Location = new System.Drawing.Point(49, 90);
            this.txtContainer.Name = "txtContainer";
            this.txtContainer.Size = new System.Drawing.Size(83, 20);
            this.txtContainer.TabIndex = 4;
            this.txtContainer.TextChanged += new System.EventHandler(this.txtContainer_TextChanged);
            // 
            // lblContainer
            // 
            this.lblContainer.AutoSize = true;
            this.lblContainer.Location = new System.Drawing.Point(34, 74);
            this.lblContainer.Name = "lblContainer";
            this.lblContainer.Size = new System.Drawing.Size(70, 13);
            this.lblContainer.TabIndex = 3;
            this.lblContainer.Text = "Cantidad de: ";
            // 
            // rdoPalabras
            // 
            this.rdoPalabras.AutoSize = true;
            this.rdoPalabras.Location = new System.Drawing.Point(105, 36);
            this.rdoPalabras.Name = "rdoPalabras";
            this.rdoPalabras.Size = new System.Drawing.Size(66, 17);
            this.rdoPalabras.TabIndex = 2;
            this.rdoPalabras.Text = "Palabras";
            this.rdoPalabras.UseVisualStyleBackColor = true;
            this.rdoPalabras.CheckedChanged += new System.EventHandler(this.rdoPalabras_CheckedChanged);
            // 
            // rdoParrafos
            // 
            this.rdoParrafos.AutoSize = true;
            this.rdoParrafos.Location = new System.Drawing.Point(12, 36);
            this.rdoParrafos.Name = "rdoParrafos";
            this.rdoParrafos.Size = new System.Drawing.Size(64, 17);
            this.rdoParrafos.TabIndex = 1;
            this.rdoParrafos.Text = "Parrafos";
            this.rdoParrafos.UseVisualStyleBackColor = true;
            this.rdoParrafos.CheckedChanged += new System.EventHandler(this.rdoParrafos_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generar";
            // 
            // txtPizarra
            // 
            this.txtPizarra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPizarra.Location = new System.Drawing.Point(0, 0);
            this.txtPizarra.Multiline = true;
            this.txtPizarra.Name = "txtPizarra";
            this.txtPizarra.ReadOnly = true;
            this.txtPizarra.Size = new System.Drawing.Size(379, 340);
            this.txtPizarra.TabIndex = 0;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivos txt (*.txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 366);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(604, 405);
            this.Name = "Form1";
            this.Text = "Generador Lorem Ipsum";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton rdoPalabras;
        private System.Windows.Forms.RadioButton rdoParrafos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPizarra;
        private System.Windows.Forms.TextBox txtContainer;
        private System.Windows.Forms.Label lblContainer;
        private System.Windows.Forms.Button bttGenerar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPalabras;
        private System.Windows.Forms.Label lblContPalabras;
        private System.Windows.Forms.Label lblContOracioness;
        private System.Windows.Forms.Label lblContParrafos;
        private System.Windows.Forms.Label lblLetrasTotales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem2;
    }
}

