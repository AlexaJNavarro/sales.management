using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryPresentacion.Modelo;

namespace pryPresentacion.Forms
{

    public partial class frmRegistrarP : Form
    {
        db_clinicEntities db = new db_clinicEntities();
        tb_patient pat = new  tb_patient();


        public frmRegistrarP()
        {
            InitializeComponent();

        }

        public void Desactivar() 
        {
            cboseguro.Enabled = false;
            txtnomperte.Enabled = false;
      
        }

        public void Listar() 
        {
            var listar = from tb_p in db.tb_patient
                         join tb_tp in db.tb_type_identification on tb_p.id_type_identification equals tb_tp.id
                         join tb_g in db.tb_gender on tb_p.id_gender equals tb_g.id
                         join tb_est in db.tb_marital_status on tb_p.id_marital_status equals tb_est.id
                         join tb_hc in db.tb_clinic_history on tb_p.id_clinic_history equals tb_hc.id
                         join tb_seg in db.tb_health_insurance on tb_p.id_health_insurance equals tb_seg.id
                         join tb_dis in db.tb_district on tb_p.id_district equals tb_dis.id

                         where tb_p.state == true
                         select new
                         {
                             Tipo_de_Identificación = tb_tp.type,
                             DNI = tb_p.id,
                             Nombre =tb_p.name,
                             Ape_Paterno = tb_p.a_p,
                             Ape_Materno = tb_p.a_m,
                             Teléfono = tb_p.phone,
                             F_Nacimiento = tb_p.birthdate,
                             Género = tb_g.gender,
                             EstadO_Civil = tb_est.marital_status,
                             Seguro = tb_p.seguro,
                             Nombre_Seguro = tb_seg.name,
                             Num_Historia_Clinica = tb_p.id_clinic_history,
                             Nom_Hospital_Perteneciente = tb_p.hopital_perteneciente,
                             Dirección = tb_p.address,
                             Distrito = tb_dis.district,
                             Estado = tb_p.state
                         };

            dgvregistrar.DataSource = listar.ToList();


        }
       
