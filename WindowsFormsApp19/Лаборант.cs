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
    public partial class Лаборант : Form
    {
        DB dbs = new DB();
        public Лаборант()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            информация_от_лаборанта информация_От_Лаборанта = new информация_от_лаборанта();
            информация_От_Лаборанта.Show();

           

        }
         
    }
    
}
