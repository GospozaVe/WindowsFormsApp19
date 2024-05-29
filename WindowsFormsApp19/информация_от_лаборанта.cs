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
using System.Data.SqlClient;

namespace WindowsFormsApp19
{
    enum RowState1
    {
        Deleted
    }
    public partial class информация_от_лаборанта : Form
    {

        DB DB = new DB();
        public int id;


        public информация_от_лаборанта()
        {
            InitializeComponent();
            LaborantShow();
        }

        private void информация_от_лаборанта_Load(object sender, EventArgs e)
        {

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

        private void ExecSQL(string sql)
        {
            DB.openConnection();
            var com = new SqlCommand(sql, DB.getConnection());
            com.CommandText = sql;
            com.ExecuteNonQuery();
            DB.closeConnection();
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

        private void Udalit_Click(object sender, EventArgs e) // Кать тебе не нужно удалять строчки с dataGridView1, его нужно обновить (тоесть заново вывести, что бы изменения вступили в силу)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[index].Visible = false;
                string Message = "Вы точно хотите удалить запись";

                if (MessageBox.Show(Message, "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                string sql = "delete from Nytriziolog where id =" + id;
                ExecSQL(sql); // *Возможно* забыла открыть соединение

                //if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)  // Вместо этого кода вставь LaborantShow();
                //{
                //    dataGridView1.Rows[index].Cells[2].Value = RowState1.Deleted;
                //    return;
                //}
            }
            catch
            {
                MessageBox.Show("Не выделена строчка");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // Йоданый рот, стращно, но все верно
        {
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id = Convert.ToInt32(row.Cells[0].Value);
                
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
                textBox5.Text = row.Cells[5].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();
                textBox7.Text = row.Cells[5].Value.ToString();
                textBox8.Text = row.Cells[5].Value.ToString();
                textBox9.Text = row.Cells[5].Value.ToString();
                textBox10.Text = row.Cells[5].Value.ToString();
                textBox11.Text = row.Cells[5].Value.ToString();
                textBox12.Text = row.Cells[1].Value.ToString();
                textBox13.Text = row.Cells[1].Value.ToString();
                textBox14.Text = row.Cells[1].Value.ToString();
                textBox15.Text = row.Cells[1].Value.ToString();
                textBox16.Text = row.Cells[1].Value.ToString();
                textBox17.Text = row.Cells[1].Value.ToString();
                
            }

            catch
            {
                MessageBox.Show("Вы выбрали пустую строчку!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Dobavit_Click(object sender, EventArgs e)
        {

        }
    }
}


// Кароче работы да жопы, а недели 2 осталось, я конечно не волшебник что бы помочь с этим кодом за 2 дня,
// но все же порекомендую за эти 2 дня уделить внимание проекту и изучению гайдов, вместо тиктоков и музыки с ютубчиков 😜
// Не говорю что мол забей на это хуй, но удели проекту чуточку больше времени чем сидению жопой на одном месте.

// Вот хы.
// P.S. если будет нужна помощь, то это будет платно потому что надо на что то жить 😋
