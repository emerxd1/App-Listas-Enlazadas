using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            oSw.Start();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            TimeSpan Ots = new TimeSpan(0, 0, 0, 0, (int)oSw.ElapsedMilliseconds);

            txtMin.Text = Ots.Minutes.ToString().Length < 2 ? "0" + Ots.Minutes.ToString() : Ots.Minutes.ToString();
            txtSeconds.Text = Ots.Seconds.ToString().Length < 2 ? "0" + Ots.Seconds.ToString() : Ots.Seconds.ToString();
            txtMil.Text = Ots.Milliseconds.ToString();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            oSw.Reset();
            timer1.Enabled = false;
            txtMin.Text = "00";
            txtSeconds.Text = "00";
            txtMil.Text = "000";
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            oSw.Stop();

        }

        private void Shift_Load(object sender, EventArgs e)
        {
            LinkedList<String> Estudiantes = new LinkedList<String>();//instancia de la lista

            lbTurnos.Items.Add("Juan Gonzalez");
            lbTurnos.Items.Add("Pepe Lopez");
            lbTurnos.Items.Add("Maria Garcia");
            lbTurnos.Items.Add("Lucas Perez");
            lbTurnos.Items.Add("Abraham Guido");
            lbTurnos.Items.Add("Juan Rodriguez");
            lbTurnos.Items.Add("Luisa Soza");
            lbTurnos.Items.Add("Carlos Sanchez");
            lbTurnos.Items.Add("Sofia Martinez");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newname = Interaction.InputBox("Seleccione una opcion:");
            if (!string.IsNullOrWhiteSpace(newname))
            {
                lbTurnos.Items.Add(newname);
            }
        }
    }
}
