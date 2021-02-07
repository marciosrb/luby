using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;
using Vending_Machine.Classes;
using Vending_Machine.Interface;

namespace Vending_Machine {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            
        }
        string nomeProdutoVenda = "";
       


        private void Form1_Load(object sender, EventArgs e) {
            txtMensagem.Text = "Insira notas para começar a venda";
        }  

        private void ClickButton(object sender) {

            txtMensagem.Text = "";

            Button btn = (Button)sender;

            double valorPago, ValorInformado, valorPagoDinheiro;
                       
            valorPago = Convert.ToDouble(txtValorPago.Text);
            ValorInformado = Convert.ToDouble(btn.Text);

            valorPagoDinheiro = ValorInformado + valorPago;
           
            txtValorPago.Text = valorPagoDinheiro.ToString("N", CultureInfo.CurrentCulture);

        }

        private void precoProduto1() {
            txtTotal.Text = "4,00";
        }

        private void precoProduto2() {
            txtTotal.Text = "3,00";
        }

        private void calculoValorPago() {
            double valorPago, valorTotal;
            valorPago = Convert.ToDouble(txtValorPago.Text);
            valorTotal = Convert.ToDouble(txtTotal.Text);
            
            if(valorPago < valorTotal) {

                double valorFalta;
                string falta;
                valorFalta = valorTotal - valorPago;
                falta = valorFalta.ToString("C", CultureInfo.CurrentCulture);

                txtMensagem.Text = "Falta " + falta + " \r\nInsira mais notas para finalizar a venda";
            } else if (valorPago > valorTotal){

                double valorTroco;
                string troco;

                valorTroco = valorPago - valorTotal;
                troco = valorTroco.ToString("C", CultureInfo.CurrentCulture);

                txtMensagem.Text = "Retire o seu troco de " + troco + " e sua bebida";

                pbLata.Visible = true;

            } else if (valorPago == valorTotal) {

                txtMensagem.Text = "Retire a sua bebida";

                pbLata.Visible = true;
            }
        }

        private void nomeProduto(object sender) {
            Button nomeBtn = (Button)sender;
            nomeProdutoVenda = Convert.ToString(nomeBtn.Text);
        }

        private void inserirVenda() {
            try {
                Produtos prod = new Produtos();

                prod.produto = nomeProdutoVenda;
                prod.precoTotal = txtTotal.Text;
                prod.quantidade = "1";
                

                Connection.AddVenda(prod);

                // ExibirDados();
                // LimpaDados();
            } catch (Exception ex) {
                MessageBox.Show("Erro : " + ex.Message);
            }

        }


        private void atualizarEstoque() {
            try {
                Produtos prod = new Produtos();

                prod.produto = nomeProdutoVenda;            
                
                Connection.AtualizarEstoque(prod);

                // ExibirDados();
                // LimpaDados();
            } catch (Exception ex) {
                MessageBox.Show("Erro : " + ex.Message);
            }

        }

        private void verificaEstoque() {
            try {

                Produtos prod = new Produtos();

                prod.produto = nomeProdutoVenda;

                Connection.GetEstoque(prod);

                Connection con;
                con = new Connection();

                int estoqueAtual = Convert.ToInt32(con.mostraResultadoEstoque());
                int estoqueMinimo = 1;
                if(estoqueAtual < estoqueMinimo) {
                    txtMensagem.Text = "Produto Indisponível, escolha outro produto";
                    txtTotal.Text = "0,00";
                    txtValorPago.Text = "0,00";
                } else {
                    precoProduto2();
                    calculoValorPago();
                }

            } catch (Exception ex) {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e) {
            nomeProduto(sender);
            verificaEstoque();
            

        }

        private void btnFanta_Click(object sender, EventArgs e) {
            nomeProduto(sender);
            verificaEstoque();
        }

        private void btnSprite_Click(object sender, EventArgs e) {
            nomeProduto(sender);
            verificaEstoque();
        }

        private void btnPepsi_Click(object sender, EventArgs e) {
            nomeProduto(sender);
            verificaEstoque();
        }

        private void btnAntarctica_Click(object sender, EventArgs e) {
            nomeProduto(sender);
            verificaEstoque();
        }

        private void btnDinheiro1_Click(object sender, EventArgs e) {

            ClickButton(sender);

        }

        private void btnDinheiro2_Click(object sender, EventArgs e) {
            ClickButton(sender);
        }

        private void btnDinheiro3_Click(object sender, EventArgs e) {
            ClickButton(sender);
        }

        private void pbLata_Click(object sender, EventArgs e) {
            inserirVenda();
            atualizarEstoque();
           

            pbLata.Visible = false;
            txtTotal.Text = "0,00";
            txtValorPago.Text = "0,00";
            txtMensagem.Text = "Insira notas para começar a venda";

           

        }

        private void button1_Click_1(object sender, EventArgs e) {
            formEstoque form = new formEstoque();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            formVendas form = new formVendas();
            form.Show();

        }
    }
}
