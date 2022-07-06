using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ControlES
{
    public partial class EntradaeSaida : Form
    {
        public EntradaeSaida()
        {
            InitializeComponent();
        }

        private void EntradaeSaida_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.Time_lbl.Text = datetime.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkEntra_CheckedChanged(object sender, EventArgs e)
        {
            if(checkEntra.Checked == true)
            {
                checkSai.Enabled = false;
            }
            else
            {
                checkSai.Enabled = true;
            }
        }

        private void checkSai_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSai.Checked == true)
            {
                checkEntra.Enabled = false;
            }
            else
            {
                checkEntra.Enabled = true;
            }
        }

        private void checkCar_CheckedChanged(object sender, EventArgs e)
        {
            if(checkCar.Checked == true)
            {
                checkDesc.Enabled = false;
            }
            else
            {
                checkDesc.Enabled = true;
            }
        }

        private void checkDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDesc.Checked == true)
            {
                checkCar.Enabled = false;
            }
            else
            {
                checkCar.Enabled = true;
            }
        }

        public string Propriedade { get; set; }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                //EntradaeSaida entra = new EntradaeSaida();
                //entra.Propriedade = textBox1.Text;
                conexao.inserir();

                MessageBox.Show("Importação realizada com sucesso! ", "Imortação!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro \n\nErro:" + erro);
            }
        }
    }
}
