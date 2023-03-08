using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {

            // Declaração de variáveis

            double valor, multa, juros, desconto, vmulta, vjuros, vdesconto, acrescimos, total;
            DateTime pagamento, vencimento;
            int dias;

            // Atribuindo 

            valor = double.Parse(txtValor.Text);
            multa = double.Parse(txtMulta.Text);
            juros = double.Parse(txtJuros.Text);
            desconto = double.Parse(txtDesconto.Text);

          

            pagamento = Convert.ToDateTime(TxtBxPgt.Text);
            vencimento = Convert.ToDateTime(TxtBxDtVen.Text);

           
            // Processando os dados

            // dias atrasados

            if (pagamento > vencimento) 
            {
                dias = (pagamento - vencimento).Days;
            }
            else 
            {
                dias = 0;
            }

            textBoxDiasAtras.Text = dias.ToString();

            // multa

            if (pagamento > vencimento) 
            {
                vmulta = (multa / 100) * valor; 
            }
            else { vmulta = 0; }

            txtValorLeituraMulta.Text = vmulta.ToString("C");

            // juros

            if(pagamento > vencimento)
            {
                vjuros = (juros / 10) * valor * dias;
            }
            else { vjuros = 0; }

            txtValorLeituraJuros.Text = vjuros.ToString("C");

            // Acréscimos

            acrescimos = juros + multa;
            txtValorLeituraAcres.Text = acrescimos.ToString("C");

            if(pagamento < vencimento) 
            {
                vdesconto = (desconto / 100) * valor;
            }
            else 
            {
                vdesconto = 0;
            }

            txtValorLeituraDesconto.Text = vdesconto.ToString("C");
            total = valor + acrescimos - desconto;
            txtTotal.Text = total.ToString("C");

        }
    }
}
