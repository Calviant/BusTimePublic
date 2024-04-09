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
    public partial class emVoditel : Form
    {
        public emVoditel()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-96VRCH3;Initial Catalog=bus1;Integrated Security=True");

        private void Addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (voditel_idtb.Text == "" || voditel_name.Text == "" || voditel_lastname.Text == "" || voditel_phone.Text == "" || voditel_numUDtb.Text == "")
                    MessageBox.Show("Не во всех полях есть данные");
                else
                {
                    Con.Open();

                    // Проверка, существует ли уже такой продукт
                    string checkQuery = "SELECT COUNT(*) FROM voditel where ID_Voditel=" + voditel_idtb.Text + ";";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, Con))
                    {
                        checkCmd.Parameters.AddWithValue("ID_Voditel", voditel_idtb.Text);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Водитель с таким ID уже существует!");
                            Con.Close();
                        }

                        else
                        {
                            Con.Close();
                            Con.Open();
                            string query = "insert into voditel values(" + voditel_idtb.Text + ", '" + voditel_name.Text + "', '" + voditel_lastname.Text + "','" + voditel_numUDtb.Text + "', '" + voditel_phone.Text + "')";
                            SqlCommand cmd = new SqlCommand(query, Con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Водитель добавлен успешно!");
                            Con.Close();
                            populate();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from voditel";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            VoditelDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void emVoditel_Load(object sender, EventArgs e)
        {
            populate();
            fillcombo();
        }

        private void VoditelDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = VoditelDGV.Rows[e.RowIndex];
            voditel_idtb.Text = selectedRow.Cells[0].Value.ToString();
            voditel_name.Text = selectedRow.Cells[1].Value.ToString();
            voditel_lastname.Text = selectedRow.Cells[2].Value.ToString();
            voditel_numUDtb.Text = selectedRow.Cells[3].Value.ToString();
            voditel_phone.Text = selectedRow.Cells[4].Value.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Hide();
            Form emReisy = new emReisy();
            emReisy.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Hide();
            Form emPasahir = new emPasahir();
            emPasahir.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Hide();
            Form emAvtobus = new emAvtobus();
            emAvtobus.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Hide();
            Form emBilet = new emBilet();
            emBilet.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form Login = new Login();
            Login.Show();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            Form emMainForm = new emMainForm();
            emMainForm.Show();
        }

        private void FIOVodCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FIOVodCB.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)FIOVodCB.SelectedItem;
                nameVOD.Text = selectedRow["Imya"].ToString();
            }
            Con.Open();

            string query = $"SELECT * FROM voditel WHERE Imya = '{nameVOD.Text}'";


            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            VoditelDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void fillcombo()
        {

            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Imya + ' ' + Familiya AS FullName, Imya FROM voditel", Con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("FullName", typeof(string));
            dt.Load(rdr);
            FIOVodCB.ValueMember = "FullName";
            FIOVodCB.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                nameVOD.Text = dt.Rows[0]["Imya"].ToString();
            }

            Con.Close();
        }

       

        private void tbre_Click_1(object sender, EventArgs e)
        {
            populate();
        }
    }
}
