﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cinema_be_s3_l3
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CinemaDb"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open(); //apriamo la connessione

                string query1 = "select count(*) from Spettatore where Sala='rossa'"  ;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query1;
                SqlDataReader reader = cmd.ExecuteReader();
                
                showSalaRossa.InnerText ="aaa" + reader.GetString(0);
                
            }
            catch(Exception ex) 
            {
                showSalaRossa.InnerText=ex.Message;

            }
            finally
            {
                conn.Close();
            }
        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CinemaDb"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);
            
            try
            {
                conn.Open(); //apriamo la connessione

                string query = "INSERT INTO Spettatore (Nome, Cognome, Sala,Ridotto) VALUES (@Nome, @Cognome, @Sala, @Ridotto)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nome", nome.Text);
                cmd.Parameters.AddWithValue("@Cognome", cognome.Text);
                cmd.Parameters.AddWithValue("@Sala", sceltaSala.Text);
                cmd.Parameters.AddWithValue("@Ridotto", ridotto.Checked);
                cmd.ExecuteNonQuery();

            }
            catch
            {
                //DettaglioCliente.InnerHtml = "Errore!";

            }
            finally
            {
                conn.Close();
            }
        }
    }
}