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
using System.Threading;
using System.Reflection.Emit;

namespace MyCourseWork
{
    public partial class Success : Form
    {

        public Success()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            SpeechToText speech = new SpeechToText();
            this.Hide();
            speech.ShowDialog();
        }
    }
    //private void button1_Click(object sender, EventArgs e)
    //{

    ////    string connetionString;
    ////    SqlConnection cnn;
    ////    connetionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=master;Integrated Security=true";
    ////    cnn = new SqlConnection(connetionString);
    ////    cnn.Open();
    ////  //  MessageBox.Show("Connection Open  !");
    ////   // cnn.Close();

    ////    SqlCommand command;
    ////    SqlDataReader dataReader;
    ////    String sql, Output = "";

    ////    sql = "Select login,link from users";

    ////    command = new SqlCommand(sql, cnn);

    ////    dataReader = command.ExecuteReader();

    ////    while (dataReader.Read())
    ////    {
    ////        Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
    ////    }

    ////    MessageBox.Show(Output);

    ////    dataReader.Close();
    ////    command.Dispose();
    ////    cnn.Close();
    //}
}

