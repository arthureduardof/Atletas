using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtleta
{
    public partial class Pessoa : Form
    {
        public Pessoa()
        {
            InitializeComponent();
        }
       
        Atleta obj = new Atleta();

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Nome = txt_nome.Text;
                obj.DataNascimento = dtp_dt.Value;
                obj.Altura = double.Parse(txt_altura.Text);
                obj.Peso = double.Parse(txtPeso.Text);
                MessageBox.Show("Dados armazenados com sucesso!");

                txt_nome.Text = "";
                txt_nome.Focus();
                txt_altura.Text = "";
                txt_peso.Text = "";
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro. \n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados obtidos: " + obj.ImprimeDados() +
                            "\n\nIdade: " + obj.CalcularIdade().ToString("00") + " Anos");
            lbl_idade.Text = obj.CalcularIdade().ToString() + " Anos";
        }
    }
}