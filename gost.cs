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

namespace KURSOVAYA
{
    public partial class gost : Form
    {
        public gost()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-96VRCH3;Initial Catalog=bus1;Integrated Security=True");

        private void fillcombo()
        {
            
            Con.Open();
            SqlCommand cmd = new SqlCommand("select ID_Reisy from Reisy", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_Reisy", typeof(string));
            dt.Load(rdr);
            idReisaCB.ValueMember = "ID_Reisy";
            idReisaCB.DataSource = dt;
            Con.Close();
            Con.Open();
            cmd = new SqlCommand("SELECT Imya + ' ' + Familiya AS FullName, Imya FROM voditel", Con);
            rdr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Columns.Add("FullName", typeof(string));
            dt.Load(rdr);
            fioVodCB.ValueMember = "FullName";
            fioVodCB.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                nameVOD.Text = dt.Rows[0]["Imya"].ToString();
            }
            
            Con.Close();





        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        

            Con.Open();

          
            string query = $"SELECT * FROM Reisy WHERE ID_Reisy = '{idReisaCB.Text}'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            DataView dv = new DataView(ds.Tables[0]);
            DataTable filteredTable = dv.ToTable(false, "ID_Voditel", "ID_avtobus", "Mesto_otpravleniya", "Mesto_naznacheniya", "Data_Vremya_Otpravleniya", "Data_Vremya_Prebytiya");

            goBusList.DataSource = filteredTable;


            Con.Close();
        }

        private void gost_Load(object sender, EventArgs e)
        {
            fillcombo();
            Con.Open();
            string query = "select * from Reisy";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            goBusList.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            if (fioVodCB.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)fioVodCB.SelectedItem;
                nameVOD.Text = selectedRow["Imya"].ToString();
            }
            Con.Open();

            string query = $"SELECT * FROM voditel WHERE Imya = '{nameVOD.Text}'";

            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                idVOD.Text = reader["ID_Voditel"].ToString();

            }
            
            Con.Close();
            

            Con.Open();

            int iddd = int.Parse(idVOD.Text);
            query = $"SELECT * FROM Reisy WHERE ID_Voditel = '{idVOD.Text}'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            DataView dv = new DataView(ds.Tables[0]);
            DataTable filteredTable = dv.ToTable(false, "ID_Voditel", "ID_avtobus", "Mesto_otpravleniya", "Mesto_naznacheniya", "Data_Vremya_Otpravleniya", "Data_Vremya_Prebytiya");

            goBusList.DataSource = filteredTable;


            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form Login = new Login();
            Login.Show();
        }
    }
}
