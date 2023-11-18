namespace Tulen_Dennis
{
    partial class frmPrincipal
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.radVendedor = new System.Windows.Forms.RadioButton();
            this.radSupervisor = new System.Windows.Forms.RadioButton();
            this.radJefe = new System.Windows.Forms.RadioButton();
            this.txtVentasRealizadas = new System.Windows.Forms.TextBox();
            this.txtSueldoBase = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblVentasRealizadas = new System.Windows.Forms.Label();
            this.lblSueldoBase = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblResComision = new System.Windows.Forms.Label();
            this.lblResNuevoSueldo = new System.Windows.Forms.Label();
            this.grpDatosEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(265, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(303, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Almacen \"Guanacos\"";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDatosEmpleado
            // 
            this.grpDatosEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDatosEmpleado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpDatosEmpleado.Controls.Add(this.radVendedor);
            this.grpDatosEmpleado.Controls.Add(this.radSupervisor);
            this.grpDatosEmpleado.Controls.Add(this.radJefe);
            this.grpDatosEmpleado.Controls.Add(this.txtVentasRealizadas);
            this.grpDatosEmpleado.Controls.Add(this.txtSueldoBase);
            this.grpDatosEmpleado.Controls.Add(this.txtNombre);
            this.grpDatosEmpleado.Controls.Add(this.lblVentasRealizadas);
            this.grpDatosEmpleado.Controls.Add(this.lblSueldoBase);
            this.grpDatosEmpleado.Controls.Add(this.lblNombre);
            this.grpDatosEmpleado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosEmpleado.Location = new System.Drawing.Point(12, 72);
            this.grpDatosEmpleado.Name = "grpDatosEmpleado";
            this.grpDatosEmpleado.Size = new System.Drawing.Size(776, 235);
            this.grpDatosEmpleado.TabIndex = 1;
            this.grpDatosEmpleado.TabStop = false;
            this.grpDatosEmpleado.Text = "Datos del empleado";
            // 
            // radVendedor
            // 
            this.radVendedor.AutoSize = true;
            this.radVendedor.Location = new System.Drawing.Point(568, 148);
            this.radVendedor.Name = "radVendedor";
            this.radVendedor.Size = new System.Drawing.Size(115, 27);
            this.radVendedor.TabIndex = 8;
            this.radVendedor.TabStop = true;
            this.radVendedor.Text = "Vendedor";
            this.radVendedor.UseVisualStyleBackColor = true;
            // 
            // radSupervisor
            // 
            this.radSupervisor.AutoSize = true;
            this.radSupervisor.Location = new System.Drawing.Point(568, 95);
            this.radSupervisor.Name = "radSupervisor";
            this.radSupervisor.Size = new System.Drawing.Size(124, 27);
            this.radSupervisor.TabIndex = 7;
            this.radSupervisor.TabStop = true;
            this.radSupervisor.Text = "Supervisor";
            this.radSupervisor.UseVisualStyleBackColor = true;
            // 
            // radJefe
            // 
            this.radJefe.AutoSize = true;
            this.radJefe.Location = new System.Drawing.Point(568, 39);
            this.radJefe.Name = "radJefe";
            this.radJefe.Size = new System.Drawing.Size(69, 27);
            this.radJefe.TabIndex = 6;
            this.radJefe.TabStop = true;
            this.radJefe.Text = "Jefe";
            this.radJefe.UseVisualStyleBackColor = true;
            // 
            // txtVentasRealizadas
            // 
            this.txtVentasRealizadas.Location = new System.Drawing.Point(191, 149);
            this.txtVentasRealizadas.Name = "txtVentasRealizadas";
            this.txtVentasRealizadas.Size = new System.Drawing.Size(211, 30);
            this.txtVentasRealizadas.TabIndex = 5;
            // 
            // txtSueldoBase
            // 
            this.txtSueldoBase.Location = new System.Drawing.Point(191, 92);
            this.txtSueldoBase.Name = "txtSueldoBase";
            this.txtSueldoBase.Size = new System.Drawing.Size(211, 30);
            this.txtSueldoBase.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(191, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(270, 30);
            this.txtNombre.TabIndex = 3;
            // 
            // lblVentasRealizadas
            // 
            this.lblVentasRealizadas.AutoSize = true;
            this.lblVentasRealizadas.Location = new System.Drawing.Point(18, 152);
            this.lblVentasRealizadas.Name = "lblVentasRealizadas";
            this.lblVentasRealizadas.Size = new System.Drawing.Size(165, 23);
            this.lblVentasRealizadas.TabIndex = 2;
            this.lblVentasRealizadas.Text = "Ventas realizadas";
            // 
            // lblSueldoBase
            // 
            this.lblSueldoBase.AutoSize = true;
            this.lblSueldoBase.Location = new System.Drawing.Point(18, 95);
            this.lblSueldoBase.Name = "lblSueldoBase";
            this.lblSueldoBase.Size = new System.Drawing.Size(119, 23);
            this.lblSueldoBase.TabIndex = 1;
            this.lblSueldoBase.Text = "Sueldo base";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 23);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Black;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(220, 326);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(176, 49);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Gray;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(418, 326);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(183, 49);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.AutoSize = true;
            this.btnSalir.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(673, 492);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 42);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblResComision
            // 
            this.lblResComision.AutoSize = true;
            this.lblResComision.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResComision.ForeColor = System.Drawing.Color.Black;
            this.lblResComision.Location = new System.Drawing.Point(74, 396);
            this.lblResComision.Name = "lblResComision";
            this.lblResComision.Size = new System.Drawing.Size(205, 24);
            this.lblResComision.TabIndex = 5;
            this.lblResComision.Text = "La comision es de: $";
            // 
            // lblResNuevoSueldo
            // 
            this.lblResNuevoSueldo.AutoSize = true;
            this.lblResNuevoSueldo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResNuevoSueldo.ForeColor = System.Drawing.Color.Black;
            this.lblResNuevoSueldo.Location = new System.Drawing.Point(74, 438);
            this.lblResNuevoSueldo.Name = "lblResNuevoSueldo";
            this.lblResNuevoSueldo.Size = new System.Drawing.Size(249, 24);
            this.lblResNuevoSueldo.TabIndex = 6;
            this.lblResNuevoSueldo.Text = "Su nuevo sueldo es de: $";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.lblResNuevoSueldo);
            this.Controls.Add(this.lblResComision);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grpDatosEmpleado);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo Salario";
            this.grpDatosEmpleado.ResumeLayout(false);
            this.grpDatosEmpleado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpDatosEmpleado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtSueldoBase;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblVentasRealizadas;
        private System.Windows.Forms.Label lblSueldoBase;
        private System.Windows.Forms.TextBox txtVentasRealizadas;
        private System.Windows.Forms.RadioButton radVendedor;
        private System.Windows.Forms.RadioButton radSupervisor;
        private System.Windows.Forms.RadioButton radJefe;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblResComision;
        private System.Windows.Forms.Label lblResNuevoSueldo;
    }
}

