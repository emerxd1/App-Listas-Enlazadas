using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static LabListas.Inventario;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabListas
{
    public partial class adduser : Form
    {
        // Referencia al formulario Shift que abrio este (para operar sobre SU lista Clientes)
        private readonly Shift _shift;

        public adduser(Shift shift)
        {
            InitializeComponent();
            _shift = shift; // guardo la referencia recibida
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addlast_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Ingrese un nombre válido.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                return;
            }

            // Validar duplicados contra la lista real de Shift
            if (_shift.ExisteCliente(textBox1.Text))
            {
                MessageBox.Show("El cliente ya existe en la lista.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                return;
            }

            // Agrega al final de la lista de Shift y refresca turno/ListBox
            _shift.AgregarClienteLast(textBox1.Text);

            textBox1.Clear();
        }

        private void adduser_Load(object sender, EventArgs e)
        {

        }

        private void addfirst_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Ingrese un nombre válido.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                return;
            }

            // Validar duplicados contra la lista real de Shift
            if (_shift.ExisteCliente(textBox1.Text))
            {
                MessageBox.Show("El cliente ya existe en la lista.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                return;
            }

            // Agrega al principio de la lista de Shift y refresca turno/ListBox
            _shift.AgregarClienteFirst(textBox1.Text);

            textBox1.Clear();
        }

        private void btnAddAt_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Ingrese un nombre válido.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                return;
            }

            // Validar duplicados contra la lista real de Shift
            if (_shift.ExisteCliente(textBox1.Text))
            {
                MessageBox.Show("El cliente ya existe en la lista.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                return;
            }

            // Pedir el indice donde insertar (0 = primero, Cantidad = al final)
            string input = Interaction.InputBox(
                "Ingrese el índice donde desea insertar (0 = primero):",
                "Agregar por índice", "0");

            if (!int.TryParse(input, out int index) || index < 0 || index > _shift.CantidadClientes())
            {
                MessageBox.Show("Índice inválido.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Inserta en esa posicion dentro de la lista de Shift y refresca turno/ListBox
            _shift.AgregarClienteAt(textBox1.Text, index);

            textBox1.Clear();
        }
    }
}