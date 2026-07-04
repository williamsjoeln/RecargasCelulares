namespace ModeloTelefonos
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblModeloTelefono = new Label();
            cmbMonto = new ComboBox();
            lblRecargas = new Label();
            lblNumero = new Label();
            txtNumero = new TextBox();
            rbIlimitada = new RadioButton();
            label1 = new Label();
            rbSinPlan = new RadioButton();
            label2 = new Label();
            chkClaro = new CheckBox();
            chkTuenti = new CheckBox();
            chkMovistar = new CheckBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnRecargar = new Button();
            btnLimpiar = new Button();
            btnCancelar = new Button();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblModeloTelefono
            // 
            lblModeloTelefono.AutoSize = true;
            lblModeloTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblModeloTelefono.Location = new Point(53, 83);
            lblModeloTelefono.Name = "lblModeloTelefono";
            lblModeloTelefono.Size = new Size(145, 20);
            lblModeloTelefono.TabIndex = 0;
            lblModeloTelefono.Text = "Monto de Recarga :";
            // 
            // cmbMonto
            // 
            cmbMonto.FormattingEnabled = true;
            cmbMonto.Items.AddRange(new object[] { "$1", "$5", "$10", "$20", "$50", "$100" });
            cmbMonto.Location = new Point(213, 80);
            cmbMonto.Name = "cmbMonto";
            cmbMonto.Size = new Size(197, 28);
            cmbMonto.TabIndex = 1;
            // 
            // lblRecargas
            // 
            lblRecargas.AutoSize = true;
            lblRecargas.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblRecargas.Location = new Point(76, 4);
            lblRecargas.Name = "lblRecargas";
            lblRecargas.Size = new Size(285, 35);
            lblRecargas.TabIndex = 4;
            lblRecargas.Text = "RECARGAS CELULARES";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNumero.Location = new Point(41, 47);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(159, 20);
            lblNumero.TabIndex = 5;
            lblNumero.Text = "Numero de teléfono :";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(213, 47);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(197, 27);
            txtNumero.TabIndex = 6;
            // 
            // rbIlimitada
            // 
            rbIlimitada.AutoSize = true;
            rbIlimitada.Location = new Point(213, 119);
            rbIlimitada.Name = "rbIlimitada";
            rbIlimitada.Size = new Size(100, 24);
            rbIlimitada.TabIndex = 7;
            rbIlimitada.TabStop = true;
            rbIlimitada.Text = "ILIMITADA";
            rbIlimitada.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(67, 121);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 8;
            label1.Text = "Tipo de Recarga :";
            // 
            // rbSinPlan
            // 
            rbSinPlan.AutoSize = true;
            rbSinPlan.Location = new Point(308, 119);
            rbSinPlan.Name = "rbSinPlan";
            rbSinPlan.Size = new Size(93, 24);
            rbSinPlan.TabIndex = 9;
            rbSinPlan.TabStop = true;
            rbSinPlan.Text = "SIN PLAN";
            rbSinPlan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(104, 155);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 10;
            label2.Text = "Operadora :";
            // 
            // chkClaro
            // 
            chkClaro.AutoSize = true;
            chkClaro.Location = new Point(213, 155);
            chkClaro.Name = "chkClaro";
            chkClaro.Size = new Size(77, 24);
            chkClaro.TabIndex = 11;
            chkClaro.Text = "CLARO";
            chkClaro.UseVisualStyleBackColor = true;
            chkClaro.CheckedChanged += chkClaro_CheckedChanged;
            // 
            // chkTuenti
            // 
            chkTuenti.AutoSize = true;
            chkTuenti.Location = new Point(213, 185);
            chkTuenti.Name = "chkTuenti";
            chkTuenti.Size = new Size(80, 24);
            chkTuenti.TabIndex = 12;
            chkTuenti.Text = "TUENTI";
            chkTuenti.UseVisualStyleBackColor = true;
            chkTuenti.CheckedChanged += chkTuenti_CheckedChanged;
            // 
            // chkMovistar
            // 
            chkMovistar.AutoSize = true;
            chkMovistar.Location = new Point(308, 155);
            chkMovistar.Name = "chkMovistar";
            chkMovistar.Size = new Size(102, 24);
            chkMovistar.TabIndex = 13;
            chkMovistar.Text = "MOVISTAR";
            chkMovistar.UseVisualStyleBackColor = true;
            chkMovistar.CheckedChanged += chkMovistar_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(403, 177);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(442, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(92, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(442, 99);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(92, 90);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // btnRecargar
            // 
            btnRecargar.BackColor = Color.Lime;
            btnRecargar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRecargar.Location = new Point(93, 277);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(114, 44);
            btnRecargar.TabIndex = 17;
            btnRecargar.Text = "RECARGAR";
            btnRecargar.UseVisualStyleBackColor = false;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(0, 192, 192);
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpiar.Location = new Point(213, 277);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(111, 44);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.Location = new Point(139, 327);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(132, 44);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(43, 224);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(347, 29);
            progressBar1.TabIndex = 20;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(595, 407);
            Controls.Add(progressBar1);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRecargar);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(chkMovistar);
            Controls.Add(chkTuenti);
            Controls.Add(chkClaro);
            Controls.Add(label2);
            Controls.Add(rbSinPlan);
            Controls.Add(label1);
            Controls.Add(rbIlimitada);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(lblRecargas);
            Controls.Add(cmbMonto);
            Controls.Add(lblModeloTelefono);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recargas Celulares";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblModeloTelefono;
        private ComboBox cmbMonto;
        private Label lblRecargas;
        private Label lblNumero;
        private TextBox txtNumero;
        private RadioButton rbIlimitada;
        private Label label1;
        private RadioButton rbSinPlan;
        private Label label2;
        private CheckBox chkClaro;
        private CheckBox chkTuenti;
        private CheckBox chkMovistar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnRecargar;
        private Button btnLimpiar;
        private Button btnCancelar;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}
