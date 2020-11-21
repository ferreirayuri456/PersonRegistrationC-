
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace cadastroPessoas
{
    public partial class Form1 : Form
    {
        private VO.CrudVO crud;
        private Cadastro.Service.connectiondb connectiondb;
        private Int32 catchRowIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void carregarDados()
        {
            connectiondb = new Cadastro.Service.connectiondb();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string connection = connectiondb.getConnectionString();
            string query = "SELECT * FROM pessoa";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4]);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Error" + e);
                    }
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregarDados();
        }

  



        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                crud = new VO.CrudVO();
                crud.cpf = textBox2.Text;
                crud.nome = textBox1.Text;
                crud.endereco = textBox3.Text;
                crud.telefone = textBox4.Text;
                crud.Inserir();
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Error" + ex);
            }
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet2.pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.cadastroDataSet2.pessoa);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void findByAllToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void button6_Click(object sender, EventArgs e)
        {
            carregarDados();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                crud = new VO.CrudVO();
                crud.cpf = textBox2.Text;
                crud.nome = textBox1.Text;
                crud.endereco = textBox3.Text;
                crud.telefone = textBox4.Text;
                crud.Atualizar();
                dataGridView1[0, catchRowIndex].Value = textBox3.Text;
                dataGridView1[1, catchRowIndex].Value = textBox1.Text;
                dataGridView1[2, catchRowIndex].Value = textBox2.Text;
                dataGridView1[3, catchRowIndex].Value = textBox4.Text;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Error" + ex);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                crud = new VO.CrudVO();
                crud.cpf = textBox2.Text;
                crud.Excluir();
                dataGridView1.Rows.RemoveAt(catchRowIndex);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Error" + ex);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