        public void Limpiar() 
        {
            cboTipoI.SelectedIndex = -1;
            txtIdent.Clear();
            txtNom.Clear();
            txtApp.Clear();
            txtApm.Clear();
            txtTelf.Clear();
            cbosexo.SelectedIndex = -1;
            cboestado.SelectedIndex = -1;
            dtpfecha.Format = DateTimePickerFormat.Short;
            txtdire.Clear();
            cbodistrito.SelectedIndex = -1;
            rbtsi.Checked = false;
            rbtno.Checked = false;
            cboseguro.SelectedIndex = -1;
            txtnomperte.Clear();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistrarP_Load(object sender, EventArgs e)
        {
            cboTipoI.DataSource = db.tb_type_identification.ToList();
            cboTipoI.ValueMember = "id";
            cboTipoI.DisplayMember = "type";
            cboTipoI.SelectedIndex = -1;

            cbosexo.DataSource = db.tb_gender.ToList();
            cbosexo.ValueMember = "id";
            cbosexo.DisplayMember = "gender";
            cbosexo.SelectedIndex = -1;

            cboestado.DataSource = db.tb_marital_status.ToList();
            cboestado.ValueMember = "id";
            cboestado.DisplayMember = "marital_status";
            cboestado.SelectedIndex = -1;

            cbodistrito.DataSource = db.tb_district.ToList();
            cbodistrito.ValueMember = "id";
            cbodistrito.DisplayMember = "district";
            cbodistrito.SelectedIndex = -1;

            cboseguro.DataSource = db.tb_health_insurance.ToList();
            cboseguro.ValueMember = "id";
            cboseguro.DisplayMember = "name";
            cboseguro.SelectedIndex = -1;


            Listar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var num = (from tb_c in db.tb_clinic_history
                           select tb_c).ToList();
                if (num.Count() == 0)
                {

                    tb_clinic_history hc = new tb_clinic_history();
                    hc.id = 1;

                    pat.id = txtIdent.Text;
                    pat.name = txtNom.Text;
                    pat.a_p = txtApp.Text;
                    pat.a_m = txtApm.Text;
                    pat.phone = txtTelf.Text;
                    pat.birthdate = dtpfecha.Value;
                    pat.address = txtdire.Text;
                    if (rbtno.Checked == true)
                    {
                        pat.seguro = false;

                        var cbo = (from tb_es in db.tb_health_insurance
                                   where tb_es.name == "NINGUNO"
                                   select tb_es.id).ToList();

                        pat.id_health_insurance = cbo.First();
                        pat.hopital_perteneciente = null;
                        pat.state = false;
                    }
                    else if (rbtsi.Checked == true)
                    {
                        pat.seguro = true;
                        pat.id_health_insurance = Convert.ToInt32(cboseguro.SelectedValue);
                        pat.hopital_perteneciente = txtnomperte.Text;
                        pat.state = true;
                    }

                    pat.id_type_identification = Convert.ToInt32(cboTipoI.SelectedValue);
                    pat.id_gender = 2; Convert.ToInt32(cbosexo.SelectedValue);
                    pat.id_marital_status = Convert.ToInt32(cboestado.SelectedValue);
                    pat.id_clinic_history = 1;
                    pat.id_district = Convert.ToInt32(cbodistrito.SelectedValue);


                    db.tb_patient.Add(pat);
                    db.tb_clinic_history.Add(hc);
                    db.SaveChanges();
                    Listar();
                    Limpiar();
                    Desactivar();


                }
                else
                {
                    tb_clinic_history hc = new tb_clinic_history();

                    var valor = (from v in db.tb_clinic_history
                                 select v.id).Max();

                    int v_id = valor + 1;

                    hc.id = v_id;

                    pat.id = txtIdent.Text;
                    pat.name = txtNom.Text;
                    pat.a_p = txtApp.Text;
                    pat.a_m = txtApm.Text;
                    pat.phone = txtTelf.Text;
                    pat.birthdate = dtpfecha.Value;
                    pat.address = txtdire.Text;
                    if (rbtno.Checked == true)
                    {
                        pat.seguro = false;

                        var cbo = (from tb_es in db.tb_health_insurance
                                   where tb_es.name == "NINGUNO"
                                   select tb_es.id).ToList();

                        pat.id_health_insurance = cbo.First();
                        pat.hopital_perteneciente = null;
                        pat.state = false;
                    }
                    else if (rbtsi.Checked == true)
                    {
                        pat.seguro = true;
                        pat.id_health_insurance = Convert.ToInt32(cboseguro.SelectedValue);
                        pat.hopital_perteneciente = txtnomperte.Text;
                        pat.state = true;
                    }

                    pat.id_type_identification = Convert.ToInt32(cboTipoI.SelectedValue);
                    pat.id_gender = 2; Convert.ToInt32(cbosexo.SelectedValue);
                    pat.id_marital_status = Convert.ToInt32(cboestado.SelectedValue);
                    pat.id_clinic_history = v_id;
                    pat.id_district = Convert.ToInt32(cbodistrito.SelectedValue);



                    db.tb_patient.Add(pat);
                    db.tb_clinic_history.Add(hc);
                    db.SaveChanges();
                    Listar();
                    Limpiar();
                    Desactivar();


                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("El Paciente ya ha sido registrado");
            }
            //catch (System.Data.Entity.Infrastructure.DbUpdateException) 
            //{
            //    MessageBox.Show("El Paciente ya ha sido registrado");
            //}
            

}

        private void frmRegistrarP_Click(object sender, EventArgs e)
        {

        }

        private void dgvregistrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvregistrar.CurrentRow.Selected = true;

            //Tipo de Identificación

            string tipo_i = dgvregistrar.CurrentRow.Cells[0].Value.ToString();

            var tipo = (from tb_t in db.tb_type_identification
                        where tb_t.type == tipo_i
                        select tb_t.id).ToList();

            cboTipoI.SelectedValue = tipo.First();


            txtIdent.Text = dgvregistrar.CurrentRow.Cells[1].Value.ToString();
            txtNom.Text = dgvregistrar.CurrentRow.Cells[2].Value.ToString();
            txtApp.Text = dgvregistrar.CurrentRow.Cells[3].Value.ToString();
            txtApm.Text = dgvregistrar.CurrentRow.Cells[4].Value.ToString();
            txtTelf.Text = dgvregistrar.CurrentRow.Cells[5].Value.ToString();
            dtpfecha.Value = Convert.ToDateTime(dgvregistrar.CurrentRow.Cells[6].Value.ToString());

            //Genero

            string genero = dgvregistrar.CurrentRow.Cells[7].Value.ToString();

            var g = (from tb_g in db.tb_gender
                     where tb_g.gender == genero
                     select tb_g.id).ToList();

            cbosexo.SelectedValue = g.First();



            //Estado Civil
            string estado = dgvregistrar.CurrentRow.Cells[8].Value.ToString();

            var est = (from tb_e in db.tb_marital_status
                       where tb_e.marital_status == estado
                       select tb_e.id).ToList();

            cboestado.SelectedValue = est.First();

            //Seguro 
            if (dgvregistrar.CurrentRow.Cells[9].Value.ToString() == "True") rbtsi.Checked = true;
            if (dgvregistrar.CurrentRow.Cells[9].Value.ToString() == "False") rbtno.Checked = true;

            //Seguro
            string nom_seg = dgvregistrar.CurrentRow.Cells[10].Value.ToString();

            var n_s = (from tb_s in db.tb_health_insurance
                       where tb_s.name == nom_seg
                       select tb_s.id).ToList();

            cboseguro.SelectedValue = n_s.First();

            lbl.Text = dgvregistrar.CurrentRow.Cells[11].Value.ToString();

            txtnomperte.Text = dgvregistrar.CurrentRow.Cells[12].Value.ToString();

            txtdire.Text = dgvregistrar.CurrentRow.Cells[13].Value.ToString();

            //Distrito
            string distrito = dgvregistrar.CurrentRow.Cells[14].Value.ToString();

            var dis = (from d in db.tb_district
                       where d.district == distrito
                       select d.id).ToList();

            cbodistrito.SelectedValue = dis.First();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                pat.id = txtIdent.Text;
                pat.name = txtNom.Text;
                pat.a_p = txtApp.Text;
                pat.a_m = txtApm.Text;
                pat.phone = txtTelf.Text;
                pat.birthdate = dtpfecha.Value;
                pat.address = txtdire.Text;
                if (rbtno.Checked == true)
                {
                    pat.seguro = false;
                }
                else if (rbtsi.Checked == true)
                {
                    pat.seguro = true;
                }
                pat.hopital_perteneciente = txtnomperte.Text;
                pat.id_type_identification = Convert.ToInt32(cboTipoI.SelectedValue);
                pat.id_gender = Convert.ToInt32(cbosexo.SelectedValue);
                pat.id_marital_status = Convert.ToInt32(cboestado.SelectedValue);
                pat.id_health_insurance = Convert.ToInt32(cboseguro.SelectedValue);
                pat.id_district = Convert.ToInt32(cbodistrito.SelectedValue);

                pat.id_clinic_history = Convert.ToInt32(lbl.Text);

                pat.state = true;

                db.Entry(pat).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                Listar();
                Limpiar();
                Desactivar();


            }
            catch (FormatException) 
            {
                MessageBox.Show("Por favor, Seleccionar el Registro que desea Actualizar");
            }
            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            var listar = from tb_p in db.tb_patient
                         join tb_tp in db.tb_type_identification on tb_p.id_type_identification equals tb_tp.id
                         join tb_g in db.tb_gender on tb_p.id_gender equals tb_g.id
                         join tb_est in db.tb_marital_status on tb_p.id_marital_status equals tb_est.id
                         join tb_hc in db.tb_clinic_history on tb_p.id_clinic_history equals tb_hc.id
                         join tb_seg in db.tb_health_insurance on tb_p.id_health_insurance equals tb_seg.id
                         join tb_dis in db.tb_district on tb_p.id_district equals tb_dis.id

