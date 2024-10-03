using MySql.Data.MySqlClient;


namespace WinFormsApp1
{

    public partial class Consulta : Form
    {
        private MySqlConnection Conexao;
        private string database = "datasource=localhost;username=root;password=Arthur22;database=db_petshop";

        public Consulta(string id, string nome, string tipoAnimal, string raca, string dataNascimento, string peso, string telefone)
        {
            InitializeComponent();

            // Exibe os dados nos controles, como labels ou textboxes
            lblId.Text = id;
            lblNome.Text = nome;
            lblanimal.Text = tipoAnimal;
            lblRaca.Text = raca;
            lblDataNascimento.Text = dataNascimento;
            lblPeso.Text = peso;
            lblTelefone.Text = telefone;

            CarregarHistoricoConsultas(id);

            ConfigurarListView();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(database);
                Conexao.Open();

                // Query para inserir uma nova consulta
                string sql = "INSERT INTO consultas (animal_id, data_consulta, sintomas) VALUES (@animal_id, @data_consulta, @sintomas)";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                comando.Parameters.AddWithValue("@animal_id", lblId.Text);
                comando.Parameters.AddWithValue("@data_consulta", dataconsulta.Value);
                comando.Parameters.AddWithValue("@sintomas", txtSintomas.Text);

                comando.ExecuteNonQuery();
                MessageBox.Show("Consulta marcada com sucesso!");

                // Fechar o formulário ou limpar os campos
                this.Close();
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

        // Método para configurar as colunas do ListView
        private void ConfigurarListView()
        {
            lstHistorico.View = View.Details; // Modo de visualização com colunas
            lstHistorico.FullRowSelect = true; // Seleciona a linha completa
            lstHistorico.GridLines = true; // Adiciona linhas entre os itens para melhorar a leitura

            // Adiciona as colunas
            lstHistorico.Columns.Clear(); // Limpa colunas antigas (se houver)
            lstHistorico.Columns.Add("Data/Hora", 150, HorizontalAlignment.Left); // Coluna para Data/Hora
            lstHistorico.Columns.Add("Sintomas", 300, HorizontalAlignment.Left); // Coluna para Sintomas
        }

        private void CarregarHistoricoConsultas(string animalId)
        {
            try
            {
                // conectando ao banco de dados
                Conexao = new MySqlConnection(database);
                Conexao.Open();

                // comando sql para selecionar a consulta do animal
                string sql = "SELECT id, data_consulta, sintomas FROM consultas WHERE animal_id = @animal_id";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao);
                cmd.Parameters.AddWithValue("@animal_id", animalId);

                MySqlDataReader leitor = cmd.ExecuteReader();

                // limpar o listview antes
                lstHistorico.Items.Clear();

                // lendo os dados do banco e adicionando no listview
                while (leitor.Read())
                {
                    // Cria um item de ListView com o ID da consulta (escondido), data e hora
                    ListViewItem item = new ListViewItem(leitor.GetInt32(0).ToString()); // Adiciona o ID da consulta (invisível)
                    item.SubItems.Add(leitor.GetDateTime(1).ToString("dd/MM/yyyy hh:mm tt")); // Adiciona Data/Hora
                    item.SubItems.Add(leitor.GetString(2));  // Adiciona os sintomas

                    // Adiciona o item ao ListView
                    lstHistorico.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar histórico de consultas: " + ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }


        private void btnCancelarConsulta_Click(object sender, EventArgs e)
        {
            if (lstHistorico.SelectedItems.Count > 0) // Certifica que uma consulta foi selecionada
            {
                // Captura o ID da consulta selecionada
                string consultaId = lstHistorico.SelectedItems[0].SubItems[0].Text;

                try
                {
                    Conexao = new MySqlConnection(database);
                    Conexao.Open();

                    // Query para deletar a consulta com base no ID
                    string sql = "DELETE FROM consultas WHERE id = @id";
                    MySqlCommand comando = new MySqlCommand(sql, Conexao);

                    comando.Parameters.AddWithValue("@id", consultaId);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Consulta cancelada com sucesso!");

                    // Recarregar o histórico para remover a consulta cancelada da lista
                    CarregarHistoricoConsultas(lblId.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cancelar consulta: " + ex.Message);
                }
                finally
                {
                    Conexao.Close();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma consulta para cancelar.");
            }
        }

    }
}
