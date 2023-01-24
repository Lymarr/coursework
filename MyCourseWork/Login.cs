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

namespace MyCourseWork
{
    public partial class Search : Form
    {
        DataBase database = new DataBase();

     
        public Search()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void TranslateButton_Click(object sender, EventArgs e)
        {

            var login = LoginBox.Text;
            var link = LinkBox.Text;

            string querystring = $"insert into users (login, link) values  ('{login}','{link}')";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            database.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {

                Success success = new Success();
                this.Hide();
                success.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sorry, something went wrong. Check the data you used");
            }

            database.CloseConnection();

        }
            //adapter.SelectCommand = command;
            //adapter.Fill(table);
        }
    }

