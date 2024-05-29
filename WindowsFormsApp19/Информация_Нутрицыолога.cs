using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    enum RowState
    {
        Deleted
    }

   
    public partial class Информация_Нутрицыолога : Form
    {

        DB DB = new DB();
        public int id;
        public Информация_Нутрицыолога()
        {
            InitializeComponent();
            NytriziologShow();
            LaborantShow();
            KlientShow();
        }

        private void NytriziologShow()
        {
            DB.openConnection();
            SqlCommand com = new SqlCommand(@"SELECT * from Nytriziolog ", DB.sqlConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Nytriziolog");
            dataGridView2.DataSource = ds.Tables[0];
            DB.closeConnection();
        }

        private void LaborantShow()
        {
            DB.openConnection();
            SqlCommand com = new SqlCommand(@"SELECT * from Laborant", DB.sqlConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Laborant");
            dataGridView1.DataSource = ds.Tables[0];
            DB.closeConnection();
        }

        private void KlientShow()
        {
            DB.openConnection();
            SqlCommand com = new SqlCommand(@"SELECT * from Klient ", DB.sqlConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            adapter.Fill(ds, " Klient");
            dataGridView3.DataSource = ds.Tables[0];
            DB.closeConnection();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Информация_Нутрицыолога_Load(object sender, EventArgs e)
        {

        }

       

        private void Deleted()
        {
            try
            {
                int index = dataGridView2.CurrentCell.RowIndex;
                dataGridView2.Rows[index].Visible = false;
                string Message = "Вы точно хотите удалить запись";

                if (MessageBox.Show(Message, "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                var id = Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value);
                string sql = "delete from Nytriziolog where id =" + id;
                ExecSQL(sql);

                if (dataGridView2.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    dataGridView2.Rows[index].Cells[2].Value = RowState.Deleted;
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Не выделена строчка");
            }

        }

        private void ExecSQL(string sql)
        {
            DB.openConnection();
            var com = new SqlCommand(sql, DB.getConnection());
            com.CommandText = sql;
            com.ExecuteNonQuery();
            DB.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deleted();
        }

        private void NewFild()
        {
            try
            {
                DB.openConnection();

                var Клиент = textBox1.Text;
                var Время = textBox2.Text;
                var Програма_Питания = textBox3.Text;
                var Аллергия = textBox4.Text;
                var Для_Кого = textBox5.Text;
                var addQ = $"insert into Nytriziolog  (Клиент, Время, Програма_Питания ,Аллергия ,Для_Кого) values ('{Клиент}', '{Время}', '{Програма_Питания}', '{Аллергия}', '{Для_Кого}')";
                var com = new SqlCommand(addQ, DB.getConnection());
                com.ExecuteNonQuery();
                MessageBox.Show("Запись созданна");

                DB.closeConnection();
            }
            catch
            {
                MessageBox.Show("Ошибка! Убедитесь что поле ID пустое");
                textBox1.Text = " ";
            }

   

        

       


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                id = Convert.ToInt32(row.Cells[0].Value);
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
                textBox5.Text = row.Cells[5].Value.ToString();
            }

            catch
            {
                MessageBox.Show("Вы выбрали пустую строчку!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                id = Convert.ToInt32(row.Cells[0].Value);
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
                
            }

            catch
            {
                MessageBox.Show("Вы выбрали пустую строчку!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
