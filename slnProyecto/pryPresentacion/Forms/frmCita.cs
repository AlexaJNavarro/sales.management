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
    public partial class frmCita : Form
    {
        db_clinicEntities db = new db_clinicEntities();
        tb_appointment cita = new tb_appointment();

        public frmCita()
        {
            InitializeComponent();
        }

        public void ListarCita() 
        {
            var listar = from tb_c in db.tb_appointment
                         join tb_d in db.tb_doctor on tb_c.id_doctor equals tb_d.id
                         join tb_p in db.tb_patient on tb_c.id_patient equals tb_p.id
                         join tb_r in db.tb_receptionist on tb_c.id_receptionist equals tb_r.id
                         join tb_e in db.tb_speciality on tb_d.id_speciality equals tb_e.id
                         where tb_c.state == true
                         select new
                         {
                             ID = tb_c.id,
                             ID_Paciente= tb_c.id_patient,
                             Nombre_Paciente= tb_p.name,
                             Hora= tb_c.hour,
                             Fecha= tb_c.date,
                             ID_Médico=tb_c.id_doctor,
                             Nombre_Médico= tb_d.name,
                             Área=tb_e.speciality,
                             ID_Recepcionista=tb_c.id_receptionist,
                             Nombre_Recepcionista=tb_r.name,
                             Estado= tb_c.state
                         };
            dgvcita.DataSource = listar.ToList();
        }

        public void ListarPaciente() 
        {
            var listar = from tb_d in db.tb_doctor
                         join tb_esp in db.tb_speciality on tb_d.id_speciality equals tb_esp.id
                         join tb_h in db.tb_hour on tb_d.id_hour equals tb_h.id_turn
                         join tb_t in db.tb_turn on tb_h.id_turn equals tb_t.id
                         select new
                         {
                             ID = tb_d.id,
                             Nombre = tb_d.name,
                             Ape_Paterno = tb_d.a_p,
                             Ape_Materno = tb_d.a_m,
                             DNI = tb_d.dni,
                             Contraseña = tb_d.password,
                             Especialidad = tb_esp.speciality,
                             Entrada = tb_h.entry,
                             Salida = tb_h.departure,
                             Turno = tb_t.turn

                         };
            dgvdoctor.DataSource = listar.ToList();
        }

        public void Limpiar() 
        {
            cboesp.SelectedIndex = -1;
            txtidpac.Clear();
            txthora.Clear();
            dtpfecha.Format = DateTimePickerFormat.Short;
            txtmed.Clear();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cita.hour = TimeSpan.Parse(txthora.Text);
                cita.date = dtpfecha.Value;
                cita.id_doctor = Convert.ToInt32(txtmed.Text);
                cita.id_patient = txtidpac.Text;
                cita.id_receptionist = Convert.ToInt32(Class.Usuario.usu);
                cita.state = true;


                db.tb_appointment.Add(cita);
                db.SaveChanges();
                ListarCita();
                Limpiar();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("El paciente no ha sido registrado");
            }
            

        }

        private void frmCita_Load(object sender, EventArgs e)
        {
            cboesp.DataSource = db.tb_speciality.ToList();
            cboesp.ValueMember = "id";
            cboesp.DisplayMember = "speciality";
            cboesp.SelectedIndex = -1;

            

            ListarPaciente();
            ListarCita();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(cboesp.SelectedValue);
            var listar = from tb_d in db.tb_doctor
                         join tb_esp in db.tb_speciality on tb_d.id_speciality equals tb_esp.id
                         join tb_h in db.tb_hour on tb_d.id_hour equals tb_h.id_turn
                         join tb_t in db.tb_turn on tb_h.id_turn equals tb_t.id
                         where tb_esp.id == valor
                         select new
                         {
                             ID = tb_d.id,
                             Nombre = tb_d.name,
                             Ape_Paterno = tb_d.a_p,
                             Ape_Materno = tb_d.a_m,
                             DNI = tb_d.dni,
                             Contraseña = tb_d.password,
                             Especialidad = tb_esp.speciality,
                             Entrada = tb_h.entry,
                             Salida = tb_h.departure,
                             Turno = tb_t.turn

                         };
            dgvdoctor.DataSource = listar.ToList();
        }

        private void dgvdoctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvdoctor.CurrentRow.Selected = true;
            txtmed.Text = dgvdoctor.CurrentRow.Cells[0].Value.ToString();
        }

        private void txthora_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            cita.id = int.Parse(lblcod.Text);
            cita.hour = TimeSpan.Parse(txthora.Text);
            cita.date = dtpfecha.Value;
            cita.id_doctor = Convert.ToInt32(txtmed.Text);
            cita.id_patient = txtidpac.Text;
            cita.id_receptionist = Convert.ToInt32(Class.Usuario.usu);
            cita.state = true;

            db.Entry(cita).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            ListarCita();
            Limpiar();
        }

        private void dgvcita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvcita.CurrentRow.Selected = true;

            lblcod.Text = dgvcita.CurrentRow.Cells[0].Value.ToString();

            string esp = dgvcita.CurrentRow.Cells[7].Value.ToString();

            var especialidad = (from tb_s in db.tb_speciality
                                where tb_s.speciality == esp
                                select tb_s.id).ToList();

            cboesp.SelectedValue = especialidad.First();

            txtidpac.Text = dgvcita.CurrentRow.Cells[1].Value.ToString();
            txthora.Text= dgvcita.CurrentRow.Cells[3].Value.ToString(); 
            dtpfecha.Value= Convert.ToDateTime(dgvcita.CurrentRow.Cells[4].Value.ToString());
            txtmed.Text= dgvcita.CurrentRow.Cells[5].Value.ToString();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            

            lblcod.Text = dgvcita.CurrentRow.Cells[0].Value.ToString();
            cita.id = int.Parse(dgvcita.CurrentRow.Cells[0].Value.ToString());

            cita.id_patient = dgvcita.CurrentRow.Cells[1].Value.ToString();
            cita.hour = TimeSpan.Parse(dgvcita.CurrentRow.Cells[3].Value.ToString());
            cita.date = Convert.ToDateTime(dgvcita.CurrentRow.Cells[4].Value.ToString());
            cita.id_doctor = int.Parse(dgvcita.CurrentRow.Cells[5].Value.ToString());
            cita.id_receptionist = Convert.ToInt32(Class.Usuario.usu);
            cita.state = false;
            


            db.Entry(cita).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            ListarCita();
            Limpiar();
        }
    }
}