                         where tb_p.id == txtbuscarident.Text
                         select new
                         {
                             Tipo_de_Identificación = tb_tp.type,
                             DNI = tb_p.id,
                             Nombre = tb_p.name,
                             Ape_Paterno = tb_p.a_p,
                             Ape_Materno = tb_p.a_m,
                             Teléfono = tb_p.phone,
                             F_Nacimiento = tb_p.birthdate,
                             Género = tb_g.gender,
                             EstadO_Civil = tb_est.marital_status,
                             Seguro = tb_p.seguro,
                             Nombre_Seguro = tb_seg.name,
                             Num_Historia_Clinica = tb_p.id_clinic_history,
                             Nom_Hospital_Perteneciente = tb_p.hopital_perteneciente,
                             Dirección = tb_p.address,
                             Distrito = tb_dis.district,
                             Estado = tb_p.state
                         };

            dgvregistrar.DataSource = listar.ToList();



        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            //Tipo de Identificación
            string tipo_i = dgvregistrar.CurrentRow.Cells[0].Value.ToString();

            var tipo = (from tb_t in db.tb_type_identification
                        where tb_t.type == tipo_i
                        select tb_t.id).ToList();

            pat.id_type_identification = tipo.First();

            pat.id = dgvregistrar.CurrentRow.Cells[1].Value.ToString();
            pat.name = dgvregistrar.CurrentRow.Cells[2].Value.ToString();
            pat.a_p = dgvregistrar.CurrentRow.Cells[3].Value.ToString();
            pat.a_m = dgvregistrar.CurrentRow.Cells[4].Value.ToString();
            pat.phone = dgvregistrar.CurrentRow.Cells[5].Value.ToString();
            pat.birthdate = Convert.ToDateTime(dgvregistrar.CurrentRow.Cells[6].Value.ToString());

