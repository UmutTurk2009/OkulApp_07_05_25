using Microsoft.EntityFrameworkCore;
using OkulApp_07_05_25.Modeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OkulApp_07_05_25.VeriTabanı
{
    public class OkulDataContext: DbContext
    {
        //Tabloyu tanıttık
        public DbSet<DbSinif> Siniflar { get; set; }

        public OkulDataContext()
        {
            
        }


        //Veritabanı bağlantı dizesi
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dosya = "okul_veritabani.db";
            optionsBuilder.UseSqlite($"Data Source = {dosya}");
        }
        
       
    

        

    }
}
