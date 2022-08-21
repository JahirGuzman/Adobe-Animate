using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPEE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNSaludo_Click(object sender, EventArgs e)
        {
            string NombreUsuario;
            string Sexo;

            NombreUsuario = TxtNombre.Text;
            Sexo = CbxSexo.Text.ToLower();

            MessageBox.Show("Hola mundo. Soy " + NombreUsuario + ", mi genero es " + Sexo + " y este es mi primer programa en lenguaje C#.");
        }

        private void BtnDialogoProyecto_Click(object sender, EventArgs e)
        {
            DlgProyecto dlgProyecto;

            dlgProyecto = new DlgProyecto();
            dlgProyecto.ShowDialog();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            DgvCarrito.Rows.Clear();
            TxtPeso.Text = "";
            TxtFragilidad.Text = "";
        }

        private void BtnLlenar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                DgvCarrito.Rows.Add();
                DgvCarrito.Rows[i].Cells[0].Value = i + 1; //Numero de Item
                DgvCarrito.Rows[i].Cells[1].Value = "Producto " + (i + 1); //Producto
                DgvCarrito.Rows[i].Cells[2].Value = 1; //Cantidad
                DgvCarrito.Rows[i].Cells[3].Value = 2; //Peso
                DgvCarrito.Rows[i].Cells[4].Value = 1; //Fragilidad
            }
        }

        private void BtnCalcularEnvio_Click(object sender, EventArgs e)
        {
            double PesoTotal;
            int FragilidadFinal;
            int NumItems;
            int i;

            i = 0;

            PesoTotal = 0;
            FragilidadFinal = 0;
            NumItems = DgvCarrito.Rows.Count - 1;

            while (i < NumItems)
            {
                int Cantidad;
                int FragilidadItem;
                double PesoUnitario;

                Cantidad = Convert.ToInt32(DgvCarrito.Rows[i].Cells[2].Value);
                PesoUnitario = Convert.ToDouble(DgvCarrito.Rows[i].Cells[3].Value);
                FragilidadItem = Convert.ToInt32(DgvCarrito.Rows[i].Cells[4].Value);

                PesoTotal = PesoTotal + (Cantidad * PesoUnitario);

                if (FragilidadItem > FragilidadFinal)
                {
                    FragilidadFinal = FragilidadItem;
                }

                i++;
            }
            TxtPeso.Text = "El peso total es de " + PesoTotal.ToString() + " Kg.";
            TxtFragilidad.Text = "La fragilidad final es  " + FragilidadFinal.ToString() + ".";
            //MessageBox.Show(NumItems.ToString() );
        }
    }
}
