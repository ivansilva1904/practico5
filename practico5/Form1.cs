using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Reflection;

namespace practico5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BUT_FOTO_Click(object sender, EventArgs e)
        {
            if(OPFD_FOTO.ShowDialog() == DialogResult.OK)
            {
                OPFD_FOTO.InitialDirectory = "C:";
                OPFD_FOTO.Filter = "Archivos de imagenes (*.jpg)|*.jpg|Archivos de imagenes (*.png)|*.png";
                PICBOX_FOTO.ImageLocation = OPFD_FOTO.FileName;
                PICBOX_FOTO.BackgroundImage = null;
            }

        }

        private void BUT_GUARDAR_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(TXB_NOMBRE.Text) && 
                !string.IsNullOrWhiteSpace(TXB_APELLIDO.Text) &&
                !string.IsNullOrWhiteSpace(TXB_SALDO.Text) &&
                !string.IsNullOrWhiteSpace(TXB_FOTO.Text) &&
                (RBUT_HOMBRE.Checked == true || RBUT_MUJER.Checked == true))
            {
                var index = this.DGV_EMPLEADO.Rows.Add();
                string sexo;
                string nombre = TXB_NOMBRE.Text.ToUpper().Substring(0, 1) + TXB_NOMBRE.Text.ToLower().Substring(1);
                string apellido = TXB_APELLIDO.Text.ToUpper().Substring(0, 1) + TXB_APELLIDO.Text.ToLower().Substring(1);

                if(RBUT_HOMBRE.Checked == true)
                {
                    sexo = "Hombre";
                }
                else
                {
                    sexo = "Mujer";
                }
                DGV_EMPLEADO.Columns[0].DefaultCellStyle.Font = new Font("Comic Sans MS", 8);
                DGV_EMPLEADO.Columns[1].DefaultCellStyle.Font = new Font("Comic Sans MS", 8);

                DGV_EMPLEADO.Rows[index].Cells[0].Value = nombre;
                DGV_EMPLEADO.Rows[index].Cells[1].Value = apellido;
                DGV_EMPLEADO.Rows[index].Cells[2].Value = DATEPICK_FECNAC.Value.ToShortDateString();
                DGV_EMPLEADO.Rows[index].Cells[3].Value = sexo;
                DGV_EMPLEADO.Rows[index].Cells[4].Value = TXB_SALDO.Text;
                DGV_EMPLEADO.Rows[index].Cells[5].Value = Image.FromFile(OPFD_FOTO.FileName);
                DGV_EMPLEADO.Rows[index].Cells[6].Value = TXB_FOTO.Text;

                if (Convert.ToInt32(DGV_EMPLEADO.Rows[index].Cells[4].Value) < 50)
                {
                    DGV_EMPLEADO.Rows[index].DefaultCellStyle.BackColor = Color.Red;
                    DGV_EMPLEADO.Rows[index].DefaultCellStyle.ForeColor = Color.White;
                }

                string rutaArchivo = OPFD_FOTO.FileName.ToString();
                File.Copy(rutaArchivo, TXB_FOTO.Text);

                this.limpiar_campos();
            }
            else
            {
                MessageBox.Show("Faltan campos por completar",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void TXB_SALDO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TXB_NOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TXB_APELLIDO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OPFD_FOTO_FileOk(object sender, CancelEventArgs e)
        {
            string rutaProyecto = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase).Remove(0, 6);

            string rutaArchivo = OPFD_FOTO.FileName.ToString();

            FileInfo archivo = new FileInfo(rutaArchivo);

            string archivoNombre = archivo.Name;

            string destino = rutaProyecto + "/fotos/" + archivoNombre;

            destino = destino.Replace("\\", "/");

            TXB_FOTO.Text = destino;
        }

        private void DGV_EMPLEADO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row (si, me robe este codigo)
            if (e.RowIndex == DGV_EMPLEADO.NewRowIndex || e.RowIndex < 0)
            {
                return;
            }

            //Check if click is on specific column 
            if(e.ColumnIndex == DGV_EMPLEADO.Columns["eliminar"].Index)
            {
                DialogResult resp = MessageBox.Show("Seguro desea eliminar el registro?",
                    "Advertencia", MessageBoxButtons.YesNo);
                if (resp == DialogResult.Yes)
                {
                    DGV_EMPLEADO.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
        private void DGV_EMPLEADO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = DGV_EMPLEADO.CurrentCell.OwningRow;

            if(e.ColumnIndex == DGV_EMPLEADO.Columns["sexo"].Index)
            {
                if (fila.Cells["sexo"].Value.ToString() == "Hombre")
                {
                    RBUT_HOMBRE.Checked = true;
                }
                else
                {
                    RBUT_MUJER.Checked = true;
                }
            }
        }

        private void limpiar_campos()
        {
            TXB_NOMBRE.Clear();
            TXB_APELLIDO.Clear();
            RBUT_HOMBRE.Checked = false;
            RBUT_MUJER.Checked = false;
            TXB_SALDO.Clear();
            TXB_FOTO.Clear();
            PICBOX_FOTO.ImageLocation = null;
            PICBOX_FOTO.BackgroundImage = Properties.Resources.v937_aew_111_3;
        }

    }
}
