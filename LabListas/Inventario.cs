using LabListas.Utilities;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static LabListas.Utilities.OptionsComboboxx;

namespace LabListas
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        ListaEnlazada<Producto> productos = new ListaEnlazada<Producto>();

        public class Producto
        {
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public double Precio { get; set; }
            public double SubTotal => Cantidad * Precio; // propiedad calculada
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            productos = new ListaEnlazada<Producto>();

            productos.AddLast(new Producto { Nombre = "Teclado", Cantidad = 15, Precio = 25.09 });
            productos.AddLast(new Producto { Nombre = "Mouse", Cantidad = 30, Precio = 12.50 });
            productos.AddLast(new Producto { Nombre = "Monitor", Cantidad = 5, Precio = 199.99 });

            foreach (Producto producto in productos)
            {
                dgvInventario.Rows.Add(producto.Nombre, producto.Cantidad, producto.Precio.ToString("F2"), producto.SubTotal.ToString("F2"));
            }

            double valorTotal = productos.Sum(p => p.SubTotal);
            label2.Text = $"Valor total del inventario: {valorTotal:F2}";

            // Agregar columnas al ComboBox cbBusqueda Y PARA BUSCAR POR FILTROS
            foreach (DataGridViewColumn Columna in dgvInventario.Columns)
            {
                if (Columna.Visible == true)
                {
                    cbBusqueda.Items.Add(new OptionsComboboxx.OptionsComboBox() { valor = Columna.Name, texto = Columna.HeaderText });
                }
            }
            cbBusqueda.ValueMember = "valor";
            cbBusqueda.DisplayMember = "texto"; 
            if (cbBusqueda.Items.Count > 0)
            {
                cbBusqueda.SelectedIndex = 0;
            }

            lblFirst.Text = $"Primer Producto: {productos.First?.Value.Nombre ?? "N/A"}";
            lblLast.Text = $"Ultimo Producto: {productos.Last?.Value.Nombre ?? "N/A"}";
            lblNext.Text = $"Siguiente(Nuevo) Producto: {productos.First?.Next?.Value.Nombre ?? "N/A"}";
            lblProducto.Text = $"Productos Totales: " + dgvInventario.Rows.Count;
        }

        /*---------------PARA AGREGAR PRODUCTOS DE ULTIMO--------------*/

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(textBox1.Text) || int.TryParse(textBox1.Text, out int id) ||
                !int.TryParse(textBox2.Text, out int cantidad) || cantidad <= 0 ||
                !double.TryParse(textBox3.Text, out double precio) || precio <= 0)
            {
                MessageBox.Show("Completa los campos con valores validos.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
                return;
            }

            if (productos.Any(p => p.Nombre.Equals(textBox1.Text, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("El producto ya existe en el inventario.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
                return;
            }

            // Crear y agregar producto
            Producto nuevo = new Producto { Nombre = textBox1.Text, Cantidad = cantidad, Precio = precio };
            productos.AddLast(nuevo);

            // lo agrega al DataGridView
            dgvInventario.Rows.Add(nuevo.Nombre, nuevo.Cantidad, nuevo.Precio.ToString("F2"), nuevo.SubTotal.ToString("F2"));

            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";

            double valorTotal = productos.Sum(p => p.SubTotal);
            label2.Text = $"Valor total del inventario: {valorTotal:F2}";
            lblProducto.Text = $"Productos Totales: " + dgvInventario.Rows.Count;
            lblFirst.Text = $"Primer Producto: {productos.First?.Value.Nombre ?? "N/A"}";
            lblLast.Text = $"Ultimo Producto: {productos.Last?.Value.Nombre ?? "N/A"}";
            lblNext.Text = $"Siguiente Producto: {productos.First?.Next?.Value.Nombre ?? "N/A"}"; 


        }

        /*---------------PARA ELIMINAR PRODUCTOS MENOR A 10 EN STOCK--------------*/

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox3.Text, out double precioIngresado))
            {
                MessageBox.Show("Ingresa precio valido.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
                return;
            }

            int eliminados = 0;
            var actual = productos.First;
            Nodo<Producto> anterior = null;

            while (actual != null)
            {
                var siguiente = actual.Next; // guarda referencia antes de eliminar

                if (actual.Value.Nombre.Equals(textBox1.Text, StringComparison.OrdinalIgnoreCase)
                    && actual.Value.Precio == precioIngresado
                    && actual.Value.Cantidad <= 10)
                {
                    productos.Remove(actual, anterior); // elimina el nodo actual
                    eliminados++;
                    // "anterior" no se mueve: el nodo actual ya no forma parte de la cadena
                }
                else
                {
                    anterior = actual; // solo avanza si NO se elimino
                }

                actual = siguiente;
            }

            // Refresca el DataGridView
            dgvInventario.Rows.Clear();
            foreach (Producto producto in productos)
            {
                dgvInventario.Rows.Add(producto.Nombre, producto.Cantidad, producto.Precio.ToString("F2"), producto.SubTotal.ToString("F2"));
            }

            if (eliminados > 0)
            {
                MessageBox.Show($"Se eliminaron {eliminados} producto(s) con stock menor o igual a 10.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
            }
            else
            {
                MessageBox.Show("No se encontraron productos que cumplan la condicion.",
                                "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
            }

            double valorTotal = productos.Sum(p => p.SubTotal);
            label2.Text = $"Valor total del inventario: {valorTotal:F2}";
            lblProducto.Text = $"Productos Totales: " + dgvInventario.Rows.Count;
            lblFirst.Text = $"Primer Producto: {productos.First?.Value.Nombre ?? "N/A"}";
            lblLast.Text = $"Ultimo Producto: {productos.Last?.Value.Nombre ?? "N/A"}";
            lblNext.Text = $"Siguiente Producto: {productos.First?.Next?.Value.Nombre ?? "N/A"}"; //

        }

        /*FILTRA LAS BUSQUEDAS Y BUSCAR*/
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnFiltro = Convert.ToString(((OptionsComboBox)cbBusqueda.SelectedItem).valor);

            if (dgvInventario.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvInventario.Rows)
                {
                    if (row.Cells[columnFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
            lblProducto.Text = $"Productos Totales: " + dgvInventario.Rows.Count;

        }

        /*PARA LIMPIAR BUSQUEDAS Y RESTAURAR*/
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";

            foreach (DataGridViewRow row in dgvInventario.Rows)
            {
                row.Visible = true;
            }
        }


        /*PARA AGREGAR DE PRIMEROOO*/
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || int.TryParse(textBox1.Text, out int id) ||
                !int.TryParse(textBox2.Text, out int cantidad) || cantidad <= 0 ||
                !double.TryParse(textBox3.Text, out double precio) || precio <= 0)
            {
                MessageBox.Show("Completa los campos con valores validos.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
                return;
            }

            if (productos.Any(p => p.Nombre.Equals(textBox1.Text, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("El producto ya existe en el inventario.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
                return;
            }

            Producto nuevo = new Producto { Nombre = textBox1.Text, Cantidad = cantidad, Precio = precio };
            productos.AddFirst(nuevo); // 

            // se agrego al inicio de la LISTA, tambien debe ir al inicio del GRID
            dgvInventario.Rows.Insert(0, nuevo.Nombre, nuevo.Cantidad, nuevo.Precio.ToString("F2"), nuevo.SubTotal.ToString("F2"));

            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";

            double valorTotal = productos.Sum(p => p.SubTotal);
            label2.Text = $"Valor total del inventario: {valorTotal:F2}";
            lblProducto.Text = $"Productos Totales: " + dgvInventario.Rows.Count;
            lblFirst.Text = $"Primer Producto: {productos.First?.Value.Nombre ?? "N/A"}";
            lblLast.Text = $"Ultimo Producto: {productos.Last?.Value.Nombre ?? "N/A"}";
            lblNext.Text = $"Siguiente(Nuevo) Producto: {productos.First?.Next?.Value.Nombre ?? "N/A"}";


        }


        /*PARA AGREGAR POR INDICE*/
        private void button2_Click(object sender, EventArgs e)
        { 
            // Validaciones de los campos del producto
            if (string.IsNullOrWhiteSpace(textBox1.Text) || int.TryParse(textBox1.Text, out int id) ||
                !int.TryParse(textBox2.Text, out int cantidad) || cantidad <= 0 ||
                !double.TryParse(textBox3.Text, out double precio) || precio <= 0)
            {
                MessageBox.Show("Completa los campos con valores validos.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";

                return;
            }

            // Pedimos el indice
            string respuesta = Interaction.InputBox(
                "IngresE el indice donde deseas insertar el producto(0 = inicio):",
                "Insertar producto",
                "0"
            );

            // Si el usuario cancela o cierra la ventana
            if (string.IsNullOrWhiteSpace(respuesta))
            {
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";

                return; // el usuario cancelo, no hacemos nada
            }

            if (!int.TryParse(respuesta, out int index))
            {
                MessageBox.Show("El indice debe ser un numero entero.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";

                return;// el usuario ingreso un valor no numerico
            }

            int cantidadProductos = productos.Count();
            if (index < 0 || index > cantidadProductos)
            {
                MessageBox.Show($"El indice debe estar entre 0 y {cantidadProductos}.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";

                return;// el usuario ingreso un indice fuera de rango
            }

            if (productos.Any(p => p.Nombre.Equals(textBox1.Text, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("El producto ya existe en el inventario.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";

                return;// el producto ya existe, no se puede agregar
            }

            Producto nuevo = new Producto { Nombre = textBox1.Text, Cantidad = cantidad, Precio = precio };
            productos.AddAt(index, nuevo);// agregamos el producto en la lista enlazada en la posición especificada

            int indiceGrid = Math.Min(index, dgvInventario.Rows.Count);
            dgvInventario.Rows.Insert(indiceGrid, nuevo.Nombre, nuevo.Cantidad, nuevo.Precio.ToString("F2"), nuevo.SubTotal.ToString("F2"));// agregamos el producto en el DataGridView en la posición especificada

            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
            double valorTotal = productos.Sum(p => p.SubTotal);
            label2.Text = $"Valor total del inventario: {valorTotal:F2}";
            lblProducto.Text = $"Productos Totales: " + dgvInventario.Rows.Count;
            lblFirst.Text = $"Primer Producto: {productos.First?.Value.Nombre ?? "N/A"}";
            lblLast.Text = $"Ultimo Producto: {productos.Last?.Value.Nombre ?? "N/A"}";
            lblNext.Text = $"Siguiente Producto: {productos.First?.Next?.Value.Nombre ?? "N/A"}"; // agregada, antes faltaba



        }
    }
}