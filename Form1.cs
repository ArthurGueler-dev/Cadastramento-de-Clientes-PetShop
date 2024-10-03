using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class cadastro : Form
    {
        //definindo destino(database)

        private MySqlConnection Conexao;
        private string database = "datasource=localhost;username=root;password=Arthur22;database=db_petshop";

        public cadastro()
        {
            //ajustes visuais do campo de clientes cadastrados

            InitializeComponent();

            lst_contatos.View = View.Details;
            lst_contatos.LabelEdit = true;
            lst_contatos.AllowColumnReorder = true;
            lst_contatos.FullRowSelect = true;
            lst_contatos.GridLines = true;

            lst_contatos.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Tipo Animal", 100, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Raça", 150, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Data de Nascimento", 100, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Peso", 150, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Telefone", 150, HorizontalAlignment.Left);

            carregar_clientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //linhas de codigo para acessar a database e inserir dados para a database

                Conexao = new MySqlConnection(database);

                string sql = "INSERT INTO cadastro (nome, tipo_animal, raça, data_nascimento, peso, telefone) " +
                    "VALUES('" + txtNome.Text + "', '" + txtTipoAnimal.Text + "', '" + txtRaça.Text + "',  '" + txtDataNascimento.Text + "', '" + txtPeso.Text + "', '" + txtTelefone.Text + "')  ";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Deu tudo certo, inserido");

                //resetando o campo de preenchimento de dados

                txtDataNascimento.Text = "";
                txtNome.Text = "";
                txtPeso.Text = "";
                txtRaça.Text = "";
                txtTelefone.Text = "";
                txtTipoAnimal.Text = "";

                carregar_clientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //retornando valores do banco de dados para o listview

                Conexao = new MySqlConnection(database);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                cmd.CommandText = "SELECT * FROM cadastro WHERE nome LIKE @q OR telefone LIKE @q ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%");


                MySqlDataReader leitor = cmd.ExecuteReader();

                lst_contatos.Items.Clear();

                while (leitor.Read())
                {
                    string[] row = new string[7];  // 7 colunas exibidas no ListView (ID, Nome, Tipo, Raça, Data de Nascimento, Peso, Telefone)

                    row[0] = leitor.GetInt32(0).ToString();  // id
                    row[1] = leitor.GetString(1);  // nome
                    row[2] = leitor.GetString(2);  // tipo Animal
                    row[3] = leitor.GetString(3);  // raça 
                    row[4] = leitor.GetDateTime(5).ToString("dd/MM/yyyy");  // Data de Nascimento 
                    row[5] = leitor.GetString(6);  // Peso 
                    row[6] = leitor.GetString(7);  // Telefone 

                    // criando um novo ListViewItem com os valores
                    var linha_listaview = new ListViewItem(row);

                    // adicionando a linha ao ListView
                    lst_contatos.Items.Add(linha_listaview);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void lst_contatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_contatos.SelectedItems.Count > 0)
            {
                // captura o ID do animal selecionado na primeira coluna do ListView
                string id = lst_contatos.SelectedItems[0].SubItems[0].Text;
                string nome = lst_contatos.SelectedItems[0].SubItems[1].Text;
                string tipoAnimal = lst_contatos.SelectedItems[0].SubItems[2].Text;
                string raca = lst_contatos.SelectedItems[0].SubItems[3].Text;
                string dataNascimento = lst_contatos.SelectedItems[0].SubItems[4].Text;
                string peso = lst_contatos.SelectedItems[0].SubItems[5].Text;
                string telefone = lst_contatos.SelectedItems[0].SubItems[6].Text;

                // passa os dados para o formulário Consulta
                Consulta consultaForm = new Consulta(id, nome, tipoAnimal, raca, dataNascimento, peso, telefone);

                consultaForm.ShowDialog();

            }
        }

        private void carregar_clientes()
        {
            try
            {
                // classe para retornar os dados do database no listview assim que o programa abrir

                Conexao = new MySqlConnection(database);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                cmd.CommandText = "SELECT * FROM cadastro ORDER BY id DESC ";
                cmd.Parameters.Clear();

                MySqlDataReader leitor = cmd.ExecuteReader();

                lst_contatos.Items.Clear();

                while (leitor.Read())
                {
                    string[] row = new string[7];  // 7 colunas exibidas no ListView (ID, Nome, Tipo, Raça, Data de Nascimento, Peso, Telefone)

                    row[0] = leitor.GetInt32(0).ToString();  // id
                    row[1] = leitor.GetString(1);  // nome
                    row[2] = leitor.GetString(2);  // tipo Animal
                    row[3] = leitor.GetString(3);  // raça 
                    row[4] = leitor.GetDateTime(5).ToString("dd/MM/yyyy");  // Data de Nascimento 
                    row[5] = leitor.GetString(6);  // Peso 
                    row[6] = leitor.GetString(7);  // Telefone 

                    // criando um novo ListViewItem com os valores
                    var linha_listaview = new ListViewItem(row);

                    // adicionando a linha ao listview
                    lst_contatos.Items.Add(linha_listaview);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
