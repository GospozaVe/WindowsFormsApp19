using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Главная : Form
    {
        public Главная()
        {
            InitializeComponent();
        }

        

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Лаборант лаборант= new Лаборант();
            лаборант.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Нутрициолог нутрициолог = new Нутрициолог();
            нутрициолог.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Запись запись = new Запись();
            запись.Show();
        }
    }
}
