namespace LabListas
{
    partial class Inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnRemove = new Button();
            label2 = new Label();
            btnAdd = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            panelGradient1 = new Gradient.PanelGradient();
            dgvInventario = new DataGridView();
            colProducto = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            cbBusqueda = new ComboBox();
            label3 = new Label();
            txtBusqueda = new TextBox();
            btnBuscar = new Button();
            btnReset = new Button();
            button1 = new Button();
            btnAddAt = new Button();
            lblProducto = new Label();
            lblFirst = new Label();
            lblLast = new Label();
            lblNext = new Label();
            panelGradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Top;
            btnRemove.BackColor = Color.FromArgb(64, 64, 64);
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Image = (Image)resources.GetObject("btnRemove.Image");
            btnRemove.Location = new Point(57, 379);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(134, 53);
            btnRemove.TabIndex = 33;
            btnRemove.Text = "Eliminar";
            btnRemove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 575);
            label2.Name = "label2";
            label2.Size = new Size(187, 20);
            label2.TabIndex = 32;
            label2.Text = "Valor total del Inventario:";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top;
            btnAdd.BackColor = Color.FromArgb(64, 64, 64);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(57, 291);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 53);
            btnAdd.TabIndex = 31;
            btnAdd.Text = "Agregar(Last)";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top;
            textBox3.BackColor = Color.FromArgb(64, 64, 64);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.ForeColor = Color.Silver;
            textBox3.Location = new Point(150, 203);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Precio:";
            textBox3.Size = new Size(114, 20);
            textBox3.TabIndex = 30;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.BackColor = Color.FromArgb(64, 64, 64);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = Color.Silver;
            textBox2.Location = new Point(222, 137);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Stock:";
            textBox2.Size = new Size(114, 20);
            textBox2.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = Color.FromArgb(64, 64, 64);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.Silver;
            textBox1.Location = new Point(81, 137);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Producto:";
            textBox1.Size = new Size(114, 20);
            textBox1.TabIndex = 28;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 15);
            label1.Name = "label1";
            label1.Size = new Size(249, 23);
            label1.TabIndex = 27;
            label1.Text = "Gestión de un inventario";
            // 
            // panelGradient1
            // 
            panelGradient1.Anchor = AnchorStyles.Top;
            panelGradient1.BackColor = Color.White;
            panelGradient1.BorderRadius = 50;
            panelGradient1.Controls.Add(dgvInventario);
            panelGradient1.ForeColor = Color.Black;
            panelGradient1.GradientBottomColor = Color.Gray;
            panelGradient1.GradientTopColor = Color.Gray;
            panelGradient1.Location = new Point(443, 121);
            panelGradient1.Margin = new Padding(3, 4, 3, 4);
            panelGradient1.Name = "panelGradient1";
            panelGradient1.Size = new Size(457, 428);
            panelGradient1.TabIndex = 34;
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dgvInventario.AllowUserToResizeColumns = false;
            dgvInventario.AllowUserToResizeRows = false;
            dgvInventario.BackgroundColor = Color.FromArgb(64, 64, 64);
            dgvInventario.BorderStyle = BorderStyle.None;
            dgvInventario.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvInventario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Columns.AddRange(new DataGridViewColumn[] { colProducto, Stock, Precio, SubTotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvInventario.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInventario.EnableHeadersVisualStyles = false;
            dgvInventario.Location = new Point(1, 31);
            dgvInventario.Margin = new Padding(3, 4, 3, 4);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvInventario.RowHeadersVisible = false;
            dgvInventario.RowHeadersWidth = 25;
            dgvInventario.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.Padding = new Padding(2);
            dgvInventario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(461, 364);
            dgvInventario.TabIndex = 0;
            // 
            // colProducto
            // 
            colProducto.HeaderText = "Producto";
            colProducto.MinimumWidth = 6;
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            colProducto.Width = 125;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 125;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.MinimumWidth = 6;
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.Width = 125;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(77, 137);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(219, 137);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(140, 205);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 37;
            pictureBox3.TabStop = false;
            // 
            // cbBusqueda
            // 
            cbBusqueda.Anchor = AnchorStyles.Top;
            cbBusqueda.BackColor = Color.FromArgb(64, 64, 64);
            cbBusqueda.FlatStyle = FlatStyle.Flat;
            cbBusqueda.ForeColor = Color.Silver;
            cbBusqueda.FormattingEnabled = true;
            cbBusqueda.Location = new Point(573, 36);
            cbBusqueda.Margin = new Padding(3, 4, 3, 4);
            cbBusqueda.Name = "cbBusqueda";
            cbBusqueda.Size = new Size(138, 28);
            cbBusqueda.TabIndex = 38;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(463, 36);
            label3.Name = "label3";
            label3.Size = new Size(113, 23);
            label3.TabIndex = 39;
            label3.Text = "Buscar por";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.Top;
            txtBusqueda.BackColor = Color.FromArgb(64, 64, 64);
            txtBusqueda.BorderStyle = BorderStyle.FixedSingle;
            txtBusqueda.ForeColor = Color.Silver;
            txtBusqueda.Location = new Point(718, 40);
            txtBusqueda.Margin = new Padding(3, 4, 3, 4);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "Buscar";
            txtBusqueda.Size = new Size(114, 27);
            txtBusqueda.TabIndex = 40;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top;
            btnBuscar.BackColor = Color.FromArgb(64, 64, 64);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(835, 39);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(27, 32);
            btnBuscar.TabIndex = 41;
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top;
            btnReset.BackColor = Color.FromArgb(64, 64, 64);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.Location = new Point(869, 39);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(27, 32);
            btnReset.TabIndex = 42;
            btnReset.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(226, 291);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(142, 53);
            button1.TabIndex = 43;
            button1.Text = "Agregar(First)";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnAddAt
            // 
            btnAddAt.Anchor = AnchorStyles.Top;
            btnAddAt.BackColor = Color.FromArgb(64, 64, 64);
            btnAddAt.Cursor = Cursors.Hand;
            btnAddAt.FlatAppearance.BorderSize = 0;
            btnAddAt.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnAddAt.FlatStyle = FlatStyle.Flat;
            btnAddAt.Image = (Image)resources.GetObject("btnAddAt.Image");
            btnAddAt.Location = new Point(202, 379);
            btnAddAt.Margin = new Padding(3, 4, 3, 4);
            btnAddAt.Name = "btnAddAt";
            btnAddAt.Size = new Size(138, 53);
            btnAddAt.TabIndex = 44;
            btnAddAt.Text = "Agregar por indice";
            btnAddAt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddAt.UseVisualStyleBackColor = false;
            btnAddAt.Click += button2_Click;
            // 
            // lblProducto
            // 
            lblProducto.Anchor = AnchorStyles.Top;
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducto.Location = new Point(23, 608);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(136, 20);
            lblProducto.TabIndex = 45;
            lblProducto.Text = "Productos totales:";
            // 
            // lblFirst
            // 
            lblFirst.Anchor = AnchorStyles.Top;
            lblFirst.AutoSize = true;
            lblFirst.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirst.Location = new Point(23, 641);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(69, 20);
            lblFirst.TabIndex = 46;
            lblFirst.Text = "Primero:";
            // 
            // lblLast
            // 
            lblLast.Anchor = AnchorStyles.Top;
            lblLast.AutoSize = true;
            lblLast.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLast.Location = new Point(252, 619);
            lblLast.Name = "lblLast";
            lblLast.Size = new Size(57, 20);
            lblLast.TabIndex = 47;
            lblLast.Text = "Ultimo";
            // 
            // lblNext
            // 
            lblNext.Anchor = AnchorStyles.Top;
            lblNext.AutoSize = true;
            lblNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNext.Location = new Point(252, 652);
            lblNext.Name = "lblNext";
            lblNext.Size = new Size(136, 20);
            lblNext.TabIndex = 48;
            lblNext.Text = "Siguiente(Nuevo):";
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(938, 681);
            Controls.Add(lblNext);
            Controls.Add(lblLast);
            Controls.Add(lblFirst);
            Controls.Add(lblProducto);
            Controls.Add(btnAddAt);
            Controls.Add(button1);
            Controls.Add(btnReset);
            Controls.Add(btnBuscar);
            Controls.Add(txtBusqueda);
            Controls.Add(label3);
            Controls.Add(cbBusqueda);
            Controls.Add(btnRemove);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panelGradient1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Inventario";
            Text = "Inventario";
            Load += Inventario_Load;
            panelGradient1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemove;
        private Label label2;
        private Button btnAdd;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Gradient.PanelGradient panelGradient1;
        private DataGridView dgvInventario;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn SubTotal;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private ComboBox cbBusqueda;
        private Label label3;
        private TextBox txtBusqueda;
        private Button btnBuscar;
        private Button btnReset;
        private Button button1;
        private Button btnAddAt;
        private Label lblProducto;
        private Label lblFirst;
        private Label lblLast;
        private Label lblNext;
    }
}