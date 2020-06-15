using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prova2BimestreFunc
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = Conexao.Connection;
                cmd.CommandText = @"insert into funcionario (nom_fun, sex_fun, dt_nasc_fun, num_crt_trab_fun, tel_fix_fun, tel_cel_fun, email_fun, log_end_fun, num_end_fun, bair_end_fun, cid_end_fun, uf_end_fun) 
                                    values (@nome, @sexo, @datNasc, @carteira, @tel_fixo, @tel_cell, @email, @log, @num, @bair, @cidade, @uf);";

                cmd.Parameters.AddWithValue("nome", txtNome.Text);
                cmd.Parameters.AddWithValue("sexo", ddlSexo.SelectedValue);
                cmd.Parameters.AddWithValue("datNasc", txtDataNasc.Text);
                cmd.Parameters.AddWithValue("carteira", txtCarteiraTrab.Text);
                cmd.Parameters.AddWithValue("tel_fixo", txtTelFixo.Text);
                cmd.Parameters.AddWithValue("tel_cell", txtTelCel.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("log", txtLog.Text);
                cmd.Parameters.AddWithValue("num", txtNum.Text);
                cmd.Parameters.AddWithValue("bair", txtBairro.Text);
                cmd.Parameters.AddWithValue("cidade", txtCidade.Text);
                cmd.Parameters.AddWithValue("uf", txtUF.Text);

                Conexao.Conectar();

                cmd.ExecuteNonQuery();
                lblResultado.Text = "Inserido!";
            }
            catch (Exception ex)
            {
                lblResultado.Text = $"Falha: {ex.Message}";
            }
            finally
            {
                Conexao.Desconectar();
            }

        }
    }
}