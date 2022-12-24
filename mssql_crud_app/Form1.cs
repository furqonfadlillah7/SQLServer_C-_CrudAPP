using System.Data;
using System.Data.SqlClient;

namespace mssql_crud_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-COGENAIJ\\SQLEXPRESS;Initial Catalog=MhsDB;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into TableMhs values (@NIM,@Nama,@Jurusan)",con);
            cmd.Parameters.AddWithValue("@NIM", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Nama", textBox2.Text);
            cmd.Parameters.AddWithValue("@Jurusan", textBox3.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data Tersimpan");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-COGENAIJ\\SQLEXPRESS;Initial Catalog=MhsDB;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from TableMhs where NIM=@NIM", con);
            cmd.Parameters.AddWithValue("@NIM", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

    }
}