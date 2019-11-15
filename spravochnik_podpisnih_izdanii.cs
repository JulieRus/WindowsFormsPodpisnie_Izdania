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

namespace WindowsFormsAppPodpisnieizdania
{
    public partial class spravochnik_podpisnih_izdanii : Form
    {

        public spravochnik_podpisnih_izdanii()
        {
            InitializeComponent();
            

           

            /*private void Label3_Click(object sender, EventArgs e)
            {

            }*/

            /*private void Spravochnik_podpisnih_izdanii_Load(object sender, EventArgs e)
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "_po_16_20_23_KulinariaDataSet.izdania". При необходимости она может быть перемещена или удалена.
               // this.izdaniaTableAdapter.Fill(this._po_16_20_23_KulinariaDataSet.izdania);

            }

            private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }*/
        }

        private void Spravochnik_podpisnih_izdanii_Load(object sender, EventArgs e)
        {

        }

        /*private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Spravochnik_podpisnih_izdanii_Load_1(object sender, EventArgs e)
        {
            
        }*/

        private void Button3_Click_1(object sender, EventArgs e) //отобразить весь перечень
        {
            DataSet ds;
            SqlDataAdapter adapter;
            SqlCommandBuilder commandBuilder;
            string connectionString = @"Data Source=MSSQLSTUD\SQLEXPRESS;Initial Catalog=po-16-20-23.Kulinaria;User Id =po-16-20-23 ; Password =idi4aeMo ";
            string sql = "SELECT * FROM izdania";

            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridView1.AllowUserToAddRows = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
            }
        }

        private void Button4_Click(object sender, EventArgs e)// отобразить с параметром
        {
            DataSet ds;
            SqlDataAdapter adapter;
            SqlCommandBuilder commandBuilder;
            string connectionString = @"Data Source=MSSQLSTUD\SQLEXPRESS;Initial Catalog=po-16-20-23.Kulinaria;User Id =po-16-20-23 ; Password =idi4aeMo ";
            string sql = "SELECT indeks_izdania,vid_izdania, nazvanie_izdania FROM izdania WHERE indeks_izdania=@indeks_izdania ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand(sql, connection);// создаем параметр для индекса издания
                SqlParameter nameParam1 = new SqlParameter("@indeks_izdania", textBox4.Text);
                // добавляем параметр к команде
                command1.Parameters.Add(nameParam1);
                //command1.ExecuteReader();
                adapter = new SqlDataAdapter(command1);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                
               
                /*SqlCommand command2 = new SqlCommand(sql, connection);
                // создаем параметр для названия издания
                SqlParameter nameParam2 = new SqlParameter("@nazvanie_izdania", nazvanie_izdania); 
                // добавляем параметр к команде
                command2.Parameters.Add(nameParam2);*/
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            DataSet ds;
            SqlDataAdapter adapter;
            SqlCommandBuilder commandBuilder;
            string connectionString = @"Data Source=MSSQLSTUD\SQLEXPRESS;Initial Catalog=po-16-20-23.Kulinaria;User Id =po-16-20-23 ; Password =idi4aeMo ";
            string sql = "SELECT indeks_izdania,vid_izdania, nazvanie_izdania FROM izdania WHERE nazvanie_izdania=@nazvanie_izdania ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand(sql, connection);// создаем параметр для индекса издания
                SqlParameter nameParam1 = new SqlParameter("@nazvanie_izdania", textBox3.Text);
                // добавляем параметр к команде
                command1.Parameters.Add(nameParam1);
                //command1.ExecuteReader();
                adapter = new SqlDataAdapter(command1);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];

            }
        }
    }
} 
