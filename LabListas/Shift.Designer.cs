namespace LabListas
{
    partial class Shift
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shift));
            panelGradient1 = new Gradient.PanelGradient();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnPrevious = new Button();
            elipseControl1 = new ElipseControl.ElipseControl();
            lbTurnos = new ListBox();
            btnNext = new Button();
            label5 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            panelGradient2 = new Gradient.PanelGradient();
            txtMil = new TextBox();
            txtSeconds = new TextBox();
            txtMin = new TextBox();
            btnPausa = new Button();
            btnReiniciar = new Button();
            btnIniciar = new Button();
            label6 = new Label();
            panelGradient3 = new Gradient.PanelGradient();
            label8 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label7 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panelGradient1.SuspendLayout();
            panelGradient2.SuspendLayout();
            panelGradient3.SuspendLayout();
            SuspendLayout();
            // 
            // panelGradient1
            // 
            panelGradient1.Anchor = AnchorStyles.Top;
            panelGradient1.BackColor = Color.Transparent;
            panelGradient1.BorderRadius = 15;
            panelGradient1.Controls.Add(label4);
            panelGradient1.Controls.Add(label3);
            panelGradient1.Controls.Add(label2);
            panelGradient1.Controls.Add(label1);
            panelGradient1.ForeColor = Color.Black;
            panelGradient1.GradientBottomColor = Color.Gray;
            panelGradient1.GradientTopColor = Color.Gray;
            panelGradient1.Location = new Point(12, 27);
            panelGradient1.Name = "panelGradient1";
            panelGradient1.Size = new Size(660, 147);
            panelGradient1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 12F);
            label4.Location = new Point(21, 118);
            label4.Name = "label4";
            label4.Size = new Size(198, 21);
            label4.TabIndex = 3;
            label4.Text = "Posicion de Lista: 3 de 12";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Century Gothic", 12F);
            label3.Location = new Point(21, 93);
            label3.Name = "label3";
            label3.Size = new Size(148, 21);
            label3.TabIndex = 2;
            label3.Text = "Estado: En espera";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(154, 32);
            label2.Name = "label2";
            label2.Size = new Size(378, 45);
            label2.TabIndex = 1;
            label2.Text = "Turno: ##909- Juan Perez";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F);
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 0;
            label1.Text = "Turno Actual";
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Top;
            btnPrevious.Cursor = Cursors.Hand;
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrevious.Location = new Point(216, 180);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(140, 40);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "Anterior";
            btnPrevious.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = lbTurnos;
            // 
            // lbTurnos
            // 
            lbTurnos.Anchor = AnchorStyles.Top;
            lbTurnos.BackColor = Color.Gray;
            lbTurnos.BorderStyle = BorderStyle.None;
            lbTurnos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTurnos.FormattingEnabled = true;
            lbTurnos.Location = new Point(20, 267);
            lbTurnos.Name = "lbTurnos";
            lbTurnos.Size = new Size(330, 140);
            lbTurnos.Sorted = true;
            lbTurnos.TabIndex = 6;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.ImageAlign = ContentAlignment.MiddleRight;
            btnNext.Location = new Point(365, 180);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(140, 40);
            btnNext.TabIndex = 5;
            btnNext.Text = "Siguiente";
            btnNext.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnNext.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(122, 245);
            label5.Name = "label5";
            label5.Size = new Size(118, 19);
            label5.TabIndex = 4;
            label5.Text = "Lista de Turnos";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top;
            btnAdd.BackColor = Color.FromArgb(64, 64, 64);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(62, 434);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 30);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Agregar";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(207, 434);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 30);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Eliminar";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // panelGradient2
            // 
            panelGradient2.Anchor = AnchorStyles.Top;
            panelGradient2.BackColor = Color.White;
            panelGradient2.BorderRadius = 35;
            panelGradient2.Controls.Add(txtMil);
            panelGradient2.Controls.Add(txtSeconds);
            panelGradient2.Controls.Add(txtMin);
            panelGradient2.Controls.Add(btnPausa);
            panelGradient2.Controls.Add(btnReiniciar);
            panelGradient2.Controls.Add(btnIniciar);
            panelGradient2.Controls.Add(label6);
            panelGradient2.ForeColor = Color.Black;
            panelGradient2.GradientBottomColor = Color.Gray;
            panelGradient2.GradientTopColor = Color.Gray;
            panelGradient2.Location = new Point(365, 255);
            panelGradient2.Name = "panelGradient2";
            panelGradient2.Size = new Size(312, 174);
            panelGradient2.TabIndex = 9;
            // 
            // txtMil
            // 
            txtMil.BackColor = Color.Gray;
            txtMil.BorderStyle = BorderStyle.FixedSingle;
            txtMil.Font = new Font("Century Gothic", 27.75F);
            txtMil.Location = new Point(213, 47);
            txtMil.Multiline = true;
            txtMil.Name = "txtMil";
            txtMil.Size = new Size(80, 53);
            txtMil.TabIndex = 15;
            txtMil.Text = "0000";
            txtMil.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSeconds
            // 
            txtSeconds.BackColor = Color.Gray;
            txtSeconds.BorderStyle = BorderStyle.FixedSingle;
            txtSeconds.Font = new Font("Century Gothic", 27.75F);
            txtSeconds.Location = new Point(115, 47);
            txtSeconds.Multiline = true;
            txtSeconds.Name = "txtSeconds";
            txtSeconds.Size = new Size(80, 53);
            txtSeconds.TabIndex = 14;
            txtSeconds.Text = "00";
            txtSeconds.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMin
            // 
            txtMin.BackColor = Color.Gray;
            txtMin.BorderStyle = BorderStyle.FixedSingle;
            txtMin.Font = new Font("Century Gothic", 27.75F);
            txtMin.Location = new Point(15, 47);
            txtMin.Multiline = true;
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(80, 53);
            txtMin.TabIndex = 13;
            txtMin.Text = "00";
            txtMin.TextAlign = HorizontalAlignment.Center;
            // 
            // btnPausa
            // 
            btnPausa.Anchor = AnchorStyles.Top;
            btnPausa.BackColor = Color.Gray;
            btnPausa.Cursor = Cursors.Hand;
            btnPausa.FlatAppearance.BorderSize = 0;
            btnPausa.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnPausa.FlatStyle = FlatStyle.Flat;
            btnPausa.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPausa.Image = (Image)resources.GetObject("btnPausa.Image");
            btnPausa.ImageAlign = ContentAlignment.MiddleLeft;
            btnPausa.Location = new Point(114, 129);
            btnPausa.Name = "btnPausa";
            btnPausa.Size = new Size(76, 26);
            btnPausa.TabIndex = 12;
            btnPausa.Text = "Pausar";
            btnPausa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPausa.UseVisualStyleBackColor = false;
            btnPausa.Click += btnPausa_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Anchor = AnchorStyles.Top;
            btnReiniciar.BackColor = Color.Gray;
            btnReiniciar.Cursor = Cursors.Hand;
            btnReiniciar.FlatAppearance.BorderSize = 0;
            btnReiniciar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReiniciar.Image = (Image)resources.GetObject("btnReiniciar.Image");
            btnReiniciar.ImageAlign = ContentAlignment.MiddleLeft;
            btnReiniciar.Location = new Point(216, 129);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(87, 26);
            btnReiniciar.TabIndex = 11;
            btnReiniciar.Text = "Reinicar";
            btnReiniciar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Anchor = AnchorStyles.Top;
            btnIniciar.BackColor = Color.Gray;
            btnIniciar.Cursor = Cursors.Hand;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciar.Image = (Image)resources.GetObject("btnIniciar.Image");
            btnIniciar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIniciar.Location = new Point(15, 129);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(70, 26);
            btnIniciar.TabIndex = 10;
            btnIniciar.Text = "Iniciar";
            btnIniciar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(108, 11);
            label6.Name = "label6";
            label6.Size = new Size(101, 19);
            label6.TabIndex = 4;
            label6.Text = "Cronometro";
            // 
            // panelGradient3
            // 
            panelGradient3.Anchor = AnchorStyles.Top;
            panelGradient3.BackColor = Color.White;
            panelGradient3.BorderRadius = 25;
            panelGradient3.Controls.Add(label8);
            panelGradient3.Controls.Add(button4);
            panelGradient3.Controls.Add(button5);
            panelGradient3.Controls.Add(button6);
            panelGradient3.Controls.Add(label7);
            panelGradient3.ForeColor = Color.Black;
            panelGradient3.GradientBottomColor = Color.Gray;
            panelGradient3.GradientTopColor = Color.Gray;
            panelGradient3.Location = new Point(15, 486);
            panelGradient3.Name = "panelGradient3";
            panelGradient3.Size = new Size(660, 20);
            panelGradient3.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(256, 5);
            label8.Name = "label8";
            label8.Size = new Size(196, 17);
            label8.TabIndex = 13;
            label8.Text = "Nodo cabeza: | Nodo Cola:";
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top;
            button4.BackColor = Color.Gray;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(271, 118);
            button4.Name = "button4";
            button4.Size = new Size(70, 26);
            button4.TabIndex = 12;
            button4.Text = "Pausar";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top;
            button5.BackColor = Color.Gray;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(375, 118);
            button5.Name = "button5";
            button5.Size = new Size(70, 26);
            button5.TabIndex = 11;
            button5.Text = "Reinicar";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top;
            button6.BackColor = Color.Gray;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(170, 118);
            button6.Name = "button6";
            button6.Size = new Size(70, 26);
            button6.TabIndex = 10;
            button6.Text = "Iniciar";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(107, 12);
            label7.Name = "label7";
            label7.Size = new Size(0, 19);
            label7.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Shift
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(684, 511);
            Controls.Add(panelGradient3);
            Controls.Add(panelGradient2);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(lbTurnos);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(panelGradient1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Shift";
            Text = "Shift";
            Load += Shift_Load;
            panelGradient1.ResumeLayout(false);
            panelGradient1.PerformLayout();
            panelGradient2.ResumeLayout(false);
            panelGradient2.PerformLayout();
            panelGradient3.ResumeLayout(false);
            panelGradient3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Gradient.PanelGradient panelGradient1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnPrevious;
        private ElipseControl.ElipseControl elipseControl1;
        private Button btnNext;
        private ListBox lbTurnos;
        private Label label5;
        private Button btnAdd;
        private Button btnDelete;
        private Gradient.PanelGradient panelGradient2;
        private Label label6;
        private Button btnPausa;
        private Button btnReiniciar;
        private Button btnIniciar;
        private Gradient.PanelGradient panelGradient3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label7;
        private Label label8;
        private TextBox txtMil;
        private TextBox txtSeconds;
        private TextBox txtMin;
        private System.Windows.Forms.Timer timer1;
    }
}