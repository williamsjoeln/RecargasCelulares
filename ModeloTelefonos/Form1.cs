namespace ModeloTelefonos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            pictureBox1.BackColor = Color.Transparent;

            
            pictureBox1.Parent = this;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero.Text = "";

            this.cmbMonto.SelectedIndex = -1;

            this.rbIlimitada.Checked = false;
            this.rbSinPlan.Checked = false;

            this.chkClaro.Checked = false;
            this.chkMovistar.Checked = false;
            this.chkTuenti.Checked = false;
        }


        private Boolean validaRegistro()
        {
            
            if (txtNumero.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar un número de teléfono.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
                return false;
            }

            
            if (cmbMonto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un monto para la recarga.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMonto.Focus();
                return false;
            }

            
            if (rbIlimitada.Checked == false && rbSinPlan.Checked == false)
            {
                MessageBox.Show("Debe seleccionar un tipo de recarga (Ilimitada o Sin Plan).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            
            if (chkClaro.Checked == false && chkMovistar.Checked == false && chkTuenti.Checked == false)
            {
                MessageBox.Show("Debe seleccionar una operadora (Claro, Movistar o Tuenti).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            
            return true;
        }


        private void btnRecargar_Click(object sender, EventArgs e)
        {
            if (validaRegistro())
            {
                
                this.progressBar1.Value = 0;
                this.btnRecargar.Enabled = false;

                
                this.timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (this.progressBar1.Value < 100)
            {
                this.progressBar1.Value += 2;
            }
            else
            {
               
                this.timer1.Stop();

                
                this.btnRecargar.Enabled = true;

                string TipoRecarga = rbIlimitada.Checked ? "Ilimitada" : "Sin Plan";
                string Operador = chkClaro.Checked ? "Claro" : chkMovistar.Checked ? "Movistar" : chkTuenti.Checked ? "Tuenti" : "Ninguno";

                
                string mensajeFinal = "¡Tu recarga ha sido exitosa!\n\n" +
                                     $"- Procesando recarga número: {txtNumero.Text}\n" +
                                     $"- Monto: {cmbMonto.SelectedItem}\n" +
                                     $"- Tipo de Recarga: {TipoRecarga}\n" +
                                     $"- Operador: {Operador}";

               
                MessageBox.Show(mensajeFinal, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}
