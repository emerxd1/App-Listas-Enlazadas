namespace LabListas
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 125)
            {
                panelMenu.Width = 50
                    ;
            }
            else
            {
                panelMenu.Width = 125;
            }
        }
        private void btInventory_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new Inventario());
        }


        private void MostrarFormulario(Form formulario)
        {
            if (this.PanelContenedor.Controls.Count > 0)// para que no se repita el formulario y se muestre en el panel contenedor
                this.PanelContenedor.Controls.RemoveAt(0);//elimina el formulario que se encuentra en el panel contenedor
            {
                Form frm = formulario;//crea una instancia del formulario que se va a mostrar
                formulario.TopLevel = false;//para que el formulario se muestre dentro del panel contenedor
                formulario.FormBorderStyle = FormBorderStyle.None;//para que el formulario no tenga bordes
                formulario.BackColor = Color.FromArgb(64, 64, 64);//para que el formulario tenga el mismo color que el panel contenedor
                PanelContenedor.Controls.Add(formulario);//agrega el formulario al panel contenedor


                formulario.Dock = DockStyle.Fill;//para que el formulario se ajuste al tamaño del panel contenedor
                PanelContenedor.Tag = formulario;//para que el formulario se pueda identificar dentro del panel contenedor
                formulario.Show();//para que el formulario se muestre
                formulario.BringToFront();//para que el formulario se muestre al frente de los demás controles del panel contenedor
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new Shift());
        }
    }
}

