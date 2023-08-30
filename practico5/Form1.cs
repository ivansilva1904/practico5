using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void BUT_GUARDAR_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(TXB_NOMBRE.Text) && 
                !string.IsNullOrWhiteSpace(TXB_APELLIDO.Text) &&
                !string.IsNullOrWhiteSpace(TXB_SALDO.Text) &&
                !string.IsNullOrWhiteSpace(TXB_FOTO.Text))
            {
                var index = this.DGV_EMPLEADO.Rows.Add();

                DGV_EMPLEADO.Rows[index].Cells[0].Value = TXB_NOMBRE.Text;
                DGV_EMPLEADO.Rows[index].Cells[1].Value = TXB_APELLIDO.Text;
                DGV_EMPLEADO.Rows[index].Cells[2].Value = TXB_SALDO.Text;
                DGV_EMPLEADO.Rows[index].Cells[3].Value = TXB_FOTO.Text;
                DGV_EMPLEADO.Rows[index].Cells[4].Value = TXB_FOTO.Text;
                DGV_EMPLEADO.Rows[index].Cells[5].Value = TXB_FOTO.Text;

                //DGV_EMPLEADO.Rows[].;
            }
        }
    }
}
