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
    public partial class emReisy : Form
    {
        public emReisy()
        {
            InitializeComponent();
            dataOTtp.Format = DateTimePickerFormat.Custom;
            dataOTtp.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dataOTtp.ShowUpDown = true;
            dataPRIBtp.Format = DateTimePickerFormat.Custom;
            dataPRIBtp.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dataPRIBtp.ShowUpDown = true;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-96VRCH3;Initial Catalog=bus1;Integrated Security=True");

        private void Addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (reisy_numtb.Text == "" || reisy_idvodtb.Text == "" || reisy_IdAvttb.Text == "" || reisy_mestoOTtb.Text == "" || reisy_mestoNAZtb.Text == "")
                    MessageBox.Show("Не во всех полях есть данные");
                else
                {
                    Con.Open();

                    // Проверка, существует ли уже такой продукт
                    string checkQuery = "SELECT COUNT(*) FROM Reisy where ID_Reisy=" + reisy_numtb.Text + ";";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, Con))
                    {
                        checkCmd.Parameters.AddWithValue("ID_Reisy", reisy_numtb.Text);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Рейс с таким ID уже существует!");
                            Con.Close();
                        }

                        else
                        {
                            Con.Close();
                            string query = "INSERT INTO Reisy VALUES (@reisy_num, @reisy_idvod, @reisy_IdAvt, @mestoOT, @mestoNAZ, @dateOT, @datePRIB)";

                            using (SqlCommand cmd = new SqlCommand(query, Con))
                            {
                                cmd.Parameters.AddWithValue("@reisy_num", reisy_numtb.Text);
                                cmd.Parameters.AddWithValue("@reisy_idvod", reisy_idvodtb.Text);
                                cmd.Parameters.AddWithValue("@reisy_IdAvt", reisy_IdAvttb.Text);
                                cmd.Parameters.AddWithValue("@mestoOT", reisy_mestoOTtb.Text);
                                cmd.Parameters.AddWithValue("@mestoNAZ", reisy_mestoNAZtb.Text);
                                cmd.Parameters.AddWithValue("@dateOT", dataOTtp.Value);
                                cmd.Parameters.AddWithValue("@datePRIB", dataPRIBtp.Value);

                                Con.Open();
                                cmd.ExecuteNonQuery();
                                Con.Close();

                                MessageBox.Show("Рейс добавлен успешно!");
                                populate();
                            }

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
            string query = "select * from Reisy";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BusList.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void emReisy_Load(object sender, EventArgs e)
        {
            populate();
            fillcombo();
        }

        private void BusList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = BusList.Rows[e.RowIndex];
            reisy_numtb.Text = selectedRow.Cells[0].Value.ToString();
            reisy_idvodtb.Text = selectedRow.Cells[1].Value.ToString();
            reisy_IdAvttb.Text = selectedRow.Cells[2].Value.ToString();
            reisy_mestoOTtb.Text = selectedRow.Cells[3].Value.ToString();
            reisy_mestoNAZtb.Text = selectedRow.Cells[4].Value.ToString();
            dataOTtp.Text = selectedRow.Cells[5].Value.ToString();
            dataPRIBtp.Text = selectedRow.Cells[6].Value.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Hide();
            Form emVoditel = new emVoditel();
            emVoditel.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Hide();
            Form emPasahir = new emPasahir();
            emPasahir.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Hide();
            Form emAvtobus = new emAvtobus();
            emAvtobus.Show();
        }

        private void label4_Click(object sender, EventArgs e)
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
        private void BusList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (BusList.Columns[e.ColumnIndex].Name == "Data_Vremya_Otpravleniya" && e.Value != null)
            {
                e.Value = DateTime.Parse(e.Value.ToString()).ToString("MM.dd.yyyy HH:mm:ss");
                e.FormattingApplied = true;
            }
            if (BusList.Columns[e.ColumnIndex].Name == "Data_Vremya_Prebytiya" && e.Value != null)
            {
                e.Value = DateTime.Parse(e.Value.ToString()).ToString("MM.dd.yyyy HH:mm:ss");
                e.FormattingApplied = true;
            }
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            Form emMainForm = new emMainForm();
            emMainForm.Show();
        }

        private void idReisaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();


            string query = $"SELECT * FROM Reisy WHERE ID_Reisy = '{idReisaCB.Text}'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            BusList.DataSource = ds.Tables[0];


            Con.Close();
        }
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
        }

        private void tbre_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
