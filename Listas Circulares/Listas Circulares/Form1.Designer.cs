namespace Listas_Circulares
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxNombreBase = new System.Windows.Forms.TextBox();
            this.bttnAgregarBase = new System.Windows.Forms.Button();
            this.txtBxMinutosBase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bttnCalcularRuta = new System.Windows.Forms.Button();
            this.txtBxBaseInicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxRecorrido = new System.Windows.Forms.TextBox();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.bttnAgregarInicio = new System.Windows.Forms.Button();
            this.bttnEliminarUltimo = new System.Windows.Forms.Button();
            this.bttnEliminarPrimero = new System.Windows.Forms.Button();
            this.bttnInsertarDespuesDe = new System.Windows.Forms.Button();
            this.bttnReporte = new System.Windows.Forms.Button();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtBxNombreBase
            // 
            this.txtBxNombreBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxNombreBase.Location = new System.Drawing.Point(32, 56);
            this.txtBxNombreBase.Name = "txtBxNombreBase";
            this.txtBxNombreBase.Size = new System.Drawing.Size(100, 34);
            this.txtBxNombreBase.TabIndex = 1;
            // 
            // bttnAgregarBase
            // 
            this.bttnAgregarBase.AutoSize = true;
            this.bttnAgregarBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAgregarBase.Location = new System.Drawing.Point(30, 175);
            this.bttnAgregarBase.Name = "bttnAgregarBase";
            this.bttnAgregarBase.Size = new System.Drawing.Size(170, 39);
            this.bttnAgregarBase.TabIndex = 2;
            this.bttnAgregarBase.Text = "Agregar Base";
            this.bttnAgregarBase.UseVisualStyleBackColor = true;
            this.bttnAgregarBase.Click += new System.EventHandler(this.bttnAgregarBase_Click);
            // 
            // txtBxMinutosBase
            // 
            this.txtBxMinutosBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxMinutosBase.Location = new System.Drawing.Point(32, 128);
            this.txtBxMinutosBase.Name = "txtBxMinutosBase";
            this.txtBxMinutosBase.Size = new System.Drawing.Size(100, 34);
            this.txtBxMinutosBase.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minutos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hora de Fin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hora de Inicio";
            // 
            // bttnCalcularRuta
            // 
            this.bttnCalcularRuta.AutoSize = true;
            this.bttnCalcularRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCalcularRuta.Location = new System.Drawing.Point(30, 521);
            this.bttnCalcularRuta.Name = "bttnCalcularRuta";
            this.bttnCalcularRuta.Size = new System.Drawing.Size(170, 39);
            this.bttnCalcularRuta.TabIndex = 9;
            this.bttnCalcularRuta.Text = "Recorrido";
            this.bttnCalcularRuta.UseVisualStyleBackColor = true;
            this.bttnCalcularRuta.Click += new System.EventHandler(this.bttnCalcularRuta_Click);
            // 
            // txtBxBaseInicio
            // 
            this.txtBxBaseInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxBaseInicio.Location = new System.Drawing.Point(32, 476);
            this.txtBxBaseInicio.Name = "txtBxBaseInicio";
            this.txtBxBaseInicio.Size = new System.Drawing.Size(100, 34);
            this.txtBxBaseInicio.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Base de Inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Recorrido";
            // 
            // txtBxRecorrido
            // 
            this.txtBxRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxRecorrido.Location = new System.Drawing.Point(255, 58);
            this.txtBxRecorrido.Multiline = true;
            this.txtBxRecorrido.Name = "txtBxRecorrido";
            this.txtBxRecorrido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxRecorrido.Size = new System.Drawing.Size(245, 219);
            this.txtBxRecorrido.TabIndex = 13;
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.AutoSize = true;
            this.bttnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBuscar.Location = new System.Drawing.Point(255, 296);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(170, 39);
            this.bttnBuscar.TabIndex = 14;
            this.bttnBuscar.Text = "Buscar";
            this.bttnBuscar.UseVisualStyleBackColor = true;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.AutoSize = true;
            this.bttnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEliminar.Location = new System.Drawing.Point(255, 341);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(170, 39);
            this.bttnEliminar.TabIndex = 15;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.UseVisualStyleBackColor = true;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // bttnAgregarInicio
            // 
            this.bttnAgregarInicio.AutoSize = true;
            this.bttnAgregarInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAgregarInicio.Location = new System.Drawing.Point(255, 386);
            this.bttnAgregarInicio.Name = "bttnAgregarInicio";
            this.bttnAgregarInicio.Size = new System.Drawing.Size(205, 39);
            this.bttnAgregarInicio.TabIndex = 16;
            this.bttnAgregarInicio.Text = "Agregar en Inicio";
            this.bttnAgregarInicio.UseVisualStyleBackColor = true;
            this.bttnAgregarInicio.Click += new System.EventHandler(this.bttnAgregarInicio_Click);
            // 
            // bttnEliminarUltimo
            // 
            this.bttnEliminarUltimo.AutoSize = true;
            this.bttnEliminarUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEliminarUltimo.Location = new System.Drawing.Point(255, 431);
            this.bttnEliminarUltimo.Name = "bttnEliminarUltimo";
            this.bttnEliminarUltimo.Size = new System.Drawing.Size(186, 39);
            this.bttnEliminarUltimo.TabIndex = 17;
            this.bttnEliminarUltimo.Text = "Eliminar Ultimo";
            this.bttnEliminarUltimo.UseVisualStyleBackColor = true;
            this.bttnEliminarUltimo.Click += new System.EventHandler(this.bttnEliminarUltimo_Click);
            // 
            // bttnEliminarPrimero
            // 
            this.bttnEliminarPrimero.AutoSize = true;
            this.bttnEliminarPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEliminarPrimero.Location = new System.Drawing.Point(255, 476);
            this.bttnEliminarPrimero.Name = "bttnEliminarPrimero";
            this.bttnEliminarPrimero.Size = new System.Drawing.Size(203, 39);
            this.bttnEliminarPrimero.TabIndex = 18;
            this.bttnEliminarPrimero.Text = "Eliminar Primero";
            this.bttnEliminarPrimero.UseVisualStyleBackColor = true;
            this.bttnEliminarPrimero.Click += new System.EventHandler(this.bttnEliminarPrimero_Click);
            // 
            // bttnInsertarDespuesDe
            // 
            this.bttnInsertarDespuesDe.AutoSize = true;
            this.bttnInsertarDespuesDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnInsertarDespuesDe.Location = new System.Drawing.Point(255, 521);
            this.bttnInsertarDespuesDe.Name = "bttnInsertarDespuesDe";
            this.bttnInsertarDespuesDe.Size = new System.Drawing.Size(245, 39);
            this.bttnInsertarDespuesDe.TabIndex = 19;
            this.bttnInsertarDespuesDe.Text = "Insertar Despues de";
            this.bttnInsertarDespuesDe.UseVisualStyleBackColor = true;
            this.bttnInsertarDespuesDe.Click += new System.EventHandler(this.bttnInsertarDespuesDe_Click);
            // 
            // bttnReporte
            // 
            this.bttnReporte.AutoSize = true;
            this.bttnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnReporte.Location = new System.Drawing.Point(30, 229);
            this.bttnReporte.Name = "bttnReporte";
            this.bttnReporte.Size = new System.Drawing.Size(170, 39);
            this.bttnReporte.TabIndex = 20;
            this.bttnReporte.Text = "Reporte";
            this.bttnReporte.UseVisualStyleBackColor = true;
            this.bttnReporte.Click += new System.EventHandler(this.bttnReporte_Click);
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(30, 336);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.ShowUpDown = true;
            this.dateTimePickerInicio.Size = new System.Drawing.Size(170, 34);
            this.dateTimePickerInicio.TabIndex = 21;
            this.dateTimePickerInicio.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerFinal.Location = new System.Drawing.Point(30, 409);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.ShowUpDown = true;
            this.dateTimePickerFinal.Size = new System.Drawing.Size(170, 34);
            this.dateTimePickerFinal.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 593);
            this.Controls.Add(this.dateTimePickerFinal);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.bttnReporte);
            this.Controls.Add(this.bttnInsertarDespuesDe);
            this.Controls.Add(this.bttnEliminarPrimero);
            this.Controls.Add(this.bttnEliminarUltimo);
            this.Controls.Add(this.bttnAgregarInicio);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.bttnBuscar);
            this.Controls.Add(this.txtBxRecorrido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBxBaseInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttnCalcularRuta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxMinutosBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttnAgregarBase);
            this.Controls.Add(this.txtBxNombreBase);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ruta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxNombreBase;
        private System.Windows.Forms.Button bttnAgregarBase;
        private System.Windows.Forms.TextBox txtBxMinutosBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttnCalcularRuta;
        private System.Windows.Forms.TextBox txtBxBaseInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBxRecorrido;
        private System.Windows.Forms.Button bttnBuscar;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.Button bttnAgregarInicio;
        private System.Windows.Forms.Button bttnEliminarUltimo;
        private System.Windows.Forms.Button bttnEliminarPrimero;
        private System.Windows.Forms.Button bttnInsertarDespuesDe;
        private System.Windows.Forms.Button bttnReporte;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
    }
}

