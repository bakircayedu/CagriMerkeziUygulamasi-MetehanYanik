using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CagriMerkeziUygulamasi_200601078
{
    public class MusteriKuyrugu
    {
        // C# Dilinin İçindeki Hazır Kütüphaneyi Kullanarak Kolaylıkla Kuyruk Yapısına ve Fonksiyonlarına Erişebiliyoruz.
        Queue<string> ticariKuyruk = new Queue<string>();
        Queue<string> bireyselKuyruk = new Queue<string>();



        public string[] ticariDizi;
        public string[] bireyselDizi;
        int bireyselMusteriNo = 1;
        public int ticariMusteriNo = 1;

        //Ticari Müşteri Kuyruğuna Ekleme Yapmaktadır.
        public void TicariMusteriEkle()
        {   
            DateTime time = DateTime.Now;
            ticariKuyruk.Enqueue(ticariMusteriNo + " Nolu Ticari Müşteri, Çağrı Tarihi -->" + time.ToString());
            ticariMusteriNo++;
        }

        //Bireysel Müşteri Kuyruğuna Ekleme Yapmaktadır.
        public void BireyselMusteriEkle()
        {
            DateTime time = DateTime.Now;
            bireyselKuyruk.Enqueue(bireyselMusteriNo + " Nolu Bireysel Müşteri, Çağrı Tarihi -->" + time.ToString());
            bireyselMusteriNo++;
        }

        //Ticari Müşteri Kuyruğunun Kopyasını Diziye Atarak List View Aracımıza Yazdırabiliyoruz. 
        public void TicariMusteriYazdir()
        {
            Queue<string> kopyaTicariKuyruk = new Queue<string>(ticariKuyruk);
            ticariDizi = kopyaTicariKuyruk.ToArray(); ; 
        }

        //Bireysel Müşteri Kuyruğunun Kopyasını Diziye Atarak List View Aracımıza Yazdırabiliyoruz. 
        public void BireyselMusteriYazdir()
        {
            Queue<string> kopyaBireyselKuyruk = new Queue<string>(bireyselKuyruk);
            bireyselDizi = kopyaBireyselKuyruk.ToArray();   
        }

        //Kuyruk Yapısı Kullanılarak Ticari Kuyrukta ki İlk Sırada Ki Müşteri, İlgili Operatöre Atanıyor.
        public string TicariKuyrukCagriAtama()
        {
            string atananCagriTicari;
            atananCagriTicari = ticariKuyruk.Dequeue().ToString();
            return atananCagriTicari;
        }

        //Kuyruk Yapısı Kullanılarak Bireysel Kuyrukta Bulunan İlk Sıradaki Müşteri, İlgili Operatöre Atanıyor.
        public string BireyselKuyrukCagriAtama()
        {
            string atananCagriBireysel;
            atananCagriBireysel = bireyselKuyruk.Dequeue().ToString();
            return atananCagriBireysel;
        }
    }
}
