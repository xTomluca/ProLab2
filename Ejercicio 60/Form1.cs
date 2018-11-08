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

namespace Ejercicio_60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionStr = "Data Source=LAB3PC25\\SQLEXPRESS; Initial Catalog=AdventureWorks2012;Integrated Security=True";
            SqlConnection sql = new SqlConnection(connectionStr);
            try
            {
                sql.Open();
                MessageBox.Show("ABRIO PERRI");
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = sql;
            command.CommandText = "SELECT Name FROM Production.Product";
            string aux;
            StringBuilder stringBuilder = new StringBuilder();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                aux = reader["Name"].ToString();
                stringBuilder.AppendLine(aux);
            }
                sql.Close();
            string test = "UPDATE Production.Product SET Name = 'Jose' where ProductID=1";
                command.CommandText = test;
               sql.Open();
                command.ExecuteNonQuery();

            ricardoElTexto.Text = stringBuilder.ToString();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }
    }
}
