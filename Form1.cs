using Microsoft.EntityFrameworkCore;
using OkulApp_07_05_25.Modeller;
using OkulApp_07_05_25.VeriTabaný;

namespace OkulApp_07_05_25
{
    public partial class Form1 : Form
    {
        OkulDataContext context = new();
        public Form1()
        {
            InitializeComponent();

            OkulDataContext contex = new();
            if (context.Database.GetPendingMigrations().Count() > 0)
            {
                context.Database.Migrate();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var liste = context.Siniflar.ToList();

            lbSinifler.DataSource = liste;
            lbSinifler.DisplayMember = "Ad";
            lbSinifler.ValueMember = "Id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbSinif yeni = new();
            yeni.Ad = txtSinifAd.Text;
            context.Siniflar.Add(yeni);
            context.SaveChanges();

            button1_Click(sender, e);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DbSinif secili = lbSinifler.SelectedItem as DbSinif;

            secili.Ad = txtSinifAd.Text;
            context.SaveChanges();

            button1_Click(sender, e);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DbSinif secili = lbSinifler.SelectedItem as DbSinif;

            context.Siniflar.Remove(secili);

            context.SaveChanges();

            button1_Click(sender, e);
        }
    }
}
