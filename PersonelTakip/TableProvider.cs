using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PersonelTakip
{
    public class TableProvider<T> where T : class
    {
        SqlConnection baglanti;
        public TableProvider(SqlConnection baglanti)
        {
            this.baglanti = baglanti;
        }
        public List<T> ListeGetir()
        {
            string tblAd = typeof(T).Name;

            var attr = typeof(T).GetCustomAttribute<TabloAdiAttribute>();

            if (attr != null)
            {
                tblAd = attr.TabloAdi;
            }

            SqlCommand cmd = new SqlCommand($"SELECT * FROM {tblAd}", baglanti);

            if (baglanti.State == System.Data.ConnectionState.Closed)
                baglanti.Open();

            var okuyucu = cmd.ExecuteReader();

            var props = typeof(T).GetProperties();

            List<T> liste = new();

            while (okuyucu.Read())//bir kayıt geldi
            {
                T nesne = Activator.CreateInstance<T>();//model

                for (int i = 0; i < okuyucu.FieldCount; i++)//gelen veride kaç alan var
                {
                    string colName = okuyucu.GetName(i);//i.alanın adı ne

                    var p = props.FirstOrDefault(x => x.Name == colName);//bu isimde modelde property var mı

                    if (p != null)//var ise
                    {
                        if (p.CanWrite)//ve yazılabilir ise
                        {
                            var data = okuyucu.GetValue(i);

                            if (data == DBNull.Value)
                                p.SetValue(nesne, null);//model üzerindeki bu propertye değeri yaz
                            else
                                p.SetValue(nesne, data);
                        }
                    }
                }



                liste.Add(nesne);//yeni nesneyi liseye ekle

            }

            okuyucu.Close();

            return liste;
        }

        public T Getir(int id)
        {
            return null;
        }

        public void Sil(int id)
        {

        }

        public void Guncelle(T kayit, int id)
        {

        }

        public void Ekle(T kayit)
        {

        }
    }
}