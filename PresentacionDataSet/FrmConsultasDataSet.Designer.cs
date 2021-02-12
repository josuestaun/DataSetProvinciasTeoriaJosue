namespace PresentacionDataSet
{
    partial class FrmConsultasDataSet
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
            this.cboProvincias1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdProv1 = new System.Windows.Forms.TextBox();
            this.txtComienzoNombreProv2 = new System.Windows.Forms.TextBox();
            this.btnBuscarPorId = new System.Windows.Forms.Button();
            this.btnBuscarPorComienzoNombre = new System.Windows.Forms.Button();
            this.lstProvinciasPorComienzoNombre2 = new System.Windows.Forms.ListBox();
            this.btnHabitantesProv = new System.Windows.Forms.Button();
            this.lblHabitantesProv4 = new System.Windows.Forms.Label();
            this.btnCantidadLocalidadesPorHabitante = new System.Windows.Forms.Button();
            this.txtCantidadLocalidades6 = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLocalidadesPequeñas = new System.Windows.Forms.Button();
            this.btnProvinciasSinLocalidades = new System.Windows.Forms.Button();
            this.btnProvinciasDTO = new System.Windows.Forms.Button();
            this.btnHabitantesPorNombre = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombreProvincia1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVerIds = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblNombreProvincia3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdProv3 = new System.Windows.Forms.TextBox();
            this.txtNombreProvincia4 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtIdProv4 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblMensajeDataGridView = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboProvincias1
            // 
            this.cboProvincias1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincias1.FormattingEnabled = true;
            this.cboProvincias1.Location = new System.Drawing.Point(113, 21);
            this.cboProvincias1.Name = "cboProvincias1";
            this.cboProvincias1.Size = new System.Drawing.Size(186, 21);
            this.cboProvincias1.TabIndex = 0;
            this.cboProvincias1.SelectedIndexChanged += new System.EventHandler(this.cboProvincias1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Provincias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id provincia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre provincia";
            // 
            // txtIdProv1
            // 
            this.txtIdProv1.Location = new System.Drawing.Point(113, 62);
            this.txtIdProv1.Name = "txtIdProv1";
            this.txtIdProv1.Size = new System.Drawing.Size(58, 20);
            this.txtIdProv1.TabIndex = 4;
            // 
            // txtComienzoNombreProv2
            // 
            this.txtComienzoNombreProv2.Location = new System.Drawing.Point(177, 35);
            this.txtComienzoNombreProv2.Name = "txtComienzoNombreProv2";
            this.txtComienzoNombreProv2.Size = new System.Drawing.Size(117, 20);
            this.txtComienzoNombreProv2.TabIndex = 5;
            // 
            // btnBuscarPorId
            // 
            this.btnBuscarPorId.Location = new System.Drawing.Point(34, 35);
            this.btnBuscarPorId.Name = "btnBuscarPorId";
            this.btnBuscarPorId.Size = new System.Drawing.Size(152, 50);
            this.btnBuscarPorId.TabIndex = 6;
            this.btnBuscarPorId.Text = "Localidades deshabitadas de provincia (por Id)";
            this.btnBuscarPorId.UseVisualStyleBackColor = true;
            this.btnBuscarPorId.Click += new System.EventHandler(this.btnBuscarPorId_Click);
            // 
            // btnBuscarPorComienzoNombre
            // 
            this.btnBuscarPorComienzoNombre.Location = new System.Drawing.Point(22, 21);
            this.btnBuscarPorComienzoNombre.Name = "btnBuscarPorComienzoNombre";
            this.btnBuscarPorComienzoNombre.Size = new System.Drawing.Size(138, 47);
            this.btnBuscarPorComienzoNombre.TabIndex = 7;
            this.btnBuscarPorComienzoNombre.Text = "Buscar provincias por comienzo de nombre";
            this.btnBuscarPorComienzoNombre.UseVisualStyleBackColor = true;
            this.btnBuscarPorComienzoNombre.Click += new System.EventHandler(this.btnBuscarPorComienzoNombre_Click);
            // 
            // lstProvinciasPorComienzoNombre2
            // 
            this.lstProvinciasPorComienzoNombre2.FormattingEnabled = true;
            this.lstProvinciasPorComienzoNombre2.Location = new System.Drawing.Point(22, 85);
            this.lstProvinciasPorComienzoNombre2.Name = "lstProvinciasPorComienzoNombre2";
            this.lstProvinciasPorComienzoNombre2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstProvinciasPorComienzoNombre2.Size = new System.Drawing.Size(184, 82);
            this.lstProvinciasPorComienzoNombre2.TabIndex = 8;
            // 
            // btnHabitantesProv
            // 
            this.btnHabitantesProv.Location = new System.Drawing.Point(15, 32);
            this.btnHabitantesProv.Name = "btnHabitantesProv";
            this.btnHabitantesProv.Size = new System.Drawing.Size(172, 32);
            this.btnHabitantesProv.TabIndex = 11;
            this.btnHabitantesProv.Text = "Habitantes por ID  de provincia";
            this.btnHabitantesProv.UseVisualStyleBackColor = true;
            this.btnHabitantesProv.Click += new System.EventHandler(this.btnHabitantesProv_Click);
            // 
            // lblHabitantesProv4
            // 
            this.lblHabitantesProv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblHabitantesProv4.Location = new System.Drawing.Point(306, 57);
            this.lblHabitantesProv4.Name = "lblHabitantesProv4";
            this.lblHabitantesProv4.Size = new System.Drawing.Size(166, 17);
            this.lblHabitantesProv4.TabIndex = 12;
            this.lblHabitantesProv4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCantidadLocalidadesPorHabitante
            // 
            this.btnCantidadLocalidadesPorHabitante.Location = new System.Drawing.Point(231, 24);
            this.btnCantidadLocalidadesPorHabitante.Name = "btnCantidadLocalidadesPorHabitante";
            this.btnCantidadLocalidadesPorHabitante.Size = new System.Drawing.Size(174, 43);
            this.btnCantidadLocalidadesPorHabitante.TabIndex = 13;
            this.btnCantidadLocalidadesPorHabitante.Text = "Cantidad de localidades a mostrar (ordenadas por habitantes)";
            this.btnCantidadLocalidadesPorHabitante.UseVisualStyleBackColor = true;
            this.btnCantidadLocalidadesPorHabitante.Click += new System.EventHandler(this.btnCantidadLocalidadesPorHabitante_Click);
            // 
            // txtCantidadLocalidades6
            // 
            this.txtCantidadLocalidades6.Location = new System.Drawing.Point(149, 39);
            this.txtCantidadLocalidades6.Name = "txtCantidadLocalidades6";
            this.txtCantidadLocalidades6.Size = new System.Drawing.Size(69, 20);
            this.txtCantidadLocalidades6.TabIndex = 14;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(470, 344);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.Size = new System.Drawing.Size(783, 240);
            this.dgv.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cantidad de localidades";
            // 
            // btnLocalidadesPequeñas
            // 
            this.btnLocalidadesPequeñas.Location = new System.Drawing.Point(154, 43);
            this.btnLocalidadesPequeñas.Name = "btnLocalidadesPequeñas";
            this.btnLocalidadesPequeñas.Size = new System.Drawing.Size(162, 41);
            this.btnLocalidadesPequeñas.TabIndex = 17;
            this.btnLocalidadesPequeñas.Text = "Localidades habitadas más pequeñas";
            this.btnLocalidadesPequeñas.UseVisualStyleBackColor = true;
            this.btnLocalidadesPequeñas.Click += new System.EventHandler(this.btnLocalidadesPequeñas_Click);
            // 
            // btnProvinciasSinLocalidades
            // 
            this.btnProvinciasSinLocalidades.Location = new System.Drawing.Point(27, 19);
            this.btnProvinciasSinLocalidades.Name = "btnProvinciasSinLocalidades";
            this.btnProvinciasSinLocalidades.Size = new System.Drawing.Size(154, 32);
            this.btnProvinciasSinLocalidades.TabIndex = 19;
            this.btnProvinciasSinLocalidades.Text = "Provincias sin localidades";
            this.btnProvinciasSinLocalidades.UseVisualStyleBackColor = true;
            this.btnProvinciasSinLocalidades.Click += new System.EventHandler(this.btnProvinciasSinLocalidades_Click);
            // 
            // btnProvinciasDTO
            // 
            this.btnProvinciasDTO.Location = new System.Drawing.Point(118, 37);
            this.btnProvinciasDTO.Name = "btnProvinciasDTO";
            this.btnProvinciasDTO.Size = new System.Drawing.Size(210, 32);
            this.btnProvinciasDTO.TabIndex = 20;
            this.btnProvinciasDTO.Text = "Provincias DTO";
            this.btnProvinciasDTO.UseVisualStyleBackColor = true;
            this.btnProvinciasDTO.Click += new System.EventHandler(this.btnProvinciasDTO_Click);
            // 
            // btnHabitantesPorNombre
            // 
            this.btnHabitantesPorNombre.Location = new System.Drawing.Point(15, 88);
            this.btnHabitantesPorNombre.Name = "btnHabitantesPorNombre";
            this.btnHabitantesPorNombre.Size = new System.Drawing.Size(223, 32);
            this.btnHabitantesPorNombre.TabIndex = 21;
            this.btnHabitantesPorNombre.Text = "Habitantes por Nombre  de provincia >>";
            this.btnHabitantesPorNombre.UseVisualStyleBackColor = true;
            this.btnHabitantesPorNombre.Click += new System.EventHandler(this.btnHabitantesProv_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombreProvincia1);
            this.groupBox1.Controls.Add(this.cboProvincias1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdProv1);
            this.groupBox1.Location = new System.Drawing.Point(34, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 128);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1 Provincia por Id";
            // 
            // lblNombreProvincia1
            // 
            this.lblNombreProvincia1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblNombreProvincia1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombreProvincia1.Location = new System.Drawing.Point(306, 63);
            this.lblNombreProvincia1.Name = "lblNombreProvincia1";
            this.lblNombreProvincia1.Size = new System.Drawing.Size(182, 22);
            this.lblNombreProvincia1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVerIds);
            this.groupBox2.Controls.Add(this.btnBuscarPorComienzoNombre);
            this.groupBox2.Controls.Add(this.txtComienzoNombreProv2);
            this.groupBox2.Controls.Add(this.lstProvinciasPorComienzoNombre2);
            this.groupBox2.Location = new System.Drawing.Point(547, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 198);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2 Provincias por comienzo nombre (ordenadas por nombre)";
            // 
            // btnVerIds
            // 
            this.btnVerIds.Location = new System.Drawing.Point(238, 109);
            this.btnVerIds.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerIds.Name = "btnVerIds";
            this.btnVerIds.Size = new System.Drawing.Size(56, 28);
            this.btnVerIds.TabIndex = 9;
            this.btnVerIds.Text = "Ver Ids";
            this.btnVerIds.UseVisualStyleBackColor = true;
            this.btnVerIds.Click += new System.EventHandler(this.btnVerIds_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblNombreProvincia3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtIdProv3);
            this.groupBox3.Controls.Add(this.btnBuscarPorId);
            this.groupBox3.Location = new System.Drawing.Point(896, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 165);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3 Localidades deshabitadas ORDENADAS de provincia (null)";
            // 
            // lblNombreProvincia3
            // 
            this.lblNombreProvincia3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblNombreProvincia3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombreProvincia3.Location = new System.Drawing.Point(113, 107);
            this.lblNombreProvincia3.Name = "lblNombreProvincia3";
            this.lblNombreProvincia3.Size = new System.Drawing.Size(238, 22);
            this.lblNombreProvincia3.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nombre provincia";
            // 
            // txtIdProv3
            // 
            this.txtIdProv3.Location = new System.Drawing.Point(206, 47);
            this.txtIdProv3.Name = "txtIdProv3";
            this.txtIdProv3.Size = new System.Drawing.Size(58, 20);
            this.txtIdProv3.TabIndex = 28;
            this.txtIdProv3.TextChanged += new System.EventHandler(this.txtIdProv3_TextChanged);
            // 
            // txtNombreProvincia4
            // 
            this.txtNombreProvincia4.Location = new System.Drawing.Point(259, 95);
            this.txtNombreProvincia4.Name = "txtNombreProvincia4";
            this.txtNombreProvincia4.Size = new System.Drawing.Size(115, 20);
            this.txtNombreProvincia4.TabIndex = 26;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtIdProv4);
            this.groupBox4.Controls.Add(this.btnHabitantesProv);
            this.groupBox4.Controls.Add(this.txtNombreProvincia4);
            this.groupBox4.Controls.Add(this.btnHabitantesPorNombre);
            this.groupBox4.Controls.Add(this.lblHabitantesProv4);
            this.groupBox4.Location = new System.Drawing.Point(34, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(478, 140);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "4 Habitantes de PROVINCIA. Buscar por clave o campo (NumHab null  => 0)";
            // 
            // txtIdProv4
            // 
            this.txtIdProv4.Location = new System.Drawing.Point(225, 37);
            this.txtIdProv4.Name = "txtIdProv4";
            this.txtIdProv4.Size = new System.Drawing.Size(58, 20);
            this.txtIdProv4.TabIndex = 27;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.txtCantidadLocalidades6);
            this.groupBox6.Controls.Add(this.btnCantidadLocalidadesPorHabitante);
            this.groupBox6.Location = new System.Drawing.Point(795, 219);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(452, 78);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "6 Cantidad de localidades (DTO) a mostrar (ordenadas por hab) con nombre de provi" +
    "ncia";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnProvinciasSinLocalidades);
            this.groupBox7.Location = new System.Drawing.Point(542, 238);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(207, 59);
            this.groupBox7.TabIndex = 31;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "5 Provincias sin localidades";
            // 
            // lblMensajeDataGridView
            // 
            this.lblMensajeDataGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMensajeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMensajeDataGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeDataGridView.Location = new System.Drawing.Point(542, 319);
            this.lblMensajeDataGridView.Name = "lblMensajeDataGridView";
            this.lblMensajeDataGridView.Size = new System.Drawing.Size(670, 22);
            this.lblMensajeDataGridView.TabIndex = 32;
            this.lblMensajeDataGridView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnLocalidadesPequeñas);
            this.groupBox8.Location = new System.Drawing.Point(43, 319);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(414, 100);
            this.groupBox8.TabIndex = 33;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "7 Localidades habitadas con menor nº habitantes (nombre localidad y provincia)";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnProvinciasDTO);
            this.groupBox9.Location = new System.Drawing.Point(50, 444);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(394, 93);
            this.groupBox9.TabIndex = 34;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "8. Provincias con cantidad localidades, deshabitadas y habitantes";
            // 
            // FrmConsultasDataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 609);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.lblMensajeDataGridView);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Name = "FrmConsultasDataSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas DataSet ";
            this.Load += new System.EventHandler(this.FrmConsultasDataSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProvincias1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdProv1;
        private System.Windows.Forms.TextBox txtComienzoNombreProv2;
        private System.Windows.Forms.Button btnBuscarPorId;
        private System.Windows.Forms.Button btnBuscarPorComienzoNombre;
        private System.Windows.Forms.ListBox lstProvinciasPorComienzoNombre2;
        private System.Windows.Forms.Button btnHabitantesProv;
        private System.Windows.Forms.Label lblHabitantesProv4;
        private System.Windows.Forms.Button btnCantidadLocalidadesPorHabitante;
        private System.Windows.Forms.TextBox txtCantidadLocalidades6;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLocalidadesPequeñas;
        private System.Windows.Forms.Button btnProvinciasSinLocalidades;
        private System.Windows.Forms.Button btnProvinciasDTO;
        private System.Windows.Forms.Button btnHabitantesPorNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNombreProvincia1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNombreProvincia4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtIdProv4;
        private System.Windows.Forms.TextBox txtIdProv3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblNombreProvincia3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblMensajeDataGridView;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.Button btnVerIds;
	}
}

