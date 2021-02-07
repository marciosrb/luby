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
    public partial class formEstoque : Form {
        public formEstoque() {
            InitializeComponent();
        }

        private void formEstoque_Load(object sender, EventArgs e) {
            ExibirDados();
        }

        private void ExibirDados() {
            try {
                DataTable dt = new DataTable();
                dt = Connection.GetEstoque();
                dtVendas.DataSource = dt;
            } catch (Exception ex) {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }
    }
}
