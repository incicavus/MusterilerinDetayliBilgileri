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
namespace Challenge2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        SqlConnection con = new SqlConnection(@"server=WIN7-BILGISAYAR\SQLEXPRESS; database=NET11DB; integrated security=true");

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SiraliFirmalar", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            adp.Fill(dt);

            cbMusteriler.DisplayMember = "Musteri";
            cbMusteriler.ValueMember = "Musteri";
            cbMusteriler.DataSource = dt;
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            SqlDataAdapter urun = new SqlDataAdapter("select Urun as [Satın Alınan Ürünler] from Firmalar where Musteri=@musteri", con);
            urun.SelectCommand.Parameters.AddWithValue("@musteri", cbMusteriler.SelectedValue);

            DataTable dt = new DataTable();
            urun.Fill(dt);
            gvGosterim.DataSource = dt;

        }

        private void btnKacSatis_Click(object sender, EventArgs e)
        {
            SqlDataAdapter Satis = new SqlDataAdapter("select COUNT(*) as [Satış Sayısı],tarih from Firmalar where Musteri = @musteri and Tarih between @tarih1 and @tarih2 group by tarih", con);

            Satis.SelectCommand.Parameters.AddWithValue("@musteri", cbMusteriler.SelectedValue);
            Satis.SelectCommand.Parameters.AddWithValue("@tarih1", dateTimePicker1.Value);
            Satis.SelectCommand.Parameters.AddWithValue("@tarih2", dateTimePicker2.Value);

            DataTable dt = new DataTable();
            Satis.Fill(dt);
            gvGosterim.DataSource = dt;




        }

        private void btnEnYuksek_Click(object sender, EventArgs e)
        {
            SqlDataAdapter enYuksek = new SqlDataAdapter("select Urun as [En Yüksek Satışa Sahip Ürün],tutar as [En Yüksek Satış Tutarı] from Firmalar where Musteri=@musteri and Tutar=(select max(tutar) from Firmalar where Musteri=@musteri)", con);

            enYuksek.SelectCommand.Parameters.AddWithValue("@musteri", cbMusteriler.SelectedValue);

            DataTable dt = new DataTable();
            enYuksek.Fill(dt);
            gvGosterim.DataSource = dt;

        }

        private void btnEnDusuk_Click(object sender, EventArgs e)
        {
            SqlDataAdapter enDusuk = new SqlDataAdapter("select Urun as [En Düşük Satışa Sahip Ürün],tutar as [En Yüksek Satış Tutarı] from Firmalar where Musteri=@musteri and Tutar=(select min(tutar) from Firmalar where Musteri=@musteri)", con);

            enDusuk.SelectCommand.Parameters.AddWithValue("@musteri", cbMusteriler.SelectedValue);

            DataTable dt = new DataTable();
            enDusuk.Fill(dt);
            gvGosterim.DataSource = dt;

        }
    }
}