            //Genero
            string genero = dgvregistrar.CurrentRow.Cells[7].Value.ToString();

            var g = (from tb_g in db.tb_gender
                     where tb_g.gender == genero
                     select tb_g.id).ToList();

            pat.id_gender = g.First();


            //Estado Civil
            string estado = dgvregistrar.CurrentRow.Cells[8].Value.ToString();

            var est = (from tb_e in db.tb_marital_status
                       where tb_e.marital_status == estado
                       select tb_e.id).ToList();

            pat.id_marital_status = est.First();

            //Seguro 
            if (dgvregistrar.CurrentRow.Cells[9].Value.ToString() == "True") pat.seguro = true;
            if (dgvregistrar.CurrentRow.Cells[9].Value.ToString() == "False") pat.seguro = false;

            //Seguro
            string nom_seg = dgvregistrar.CurrentRow.Cells[10].Value.ToString();

            var n_s = (from tb_s in db.tb_health_insurance
                       where tb_s.name == nom_seg
                       select tb_s.id).ToList();
            pat.id_health_insurance = n_s.First();

            pat.id_clinic_history =Convert.ToInt32(dgvregistrar.CurrentRow.Cells[11].Value.ToString());

            pat.hopital_perteneciente = dgvregistrar.CurrentRow.Cells[12].Value.ToString();

            pat.address = dgvregistrar.CurrentRow.Cells[13].Value.ToString();

            //Distrito
            string distrito = dgvregistrar.CurrentRow.Cells[14].Value.ToString();

            var dis = (from d in db.tb_district
                       where d.district == distrito
                       select d.id).ToList();
            pat.id_district = dis.First();

            pat.state = false;

            db.Entry(pat).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            Listar();
            Limpiar();
            Desactivar();
        }

        private void rbtsi_CheckedChanged(object sender, EventArgs e)
        {
            cboseguro.Enabled = true;
            txtnomperte.Enabled = true;
        }

        private void rbtno_CheckedChanged(object sender, EventArgs e)
        {
            cboseguro.Enabled = false;
            txtnomperte.Enabled = false;
        }
    }
}
