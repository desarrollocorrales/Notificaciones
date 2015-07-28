using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToastNotifications.Entity;

namespace ToastNotifications.GUIs
{
    public partial class Frm_Eventos : Form
    {
        private EventosEntities contexto;
        private eventos evento;

        public Frm_Eventos(eventos evento)
        {
            InitializeComponent();
            this.evento = evento;
        }

        private void Frm_Eventos_Load(object sender, EventArgs e)
        {
            PrepararFormulario();
            contexto = new EventosEntities();
            if (this.evento != null)
            {
                CargarEvento();
            }            
        }
        
        private void PrepararFormulario()
        {
            cbDiaSemana.SelectedIndex = 0;
        }

        private void rbPorSemana_CheckedChanged(object sender, EventArgs e)
        {
            cbDiaSemana.Enabled = rbPorSemana.Checked;
        }

        private void rbPorDia_CheckedChanged(object sender, EventArgs e)
        {
            nudDiaEvento.Enabled = rbPorDia.Checked;
            nudDiasRecordatorio.Enabled = rbPorDia.Checked;
        }

        #region * * *  MODIFICAR EVENTO  * * *
        /// <summary>
        /// Cargar datos de el evento para MODIFICAR
        /// </summary>
        private void CargarEvento()
        {
            this.Text = "Modificar Evento";
            lblTitulo.Text = "Modificar Evento";

            txbNombre.Text = this.evento.nombre;
            txbDescripcion.Text = this.evento.descripcion;
            txbCantidad.Text = Convert.ToString(this.evento.cantidad);
            txbBanco.Text = this.txbBanco.Text;
            txbCuantaBancaria.Text = this.evento.cuenta_bancaria;
            txbNotas.Text = this.evento.notas;
        }

        private void CargarTipoEvento(tipos_evento te)
        {
            rbTodos.Checked = true;

            if (te != null)
            {
                switch (te.id_tipo_evento)
                {
                    case "T": rbTodos.Checked = true;
                        break;
                    case "P": rbPares.Checked = true;
                        break;
                    case "N": rbNones.Checked = true;
                        break;
                }
            }
        }
        private void CargarDias(eventos e)
        {
            if (e != null)
            {
                if (e.es_semanal == true)
                {
                    //Es un recordatorio semanal
                    rbPorSemana.Checked = true;

                    switch (e.dia_semana)
                    {
                        case "L": cbDiaSemana.SelectedIndex = 1; break;
                        case "M": cbDiaSemana.SelectedIndex = 2; break;
                        case "X": cbDiaSemana.SelectedIndex = 3; break;
                        case "J": cbDiaSemana.SelectedIndex = 4; break;
                        case "V": cbDiaSemana.SelectedIndex = 5; break;
                        case "S": cbDiaSemana.SelectedIndex = 6; break;
                    }
                }
                else
                {
                    //Es un recodatorio por dia del mes
                    rbPorDia.Checked = true;
                    nudDiaEvento.Value = Convert.ToDecimal(e.dia_limite);
                }
            }
        }
        #endregion
       
        #region * * *  NUEVO EVENTO  * * *
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
                MessageBox.Show("OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Guardar()
        {
            eventos nuevo_evento = obtenerDatosEvento();
            obtenerDetallesEvento(ref nuevo_evento);
            nuevo_evento.tipos_evento = obtenerTipoEvento();

            contexto.eventos.AddObject(nuevo_evento);

            contexto.SaveChanges();
        }
        private tipos_evento obtenerTipoEvento()
        {
            tipos_evento te = new tipos_evento();

            if (rbTodos.Checked == true) te = contexto.tipos_evento.FirstOrDefault(o => o.id_tipo_evento == "T");            
            else if (rbPares.Checked == true) te = contexto.tipos_evento.FirstOrDefault(o => o.id_tipo_evento == "P");            
            else te = contexto.tipos_evento.FirstOrDefault(o => o.id_tipo_evento == "N");

            return te;
        }
        private void obtenerDetallesEvento(ref eventos e)
        {

            if (rbPorSemana.Checked == true)
            {
                //crear el detalle para notificacion semanal
                e.es_semanal = true;
                switch(cbDiaSemana.SelectedIndex)
                {
                    case 1: e.dia_semana = "L"; break;
                    case 2: e.dia_semana = "M"; break;
                    case 3: e.dia_semana = "X"; break;
                    case 4: e.dia_semana = "J"; break;
                    case 5: e.dia_semana = "V"; break;
                    case 6: e.dia_semana = "S"; break;
                }
                e.dia_limite = null;
            }
            else
            {
                //crear el detalle para cierto dia del mes.
                e.es_semanal = false;
                e.dia_semana = string.Empty;

                e.dia_limite = Convert.ToByte(nudDiaEvento.Value);
            }
        }

        private eventos obtenerDatosEvento()
        {
            eventos nuevo_evento = new eventos();

            nuevo_evento.nombre = txbNombre.Text;
            nuevo_evento.descripcion = txbDescripcion.Text;
            nuevo_evento.cantidad = Convert.ToDecimal(txbCantidad.Text);
            nuevo_evento.banco = txbBanco.Text;
            nuevo_evento.cuenta_bancaria = txbCuantaBancaria.Text;
            nuevo_evento.notas = txbNotas.Text;
            nuevo_evento.activo = true;
            return nuevo_evento;
        }

        #endregion

    }
}
