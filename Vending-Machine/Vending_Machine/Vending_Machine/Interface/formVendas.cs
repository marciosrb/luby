using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vending_Machine.Classes;

namespace Vending_Machine.Interface {
    public partial class formVendas : Form {
        public formVendas() {
            InitializeComponent();
        }

        private void formVendas_Load(object sender, EventArgs e) {
            ExibirDados();
            SomatorioVendas();
            SomatorioQts();

        }

        private void ExibirDados() {
            try {
                DataTable dt = new DataTable();
                dt = Connection.GetVenda();
                dtVendas.DataSource = dt;
            } catch (Exception ex) {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }
        public void SomatorioVendas() {
            decimal total = 0;
            foreach (DataGridViewRow row in dtVendas.Rows) {
                total += Convert.ToDecimal(row.Cells["precoTotal"].Value);
            }

            txtValorVenda.Text = Convert.ToDouble(total).ToString("C");
        }
        public void SomatorioQts() {
            decimal total = 0;
            foreach (DataGridViewRow row in dtVendas.Rows) {
                total += Convert.ToDecimal(row.Cells["quantidade"].Value);
            }

            txtQtd.Text = Convert.ToDouble(total).ToString("");
        }

        private void txtValorVenda_TextChanged(object sender, EventArgs e) {

        }

        private void dtVendas_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
