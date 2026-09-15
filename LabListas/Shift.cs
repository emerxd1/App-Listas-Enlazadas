using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabListas
{
    public partial class Shift : Form
    {
        Stopwatch oSw = new Stopwatch(); //instancia    
        public Shift()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        // Generados por el diseñador al hacer doble clic en nCabeza / nCola. Se dejan vacíos.
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            oSw.Start();
            timer1.Enabled = true;
        }

        // Marca en milisegundos del cronometro en el que se hizo el ultimo cambio de turno automatico
        private long ultimoCambioMs = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!oSw.IsRunning)
                return;

            TimeSpan Ots = new TimeSpan(0, 0, 0, 0, (int)oSw.ElapsedMilliseconds);

            txtMin.Text = Ots.Minutes.ToString().Length < 2 ? "0" + Ots.Minutes.ToString() : Ots.Minutes.ToString();
            txtSeconds.Text = Ots.Seconds.ToString().Length < 2 ? "0" + Ots.Seconds.ToString() : Ots.Seconds.ToString();
            txtMil.Text = Ots.Milliseconds.ToString();

            // Cada 10 segundos de cronometro corrido, avanza automaticamente de turno
            if (oSw.ElapsedMilliseconds - ultimoCambioMs >= 5000)
            {
                ultimoCambioMs += 5000;
                AvanzarTurnoAutomatico();
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            oSw.Reset();
            timer1.Enabled = false;
            ultimoCambioMs = 0;
            txtMin.Text = "00";
            txtSeconds.Text = "00";
            txtMil.Text = "000";
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            oSw.Stop();

        }

        // Lista DOBLEMENTE enlazada (clase ListaDE, separada de Lista que usa Inventario)
        ListaDE<string> Clientes = new ListaDE<string>();

        // Nodo que representa el turno "actual" para poder navegar con Anterior/Siguiente
        NodoDE<string> nodoActual = null;

        private void Shift_Load(object sender, EventArgs e)
        {
            // Agregar clientes a la lista doblemente enlazada
            Clientes.AddLast("Juan Gonzalez");
            Clientes.AddLast("Pepe Lopez");
            Clientes.AddLast("Maria Garcia");
            Clientes.AddLast("Lucas Perez");
            Clientes.AddLast("Abraham Guido");
            Clientes.AddLast("Juan Rodriguez");
            Clientes.AddLast("Luisa Soza");
            Clientes.AddLast("Carlos Sanchez");
            Clientes.AddLast("Sofia Martinez");

            // Muestra en el ListBox
            lbTurnos.Items.Clear();
            foreach (string cliente in Clientes)
            {
                lbTurnos.Items.Add(cliente);
            }

            // Empezamos posicionados en el primer turno
            nodoActual = Clientes.First;
            ultimoCambioMs = 0;
            ActualizarTurnoActual();
        }

        // Recorre la lista para saber en que posicion (1-based) esta un nodo y cuantos hay en total
        private (int posicion, int total) ObtenerPosicion(NodoDE<string> nodo)
        {
            int total = 0;
            int posicion = -1;
            var actual = Clientes.First;
            int i = 0;
            while (actual != null)
            {
                i++;
                total++;
                if (actual == nodo)
                    posicion = i;
                actual = actual.Next;
            }
            return (posicion, total);
        }

        // Refresca todo lo relacionado al turno actual: labels, seleccion del ListBox y nodo cabeza/cola
        private void ActualizarTurnoActual()
        {
            if (nodoActual == null)
            {
                label2.Text = "Turno: -- Sin turnos --";
                label3.Text = "Estado: Sin turnos";
                label4.Text = "Posicion de Lista: 0 de 0";
                nCabeza.Text = "Nodo cabeza: N/A";
                nCola.Text = "Nodo cola: N/A";
                Tanterior.Text = "Turno anterior: --";
                Tsiguiente.Text = "Turno siguiente: --";
                lbTurnos.ClearSelected();
                return;
            }

            var (posicion, total) = ObtenerPosicion(nodoActual);

            label2.Text = $"Turno: ##{posicion:000} - {nodoActual.Value}";
            label3.Text = "Estado: En espera";
            label4.Text = $"Posicion de Lista: {posicion} de {total}";
            nCabeza.Text = $"Nodo cabeza: {Clientes.First?.Value ?? "N/A"}";
            nCola.Text = $"Nodo cola: {Clientes.Last?.Value ?? "N/A"}";
            Tanterior.Text = $"Turno anterior: {nodoActual.Previous?.Value ?? "-- Inicio de lista --"}";
            Tsiguiente.Text = $"Turno siguiente: {nodoActual.Next?.Value ?? "-- Fin de lista --"}";

            SeleccionarNodoActual();
        }

        // Resalta en el ListBox el nombre que corresponde al nodo actual
        private void SeleccionarNodoActual()
        {
            if (nodoActual == null)
                return;

            int indice = lbTurnos.Items.IndexOf(nodoActual.Value);
            if (indice >= 0)
                lbTurnos.SelectedIndex = indice;
        }

        // Avanza al siguiente nodo (Next) de la lista doblemente enlazada -- boton manual
        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (nodoActual?.Next == null)
            {
                MessageBox.Show("Ya estas en el ultimo turno de la lista.", "Informacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            nodoActual = nodoActual.Next;
            ActualizarTurnoActual();
        }

        // Retrocede al nodo anterior (Previous) de la lista doblemente enlazada -- boton manual
        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            if (nodoActual?.Previous == null)
            {
                MessageBox.Show("Ya estas en el primer turno de la lista.", "Informacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            nodoActual = nodoActual.Previous;
            ActualizarTurnoActual();
        }

        // Avance automatico llamado cada 10 segundos por el cronometro: rota al inicio si llega al final
        private void AvanzarTurnoAutomatico()
        {
            if (nodoActual == null)
                return;

            nodoActual = nodoActual.Next ?? Clientes.First; // si no hay siguiente, vuelve al primero (rotacion de turnos)
            ActualizarTurnoActual();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Se pasa "this" (el propio formulario Shift) en vez del ListBox,
            // asi adduser puede operar sobre la MISMA lista Clientes y refrescar turno/labels.
            adduser fh = new adduser(this);
            fh.Show();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (nodoActual == null)
            {
                MessageBox.Show("No hay ningun turno seleccionado para eliminar.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nombreEliminado = nodoActual.Value;

            // Antes de eliminar, decidimos a donde nos movemos despues:
            // preferimos el siguiente; si no hay siguiente, el anterior.
            NodoDE<string> siguientePosicion = nodoActual.Next ?? nodoActual.Previous;

            Clientes.Remove(nodoActual);
            lbTurnos.Items.Remove(nombreEliminado);

            nodoActual = siguientePosicion;
            ActualizarTurnoActual();

        }

        // =========================================================================
        // API PUBLICA para que otros formularios (por ej. adduser) modifiquen la
        // lista de turnos y todo se mantenga sincronizado (ListBox, turno actual,
        // labels, nodo cabeza/cola).
        // =========================================================================

        // Indica si ya existe un cliente con ese nombre (sin distinguir mayusculas/minusculas)
        public bool ExisteCliente(string nombre)
        {
            foreach (var c in Clientes)
            {
                if (c.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }

        // Cantidad actual de clientes en la lista (util para validar el indice al agregar por posicion)
        public int CantidadClientes()
        {
            return Clientes.Count();
        }

        public void AgregarClienteLast(string nombre)
        {
            Clientes.AddLast(nombre);
            if (nodoActual == null)
                nodoActual = Clientes.First; // si la lista estaba vacia, arrancamos el turno aca
            RefrescarListBoxYTurno();
        }

        public void AgregarClienteFirst(string nombre)
        {
            Clientes.AddFirst(nombre);
            if (nodoActual == null)
                nodoActual = Clientes.First;
            RefrescarListBoxYTurno();
        }

        // index es 0-based: 0 = insertar al principio, Clientes.Count() = insertar al final
        public void AgregarClienteAt(string nombre, int index)
        {
            Clientes.AddAt(index, nombre);
            if (nodoActual == null)
                nodoActual = Clientes.First;
            RefrescarListBoxYTurno();
        }

        // Vuelve a pintar el ListBox desde cero con el contenido actual de Clientes
        // y refresca los labels del turno actual (posicion, cabeza, cola, etc.)
        private void RefrescarListBoxYTurno()
        {
            lbTurnos.Items.Clear();
            foreach (string cliente in Clientes)
            {
                lbTurnos.Items.Add(cliente);
            }
            ActualizarTurnoActual();
        }
    }
}