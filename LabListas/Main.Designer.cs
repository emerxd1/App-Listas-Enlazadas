namespace LabListas
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            elipseControl1 = new ElipseControl.ElipseControl();
            panelMenu = new Panel();
            button2 = new Button();
            btnInventory = new Button();
            panel2 = new Panel();
            btnMax = new Button();
            btnMin = new Button();
            button1 = new Button();
            btnExit = new Button();
            PanelContenedor = new Panel();
            elipseControl2 = new ElipseControl.ElipseControl();
            elipseControl3 = new ElipseControl.ElipseControl();
            panelMenu.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 25;
            elipseControl1.TargetControl = this;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Gray;
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(btnInventory);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(125, 550);
            panelMenu.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 127);
            button2.Name = "button2";
            button2.Size = new Size(124, 50);
            button2.TabIndex = 5;
            button2.Text = "Turnos";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.Gray;
            btnInventory.Cursor = Cursors.Hand;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventory.Image = (Image)resources.GetObject("btnInventory.Image");
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.Location = new Point(0, 73);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(124, 50);
            btnInventory.TabIndex = 4;
            btnInventory.Text = "Inventario";
            btnInventory.TextAlign = ContentAlignment.MiddleRight;
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(btnMax);
            panel2.Controls.Add(btnMin);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnExit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(125, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(713, 40);
            panel2.TabIndex = 2;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.BackColor = Color.FromArgb(64, 64, 64);
            btnMax.Cursor = Cursors.Hand;
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.Image = (Image)resources.GetObject("btnMax.Image");
            btnMax.Location = new Point(682, 6);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(27, 27);
            btnMax.TabIndex = 5;
            btnMax.UseVisualStyleBackColor = false;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.BackColor = Color.FromArgb(64, 64, 64);
            btnMin.Cursor = Cursors.Hand;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Image = (Image)resources.GetObject("btnMin.Image");
            btnMin.Location = new Point(649, 6);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(27, 27);
            btnMin.TabIndex = 4;
            btnMin.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(5, 2);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(64, 64, 64);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(616, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(27, 27);
            btnExit.TabIndex = 2;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += button1_Click_1;
            // 
            // PanelContenedor
            // 
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(125, 40);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(713, 510);
            PanelContenedor.TabIndex = 3;
            // 
            // elipseControl2
            // 
            elipseControl2.CornerRadius = 15;
            elipseControl2.TargetControl = panelMenu;
            // 
            // elipseControl3
            // 
            elipseControl3.CornerRadius = 35;
            elipseControl3.TargetControl = panel2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(838, 550);
            Controls.Add(PanelContenedor);
            Controls.Add(panel2);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new Inventario());
        }

        #endregion

        private ElipseControl.ElipseControl elipseControl1;
        private Panel panelMenu;
        private Panel panel2;
        private Button btnExit;
        private Panel PanelContenedor;
        private Button button1;
        private Button btnInventory;
        private ElipseControl.ElipseControl elipseControl2;
        private ElipseControl.ElipseControl elipseControl3;
        private Button button2;
        private Button btnMax;
        private Button btnMin;
    }
}
