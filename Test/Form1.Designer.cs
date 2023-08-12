namespace Test
{
    partial class Form1
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
            label1 = new Label();
            dgvAlumnos = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            txtId = new TextBox();
            txtDNI = new TextBox();
            txtApellido = new TextBox();
            txtEdad = new TextBox();
            textNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(310, 9);
            label1.Name = "label1";
            label1.Size = new Size(296, 28);
            label1.TabIndex = 1;
            label1.Text = "CALCULO NOMINA DE TRABAJO";
            label1.Click += label1_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(298, 50);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowTemplate.Height = 25;
            dgvAlumnos.Size = new Size(479, 264);
            dgvAlumnos.TabIndex = 15;
            dgvAlumnos.CellContentClick += dgvAlumnos_CellContentClick;
            dgvAlumnos.CellMouseClick += dgvAlumnos_CellMouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 50);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 16;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 87);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 17;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 125);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 18;
            label4.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 174);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 19;
            label5.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 213);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 20;
            label6.Text = "Edad";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(109, 243);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(129, 33);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(93, 291);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 22;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(187, 291);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(99, 50);
            txtId.Name = "txtId";
            txtId.Size = new Size(193, 23);
            txtId.TabIndex = 24;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(99, 84);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(193, 23);
            txtDNI.TabIndex = 25;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(99, 166);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(193, 23);
            txtApellido.TabIndex = 27;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(99, 205);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(193, 23);
            txtEdad.TabIndex = 28;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(99, 125);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(193, 23);
            textNombre.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textNombre);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtDNI);
            Controls.Add(txtId);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvAlumnos);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarRegistroEmpleado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCalcularSaldo;
        private Label label6;
        private Button btnNuevo;
        private Button btnSalir;
        private TextBox txtNombre;
        private TextBox txtIdentificacion;
        private TextBox txtSaldoDia;
        private TextBox txtDiasLaborados;
        private TextBox txtTotalDevengado;
        private DataGridView dgvAlumnos;
        private Button btnGuardar;
        private Button btnEditar;
        private TextBox txtId;
        private TextBox txtDNI;

        private TextBox txtApellido;
        private TextBox txtEdad;
        private Button btnEliminar;
        private Button btnnEliminar;
        private TextBox textNombre;
    }
}