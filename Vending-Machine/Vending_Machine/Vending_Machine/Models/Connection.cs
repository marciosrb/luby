using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Vending_Machine.Classes;
using System.Data;


namespace Vending_Machine.Classes {
    public class Connection {
        private static SQLiteConnection sqliteConnection;
        private static string resultadoEstoque;
        

        private static SQLiteConnection DbConnection() {
            sqliteConnection = new SQLiteConnection("Data Source=C:\\Users\\Márcio\\Desktop\\Meus Projetos\\Vending-Machine\\bd.db;");
            sqliteConnection.Open();
            return sqliteConnection;
        }

        public static void AddVenda(Produtos venda) {
            try {
                using (var cmd = DbConnection().CreateCommand()) {
                    cmd.CommandText = "INSERT INTO venda(produto, precoTotal, quantidade ) values (@produto, @precoTotal, @quantidade)";
                    cmd.Parameters.AddWithValue("@produto", venda.produto);
                    cmd.Parameters.AddWithValue("@precoTotal", venda.precoTotal);
                    cmd.Parameters.AddWithValue("@quantidade", venda.quantidade);
                    cmd.ExecuteNonQuery();
                }
            } catch (Exception ex) {
                throw ex;
            }
        }

        public static void AtualizarEstoque(Produtos venda) {
            try {
                using (var cmd = DbConnection().CreateCommand()) {
                    cmd.CommandText = "SELECT estoque FROM produtos WHERE produto = @produto";
                    cmd.Parameters.AddWithValue("@produto", venda.produto);

                    SQLiteDataReader dr = cmd.ExecuteReader();
                    int quantidadeNoBanco = 0;

                    while (dr.Read()) {
                        quantidadeNoBanco = Convert.ToInt32(dr["estoque"]);
                    }

                    dr.Close();

                    int quantidadeAtual = quantidadeNoBanco - Convert.ToInt32("1");

                    //Altere a nova quantidade
                    cmd.CommandText = "UPDATE produtos set estoque = @estoque where produto = @produto";
                    cmd.Parameters.AddWithValue("@estoque", quantidadeAtual);
                    cmd.Parameters.AddWithValue("@produto", venda.produto);

                    cmd.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                throw ex;
            }
        }

        public static void GetEstoque(Produtos venda) {           

            try {
                using (var cmd = DbConnection().CreateCommand()) {
                    cmd.CommandText = "SELECT estoque FROM produtos WHERE produto = @produto";
                    cmd.Parameters.AddWithValue("@produto", venda.produto);

                    SQLiteDataReader dr = cmd.ExecuteReader();
                    string quantidadeNoBanco = "00";

                    while (dr.Read()) {
                        quantidadeNoBanco = Convert.ToString(dr["estoque"]);
                    }

                    dr.Close();                   

                    resultadoEstoque = quantidadeNoBanco;
                }
            } catch (Exception ex) {
                throw ex;
            }
        }

        public string mostraResultadoEstoque() {
            return resultadoEstoque;
        }

        public static DataTable GetVenda() {

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try {
                using (var cmd = DbConnection().CreateCommand()) {
                    cmd.CommandText = "SELECT * FROM venda";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            } catch (Exception ex) {
                throw ex;
            }
        }

        public static DataTable GetEstoque() {

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try {
                using (var cmd = DbConnection().CreateCommand()) {
                    cmd.CommandText = "SELECT * FROM produtos";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            } catch (Exception ex) {
                throw ex;
            }
        }


    }
}
