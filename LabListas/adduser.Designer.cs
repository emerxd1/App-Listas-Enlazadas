namespace LabListas
{
    partial class adduser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adduser));
            textBox1 = new TextBox();
            label1 = new Label();
            btnAddAt = new Button();
            addfirst = new Button();
            addlast = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(64, 64, 64);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(89, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(89, 44);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre y Apellido";
            label1.Click += label1_Click;
            // 
            // btnAddAt
            // 
            btnAddAt.Anchor = AnchorStyles.Top;
            btnAddAt.BackColor = Color.FromArgb(64, 64, 64);
            btnAddAt.Cursor = Cursors.Hand;
            btnAddAt.FlatAppearance.BorderSize = 0;
            btnAddAt.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnAddAt.FlatStyle = FlatStyle.Flat;
            btnAddAt.ForeColor = Color.White;
            btnAddAt.Image = (Image)resources.GetObject("btnAddAt.Image");
            btnAddAt.Location = new Point(177, 208);
            btnAddAt.Margin = new Padding(3, 4, 3, 4);
            btnAddAt.Name = "btnAddAt";
            btnAddAt.Size = new Size(138, 53);
            btnAddAt.TabIndex = 48;
            btnAddAt.Text = "Agregar por indice";
            btnAddAt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddAt.UseVisualStyleBackColor = false;
            btnAddAt.Click += btnAddAt_Click;
            // 
            // addfirst
            // 
            addfirst.Anchor = AnchorStyles.Top;
            addfirst.BackColor = Color.FromArgb(64, 64, 64);
            addfirst.Cursor = Cursors.Hand;
            addfirst.FlatAppearance.BorderSize = 0;
            addfirst.FlatAppearance.MouseOverBackColor = Color.Gray;
            addfirst.FlatStyle = FlatStyle.Flat;
            addfirst.ForeColor = Color.White;
            addfirst.Image = (Image)resources.GetObject("addfirst.Image");
            addfirst.Location = new Point(247, 127);
            addfirst.Margin = new Padding(3, 4, 3, 4);
            addfirst.Name = "addfirst";
            addfirst.Size = new Size(142, 53);
            addfirst.TabIndex = 47;
            addfirst.Text = "Agregar(First)";
            addfirst.TextImageRelation = TextImageRelation.ImageBeforeText;
            addfirst.UseVisualStyleBackColor = false;
            addfirst.Click += addfirst_Click;
            // 
            // addlast
            // 
            addlast.Anchor = AnchorStyles.Top;
            addlast.BackColor = Color.FromArgb(64, 64, 64);
            addlast.Cursor = Cursors.Hand;
            addlast.FlatAppearance.BorderSize = 0;
            addlast.FlatAppearance.MouseOverBackColor = Color.Gray;
            addlast.FlatStyle = FlatStyle.Flat;
            addlast.ForeColor = Color.White;
            addlast.Image = (Image)resources.GetObject("addlast.Image");
            addlast.Location = new Point(89, 127);
            addlast.Margin = new Padding(3, 4, 3, 4);
            addlast.Name = "addlast";
            addlast.Size = new Size(149, 53);
            addlast.TabIndex = 45;
            addlast.Text = "Agregar(Last)";
            addlast.TextImageRelation = TextImageRelation.ImageBeforeText;
            addlast.UseVisualStyleBackColor = false;
            addlast.Click += addlast_Click;
            // 
            // adduser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(511, 450);
            Controls.Add(btnAddAt);
            Controls.Add(addfirst);
            Controls.Add(addlast);
            Controls.Add(label1);
            Controls.Add(textBox1);
            ForeColor = Color.White;
            Name = "adduser";
            Text = "adduser";
            Load += adduser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button btnAddAt;
        private Button addfirst;
        private Button addlast;
    }
}