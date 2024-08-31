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

namespace Rehber_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-KIMUOA0\SQLEXPRESS;Initial Catalog=DbRehberUygulama;Integrated Security=True");
        void listele()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * From TblKisiler", baglanti);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch 
            {
                MessageBox.Show("sorun yaşandı lütfen bir daha deneyiniz","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void temizle()
        {
            try
            {
                textBoxID.Text = "";
                textBoxAD.Text = "";
                textBoxSOYAD.Text = "";
                maskedTextBoxTEL.Text = "";
                textBoxMAIL.Text = "";
                textBoxAD.Focus();

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void buttonEKLE_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TblKisiler(AD,SOYAD,TELEFON,MAIL) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", textBoxAD.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSOYAD.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBoxTEL.Text);
            komut.Parameters.AddWithValue("@p4",textBoxMAIL.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi rehbere kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void buttonTEMIZLE_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBoxID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBoxAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxSOYAD.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            maskedTextBoxTEL.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBoxMAIL.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void buttonSIL_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu kişiyi rehberden silmek istediğinize emin misiniz?", "Kişiyi Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from TblKisiler where ID=" + textBoxID.Text, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kişi rehberden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            listele();
            temizle();
        }

        private void buttonGUNCELLE_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TblKisiler set AD=@p1,SOYAD=@p2,TELEFON=@p3,MAIL=@p4 where ID=@p5", baglanti);
            
            komut.Parameters.AddWithValue("@p1", textBoxAD.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSOYAD.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBoxTEL.Text);
            komut.Parameters.AddWithValue("@p4", textBoxMAIL.Text);
            komut.Parameters.AddWithValue("@p5", textBoxID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close() ;
            MessageBox.Show("Kişi Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle() ;
        }
    }
}
