namespace pryPresentacion.Forms
{
    partial class frmCita
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
            this.label8 = new System.Windows.Forms.Label();
            this.dgvcita = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.btneliminar = new System.Windows.Forms.Button();
            this.dgvdoctor = new System.Windows.Forms.DataGridView();
            this.cboesp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txthora = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtidpac = new System.Windows.Forms.TextBox();
            this.txtmed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label8.Location = new System.Drawing.Point(12, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fecha:";
            // 
            // dgvcita
            // 
            this.dgvcita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcita.Location = new System.Drawing.Point(180, 193);
            this.dgvcita.Name = "dgvcita";
            this.dgvcita.Size = new System.Drawing.Size(477, 194);
            this.dgvcita.TabIndex = 16;
            this.dgvcita.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcita_CellClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(12, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 36);
            this.button2.TabIndex = 18;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnactualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnactualizar.Location = new System.Drawing.Point(99, 400);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(81, 36);
            this.btnactualizar.TabIndex = 19;
            this.btnactualizar.Text = "Modificar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(15, 229);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(151, 20);
            this.dtpfecha.TabIndex = 21;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btneliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btneliminar.Location = new System.Drawing.Point(186, 400);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(81, 36);
            this.btneliminar.TabIndex = 22;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // dgvdoctor
            // 
            this.dgvdoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdoctor.Location = new System.Drawing.Point(180, 9);
            this.dgvdoctor.Name = "dgvdoctor";
            this.dgvdoctor.Size = new System.Drawing.Size(477, 178);
            this.dgvdoctor.TabIndex = 26;
            this.dgvdoctor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdoctor_CellClick);
            // 
            // cboesp
            // 
            this.cboesp.FormattingEnabled = true;
            this.cboesp.Location = new System.Drawing.Point(12, 29);
            this.cboesp.Name = "cboesp";
            this.cboesp.Size = new System.Drawing.Size(148, 21);
            this.cboesp.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Especialidad:";
            // 
            // txthora
            // 
            this.txthora.Location = new System.Drawing.Point(12, 187);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(151, 20);
            this.txthora.TabIndex = 32;
            this.txthora.TextChanged += new System.EventHandler(this.txthora_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label9.Location = new System.Drawing.Point(12, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Hora:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnbuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbuscar.Location = new System.Drawing.Point(41, 56);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(81, 36);
            this.btnbuscar.TabIndex = 35;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.Location = new System.Drawing.Point(9, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "N° de Identificación:";
            // 
            // txtidpac
            // 
            this.txtidpac.Location = new System.Drawing.Point(11, 135);
            this.txtidpac.Name = "txtidpac";
            this.txtidpac.Size = new System.Drawing.Size(151, 20);
            this.txtidpac.TabIndex = 38;
            // 
            // txtmed
            // 
            this.txtmed.Enabled = false;
            this.txtmed.Location = new System.Drawing.Point(12, 283);
            this.txtmed.Name = "txtmed";
            this.txtmed.Size = new System.Drawing.Size(151, 20);
            this.txtmed.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Médico:";
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.ForeColor = System.Drawing.Color.Transparent;
            this.lblcod.Location = new System.Drawing.Point(338, 400);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(0, 13);
            this.lblcod.TabIndex = 41;
            // 
            // frmCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 454);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.txtmed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidpac);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txthora);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboesp);
            this.Controls.Add(this.dgvdoctor);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvcita);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Name = "frmCita";
            this.Text = "Cita";
            this.Load += new System.EventHandler(this.frmCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvcita;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.DataGridView dgvdoctor;
        private System.Windows.Forms.ComboBox cboesp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtidpac;
        private System.Windows.Forms.TextBox txtmed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcod;
    }
}