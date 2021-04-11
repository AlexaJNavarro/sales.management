namespace pryPresentacion.Forms
{
    partial class frmRegistrarP
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.cboseguro = new System.Windows.Forms.ComboBox();
            this.cbodistrito = new System.Windows.Forms.ComboBox();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.cbosexo = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTelf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApm = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtApp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbtno = new System.Windows.Forms.RadioButton();
            this.rbtsi = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtnomperte = new System.Windows.Forms.TextBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.txtdire = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoI = new System.Windows.Forms.ComboBox();
            this.txtIdent = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtbuscarident = new System.Windows.Forms.TextBox();
            this.dgvregistrar = new System.Windows.Forms.DataGridView();
            this.lbl = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvregistrar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(645, 430);
            this.tabControl1.TabIndex = 43;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.cboseguro);
            this.tabPage1.Controls.Add(this.cbodistrito);
            this.tabPage1.Controls.Add(this.cboestado);
            this.tabPage1.Controls.Add(this.cbosexo);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.txtTelf);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtApm);
            this.tabPage1.Controls.Add(this.txtNom);
            this.tabPage1.Controls.Add(this.txtApp);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.rbtno);
            this.tabPage1.Controls.Add(this.rbtsi);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtnomperte);
            this.tabPage1.Controls.Add(this.dtpfecha);
            this.tabPage1.Controls.Add(this.txtdire);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cboTipoI);
            this.tabPage1.Controls.Add(this.txtIdent);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(637, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(356, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 36);
            this.button2.TabIndex = 91;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboseguro
            // 
            this.cboseguro.Enabled = false;
            this.cboseguro.FormattingEnabled = true;
            this.cboseguro.Location = new System.Drawing.Point(422, 151);
            this.cboseguro.Name = "cboseguro";
            this.cboseguro.Size = new System.Drawing.Size(152, 25);
            this.cboseguro.TabIndex = 90;
            // 
            // cbodistrito
            // 
            this.cbodistrito.FormattingEnabled = true;
            this.cbodistrito.Location = new System.Drawing.Point(422, 58);
            this.cbodistrito.Name = "cbodistrito";
            this.cbodistrito.Size = new System.Drawing.Size(152, 25);
            this.cbodistrito.TabIndex = 89;
            // 
            // cboestado
            // 
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(239, 150);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(152, 25);
            this.cboestado.TabIndex = 88;
            // 
            // cbosexo
            // 
            this.cbosexo.FormattingEnabled = true;
            this.cbosexo.Location = new System.Drawing.Point(239, 103);
            this.cbosexo.Name = "cbosexo";
            this.cbosexo.Size = new System.Drawing.Size(151, 25);
            this.cbosexo.TabIndex = 87;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label17.Location = new System.Drawing.Point(421, 131);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 17);
            this.label17.TabIndex = 86;
            this.label17.Text = "Nombre del Seguro:";
            // 
            // txtTelf
            // 
            this.txtTelf.Location = new System.Drawing.Point(239, 58);
            this.txtTelf.Name = "txtTelf";
            this.txtTelf.Size = new System.Drawing.Size(151, 23);
            this.txtTelf.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(239, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(51, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 82;
            this.label4.Text = "Apellido Materno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(51, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 81;
            this.label3.Text = "Apellido Paterno:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label10.Location = new System.Drawing.Point(51, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 80;
            this.label10.Text = "Nombre:";
            // 
            // txtApm
            // 
            this.txtApm.Location = new System.Drawing.Point(54, 245);
            this.txtApm.Name = "txtApm";
            this.txtApm.Size = new System.Drawing.Size(148, 23);
            this.txtApm.TabIndex = 79;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(54, 150);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(148, 23);
            this.txtNom.TabIndex = 78;
            // 
            // txtApp
            // 
            this.txtApp.Location = new System.Drawing.Point(54, 197);
            this.txtApp.Name = "txtApp";
            this.txtApp.Size = new System.Drawing.Size(148, 23);
            this.txtApp.TabIndex = 77;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(214, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 36);
            this.button1.TabIndex = 74;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbtno
            // 
            this.rbtno.AutoSize = true;
            this.rbtno.Location = new System.Drawing.Point(471, 107);
            this.rbtno.Name = "rbtno";
            this.rbtno.Size = new System.Drawing.Size(45, 21);
            this.rbtno.TabIndex = 73;
            this.rbtno.TabStop = true;
            this.rbtno.Text = "No";
            this.rbtno.UseVisualStyleBackColor = true;
            this.rbtno.CheckedChanged += new System.EventHandler(this.rbtno_CheckedChanged);
            // 
            // rbtsi
            // 
            this.rbtsi.AutoSize = true;
            this.rbtsi.Location = new System.Drawing.Point(422, 107);
            this.rbtsi.Name = "rbtsi";
            this.rbtsi.Size = new System.Drawing.Size(35, 21);
            this.rbtsi.TabIndex = 72;
            this.rbtsi.TabStop = true;
            this.rbtsi.Text = "Si";
            this.rbtsi.UseVisualStyleBackColor = true;
            this.rbtsi.CheckedChanged += new System.EventHandler(this.rbtsi_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label12.Location = new System.Drawing.Point(419, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 68;
            this.label12.Text = "Seguro:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label13.Location = new System.Drawing.Point(419, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(210, 17);
            this.label13.TabIndex = 67;
            this.label13.Text = "Centro de Salud Perteneciente:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label14.Location = new System.Drawing.Point(419, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 17);
            this.label14.TabIndex = 66;
            this.label14.Text = "Nombre del Distrito:";
            // 
            // txtnomperte
            // 
            this.txtnomperte.Enabled = false;
            this.txtnomperte.Location = new System.Drawing.Point(422, 199);
            this.txtnomperte.Name = "txtnomperte";
            this.txtnomperte.Size = new System.Drawing.Size(152, 23);
            this.txtnomperte.TabIndex = 63;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(240, 197);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(149, 23);
            this.dtpfecha.TabIndex = 60;
            // 
            // txtdire
            // 
            this.txtdire.Location = new System.Drawing.Point(237, 247);
            this.txtdire.Name = "txtdire";
            this.txtdire.Size = new System.Drawing.Size(151, 23);
            this.txtdire.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label7.Location = new System.Drawing.Point(237, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 58;
            this.label7.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label8.Location = new System.Drawing.Point(237, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 17);
            this.label8.TabIndex = 57;
            this.label8.Text = "Fecha de Nacimiento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label9.Location = new System.Drawing.Point(239, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 56;
            this.label9.Text = "Estado Civil:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label6.Location = new System.Drawing.Point(239, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.Location = new System.Drawing.Point(51, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "N° de Identificación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(51, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Tipo de Identificación:";
            // 
            // cboTipoI
            // 
            this.cboTipoI.FormattingEnabled = true;
            this.cboTipoI.Location = new System.Drawing.Point(54, 58);
            this.cboTipoI.Name = "cboTipoI";
            this.cboTipoI.Size = new System.Drawing.Size(148, 25);
            this.cboTipoI.TabIndex = 47;
            // 
            // txtIdent
            // 
            this.txtIdent.Location = new System.Drawing.Point(54, 103);
            this.txtIdent.Name = "txtIdent";
            this.txtIdent.Size = new System.Drawing.Size(148, 23);
            this.txtIdent.TabIndex = 44;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btneliminar);
            this.tabPage2.Controls.Add(this.btnbuscar);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.txtbuscarident);
            this.tabPage2.Controls.Add(this.dgvregistrar);
            this.tabPage2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(637, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btneliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btneliminar.Location = new System.Drawing.Point(286, 342);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(81, 36);
            this.btneliminar.TabIndex = 83;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnbuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbuscar.Location = new System.Drawing.Point(529, 17);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(81, 36);
            this.btnbuscar.TabIndex = 82;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label15.Location = new System.Drawing.Point(23, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 17);
            this.label15.TabIndex = 80;
            this.label15.Text = "N° de Identificación:";
            // 
            // txtbuscarident
            // 
            this.txtbuscarident.Location = new System.Drawing.Point(174, 27);
            this.txtbuscarident.Name = "txtbuscarident";
            this.txtbuscarident.Size = new System.Drawing.Size(341, 23);
            this.txtbuscarident.TabIndex = 77;
            // 
            // dgvregistrar
            // 
            this.dgvregistrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvregistrar.Location = new System.Drawing.Point(6, 62);
            this.dgvregistrar.Name = "dgvregistrar";
            this.dgvregistrar.Size = new System.Drawing.Size(625, 259);
            this.dgvregistrar.TabIndex = 0;
            this.dgvregistrar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvregistrar_CellClick);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl.Location = new System.Drawing.Point(437, 269);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 17);
            this.lbl.TabIndex = 93;
            // 
            // frmRegistrarP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 454);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmRegistrarP";
            this.Text = "Registrar Paciente";
            this.Load += new System.EventHandler(this.frmRegistrarP_Load);
            this.Click += new System.EventHandler(this.frmRegistrarP_Click);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvregistrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtnomperte;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.TextBox txtdire;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoI;
        private System.Windows.Forms.TextBox txtIdent;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rbtno;
        private System.Windows.Forms.RadioButton rbtsi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvregistrar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtbuscarident;
        private System.Windows.Forms.TextBox txtTelf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtApm;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtApp;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboseguro;
        private System.Windows.Forms.ComboBox cbodistrito;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.ComboBox cbosexo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label lbl;
    }
}