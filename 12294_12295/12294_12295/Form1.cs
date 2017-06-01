using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace _12294_12295
{
    public partial class Form1 : Form
    {
        static string strCn = "Data Source=sql.fiap.com.br;Initial Catalog=3EMIA;User ID=RM12294;Password=230200";
        SqlConnection conexao = new SqlConnection(strCn);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtBairro.Clear();
            txtCEP.Clear();
            txtCPF.Clear();
            txtUF.Clear();
            txtLogradouro.Clear();
            txtComplemento.Clear();
            picCPFStatus.Image = null;
            pcbUsuario.Image = null;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = "select * from tb_AC_cliente_02 where cpf = @CPF";

            
            SqlCommand cmd = new SqlCommand(pesquisa, conexao);
            
            cmd.Parameters.AddWithValue("@CPF", txtCPF.Text.Replace(".", "").Replace("-", "").Trim());
            
            SqlDataReader DR;
            
            try
            {
                
                conexao.Open();
                
                DR = cmd.ExecuteReader();
                
                if (DR.Read())
                {
                    
                    txtCPF.Text = DR.GetValue(0).ToString();
                    txtNome.Text = DR.GetValue(1).ToString();
                    txtTelefone.Text = DR.GetValue(2).ToString();
                    txtEmail.Text = DR.GetValue(3).ToString();
                    txtCEP.Text = DR.GetValue(4).ToString();
                    txtLogradouro.Text = DR.GetValue(5).ToString();
                    txtComplemento.Text = DR.GetValue(6).ToString();
                    txtBairro.Text = DR.GetValue(7).ToString();
                    txtUF.Text = DR.GetValue(8).ToString();
                    if (DR.GetValue(9).ToString() == "naotem")
                    {
                        pcbUsuario.Image = null;
                    }
                    else
                    {
                        pcbUsuario.Load(@"./images_db/" + DR.GetValue(9).ToString());
                    }
                    
                }
               
                else
                {
                    MessageBox.Show("Cliente não encontrado.");
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtTelefone.Clear();
                    txtBairro.Clear();
                    txtCEP.Clear();
                    txtUF.Clear();
                    txtLogradouro.Clear();
                    txtComplemento.Clear();
                    pcbUsuario.Image = null;
                } 
                DR.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Ocorreu um erro durante o processo. Tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string adiciona = "insert into tb_AC_cliente_02 values (@CPF, @Nome, @Telefone, @Email, @CEP, @Logradouro, @Complemento, @Bairro, @UF, @Imagem)";
            SqlCommand cmd = new SqlCommand(adiciona, conexao);
            cmd.Parameters.AddWithValue("@CPF", txtCPF.Text.Replace(".", "").Replace("-", "").Trim());
            cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@CEP", txtCEP.Text.Replace(".", "").Replace("-", "").Trim());
            cmd.Parameters.AddWithValue("@Logradouro", txtLogradouro.Text);
            cmd.Parameters.AddWithValue("@Bairro", txtBairro.Text);
            cmd.Parameters.AddWithValue("@Complemento", txtComplemento.Text);
            cmd.Parameters.AddWithValue("@UF", txtUF.Text);

            if (pcbUsuario.Image != null)
            {
                
                string filename = Path.GetFileNameWithoutExtension(openFileDialog1.FileName) + DateTime.Now.ToString("yyyy-MM-dd_HH_mm_ss") + Path.GetExtension(openFileDialog1.FileName);

                string directory = "Images_db";
                Directory.CreateDirectory(directory);
                if (Directory.Exists(directory))
                {


                    File.Copy(openFileDialog1.FileName, Path.Combine(directory, filename));
                }

                cmd.Parameters.AddWithValue("@Imagem", filename);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Imagem", "naotem");
            }

            string checarCPF = "select count(*) from tb_AC_cliente_02 where cpf = '" + txtCPF.Text.Replace(".", "").Replace("-", "").Trim() + "'";
            SqlCommand TotalCPF = new SqlCommand(checarCPF, conexao);

            try
            {
                conexao.Open();
                int total = Convert.ToInt16(TotalCPF.ExecuteScalar());
                conexao.Close();



                if (total == 1)
                {
                    MessageBox.Show("Já existe um cliente cadastrado com este CPF.", "CPF Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    conexao.Open();
                    int resultado;
                    resultado = cmd.ExecuteNonQuery();
                    if (resultado == 1)
                    {
                        MessageBox.Show("Cliente cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK);
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtTelefone.Clear();
                        txtBairro.Clear();
                        txtCEP.Clear();
                        txtCPF.Clear();
                        txtUF.Clear();
                        txtLogradouro.Clear();
                        txtComplemento.Clear();
                        pcbUsuario.Image = null;
                        picCPFStatus.Image = null;
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro durante o processo. Tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                conexao.Close();
            }
        
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            string numcpf = txtCPF.Text;
            numcpf = numcpf.Replace(".", "").Replace("-", "").Trim();

            if ((numcpf.Length != 11) || (numcpf == "00000000000") || (numcpf == "11111111111") || (numcpf == "22222222222") || (numcpf == "33333333333") || (numcpf == "44444444444") || (numcpf == "55555555555") || (numcpf == "66666666666") || (numcpf == "77777777777") || (numcpf == "88888888888") || (numcpf == "99999999999"))
            {
                MessageBox.Show("Digite um CPF corretamente.");
            }
            else
            {
                string cpf, digito;
                int soma, resto;
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                cpf = numcpf.Substring(0, 9);
                soma = 0;

                for (int i = 0; i < 9; i++)
                {
                    soma += int.Parse(cpf[i].ToString()) * multiplicador1[i];
                }

                resto = soma % 11;
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }

                digito = resto.ToString();
                cpf = cpf + digito;
                soma = 0;

                for (int i = 0; i < 10; i++)
                {
                    soma += int.Parse(cpf[i].ToString()) * multiplicador2[i];
                }

                resto = soma % 11;
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }
                digito = digito + resto.ToString();

                bool final = numcpf.EndsWith(digito);

                if (final)
                {
                    picCPFStatus.Image = Properties.Resources.ok;
                }
                else
                {
                    picCPFStatus.Image = Properties.Resources.erro;
                    txtCPF.Focus();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string remove = "delete from tb_AC_cliente_02 where cpf= " + txtCPF.Text.Replace(".", "").Replace("-", "").Trim();
            
            SqlCommand cmd = new SqlCommand(remove, conexao);
            try
            {

                conexao.Open();

                int resultado;
                if (MessageBox.Show("Tem certeza que deseja remover este registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    resultado = cmd.ExecuteNonQuery();

                    if (resultado == 1)
                    {
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtTelefone.Clear();
                        txtBairro.Clear();
                        txtCEP.Clear();
                        txtCPF.Clear();
                        txtUF.Clear();
                        txtLogradouro.Clear();
                        txtComplemento.Clear();
                        pcbUsuario.Image = null;
                        picCPFStatus.Image = null;
                        MessageBox.Show("Registro removido com sucesso.");
                    }

                    cmd.Dispose();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ocorreu um erro durante o processo. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string altera = "update tb_AC_cliente_02 set nome= @Nome, email = @Email, telefone = @Telefone, cep = @CEP, logradouro = @Logradouro, complemento = @Complemento, bairro = @Bairro, uf = @UF, foto = @Imagem where cpf= @CPF";

            SqlCommand cmd = new SqlCommand(altera, conexao);
            cmd.Parameters.AddWithValue("@CPF", txtCPF.Text.Replace(".", "").Replace("-", "").Trim());
            cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@CEP", txtCEP.Text.Replace(".", "").Replace("-", "").Trim());
            cmd.Parameters.AddWithValue("@Logradouro", txtLogradouro.Text);
            cmd.Parameters.AddWithValue("@Bairro", txtBairro.Text);
            cmd.Parameters.AddWithValue("@Complemento", txtComplemento.Text);
            cmd.Parameters.AddWithValue("@UF", txtUF.Text);

            if (pcbUsuario.Image != null)
            {

                string filename = Path.GetFileNameWithoutExtension(openFileDialog1.FileName) + DateTime.Now.ToString("yyyy-MM-dd_HH_mm_ss") + Path.GetExtension(openFileDialog1.FileName);

                string directory = "Images_db";
                if (Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);

                    File.Copy(openFileDialog1.FileName, Path.Combine(directory, filename));
                }

                cmd.Parameters.AddWithValue("@Imagem", filename);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Imagem", "naotem");
            }

            try
            {
                conexao.Open();
                int resultado;
                resultado = cmd.ExecuteNonQuery();
                if (resultado == 1)
                {
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtTelefone.Clear();
                    txtBairro.Clear();
                    txtCEP.Clear();
                    txtCPF.Clear();
                    txtUF.Clear();
                    txtLogradouro.Clear();
                    txtComplemento.Clear();
                    pcbUsuario.Image = null;
                    picCPFStatus.Image = null;

                    MessageBox.Show("Registro alterado com sucesso");
                }
                cmd.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro durante o processo. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnChecaCEP_Click(object sender, EventArgs e)
        {
            try
            {
                string rua;
                DataSet ds = new DataSet();
                string endereco = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txtCEP.Text);
                ds.ReadXml(endereco);
                rua = ds.Tables[0].Rows[0]["logradouro"].ToString();

                if (rua == "")
                {
                    MessageBox.Show("CEP não encontrado.", "CEP Inválido", MessageBoxButtons.OK);
                    txtCEP.Focus();
                }
                else
                {
                    txtLogradouro.Text = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString() + " " + rua;
                    txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                    txtUF.Text = ds.Tables[0].Rows[0]["uf"].ToString();
                    txtComplemento.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Serviço Indisponível. Tente novamente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form sobre = new Sobre();

            sobre.Show();
        }

        private void btnArquivoFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pcbUsuario.Load(openFileDialog1.FileName);
            }
        }

        private void btnImgLimpar_Click(object sender, EventArgs e)
        {
            pcbUsuario.Image = null;
        }
    }
}
