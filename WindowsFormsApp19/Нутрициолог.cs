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

namespace WindowsFormsApp19
{
    public partial class Нутрициолог : Form
    {
        DB dbs = new DB();
        public Нутрициолог()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Информация_Нутрицыолога информация_Нутрицыолога = new Информация_Нутрицыолога();
            информация_Нутрицыолога.Show();


            //var loginUser = textBox1.Text;
            //var passUser = textBox2.Text;

            //SqlDataAdapter adapter = new SqlDataAdapter();
            //DataTable table = new DataTable();

            //string querystring = $"select логин, пароль from Klient  where логин ='{loginUser}' and пароль = '{passUser}'";


            //SqlCommand command = new SqlCommand(querystring, dbs.getConnection());

            //adapter.SelectCommand = command;
            //adapter.Fill(table);

            //if (table.Rows.Count == 1)
            //{
            //    MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}

            //else
            //{
            //    MessageBox.Show("Такого человечка нет!", " НЕ Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //}

        }
        

    }
}
