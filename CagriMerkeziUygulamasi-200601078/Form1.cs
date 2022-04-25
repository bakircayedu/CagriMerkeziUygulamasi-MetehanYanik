namespace CagriMerkeziUygulamasi_200601078
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //    Metehan Yanýk -- 200601078 -- Ýzmir Bakýrçay Üniversitesi Bilgisayar Mühendisliði
        //    Metehan Yanýk -- 200601078 -- Ýzmir Bakýrçay Üniversitesi Bilgisayar Mühendisliði
        //    Metehan Yanýk -- 200601078 -- Ýzmir Bakýrçay Üniversitesi Bilgisayar Mühendisliði
        MusteriKuyrugu musteriKuyrugu = new MusteriKuyrugu();

        int i;
        int k;
        int x;
        string atananCagri1;
        string atananCagri2;

        //Girilen Müþteri Türüne Göre Yönlendirmeler ve Atamalar Gerçekleþtirildi.
        private void araBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(musteriTuruTxt.Text) == 1)
            {
                musteriKuyrugu.TicariMusteriEkle();
                musteriKuyrugu.TicariMusteriYazdir();
                ListViewItem item = new ListViewItem(musteriKuyrugu.ticariDizi[i]);
                ticariMusteriLw.Items.Add(item);
                i++;

            }
            else if (Convert.ToInt32(musteriTuruTxt.Text) == 2)
            {
                musteriKuyrugu.BireyselMusteriEkle();
                musteriKuyrugu.BireyselMusteriYazdir();
                ListViewItem item = new ListViewItem(musteriKuyrugu.bireyselDizi[k]);
                bireyselMusteriLw.Items.Add(item);
                k++;
            }
            else
            {
                MessageBox.Show("GEÇERLÝ BÝR DEÐER GÝRÝNÝZ!!!");
            }
        }

        //Bu Kýsýmda Müþteri Temsilcilerine Gerekli Ýþlemler Atandý
        private void birinciTicariTemsilci_Click(object sender, EventArgs e)
        {
            if (ticariMusteriBilgisi1.Text == "-")
            {
                ticariMusteriBilgisi1.Text = musteriKuyrugu.TicariKuyrukCagriAtama();
                ticariMusteriLw.Items.Remove(ticariMusteriLw.Items[0]);
            }
            else if (ticariMusteriBilgisi1.Text == "Operatör Müsait Durumdadýr")
            {
                ticariMusteriBilgisi1.Text = musteriKuyrugu.TicariKuyrukCagriAtama();
                ticariMusteriLw.Items.Remove(ticariMusteriLw.Items[0]);
            }
            else
            {
                MessageBox.Show("Aktif Çaðrý Bulunmakta!");
            }

        }

        private void ikinciTicariTemsilci_Click(object sender, EventArgs e)
        {
            if (ticariMusteriBilgisi2.Text == "-")
            {
                ticariMusteriBilgisi2.Text = musteriKuyrugu.TicariKuyrukCagriAtama();
                ticariMusteriLw.Items.Remove(ticariMusteriLw.Items[0]);
            }
            else if (ticariMusteriBilgisi2.Text == "Operatör Müsait Durumdadýr")
            {
                ticariMusteriBilgisi2.Text = musteriKuyrugu.TicariKuyrukCagriAtama();
                ticariMusteriLw.Items.Remove(ticariMusteriLw.Items[0]);
            }
            else
            {
                MessageBox.Show("Aktif Çaðrý Bulunmakta!");
            }
        }

       
        private void birinciBireyselTemsilci_Click(object sender, EventArgs e)
        {
            if (bireyselMusteriBilgisi1.Text == "-")
            {
                bireyselMusteriBilgisi1.Text = musteriKuyrugu.BireyselKuyrukCagriAtama();
                bireyselMusteriLw.Items.Remove(bireyselMusteriLw.Items[0]);
            }
            else if (bireyselMusteriBilgisi1.Text == "Operatör Müsait Durumdadýr")
            {
                bireyselMusteriBilgisi1.Text = musteriKuyrugu.BireyselKuyrukCagriAtama();
                bireyselMusteriLw.Items.Remove(bireyselMusteriLw.Items[0]);
            }
            else
            {
                MessageBox.Show("Aktif Çaðrý Bulunmakta!");
            }
           
        }

        private void ikinciBireyselTemsilci_Click(object sender, EventArgs e)
        {
            if (bireyselMusteriBilgisi2.Text == "-")
            {
                bireyselMusteriBilgisi2.Text = musteriKuyrugu.BireyselKuyrukCagriAtama();
                bireyselMusteriLw.Items.Remove(bireyselMusteriLw.Items[0]);
            }
            else if (bireyselMusteriBilgisi2.Text == "Operatör Müsait Durumdadýr")
            {
                bireyselMusteriBilgisi2.Text = musteriKuyrugu.BireyselKuyrukCagriAtama();
                bireyselMusteriLw.Items.Remove(bireyselMusteriLw.Items[0]);
            }
            else
            {
                MessageBox.Show("Aktif Çaðrý Bulunmakta!");
            }
        }

        private void ticariMusteriLw_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Burayý Yanlýþlýkla Açtým, Sildiðimde Design Kýsmý Hata Veriyordu, Böyle Býrakmam Gerekti....
        }

     
        //Bu Kýsýmda Çaðrý Sonlandýrýldýktan Sonra Gerekli Ýþlemlerin Yapýlmasý Saðlandý
        private void cagriSonlandirBtn_Click(object sender, EventArgs e)
        {
            ListViewItem sonlananCagri = new ListViewItem("Ticari Müþteri " + ticariMusteriBilgisi1.Text + "\n" + " NOT: " + ticariMusteriNotu.Text);
            sonlananCagrilarLw.Items.Add(sonlananCagri);
            ticariMusteriBilgisi1.Text = "Operatör Müsait Durumdadýr";
            ticariMusteriNotu.Clear();
        }

        private void cagriSonlandirBtn2_Click(object sender, EventArgs e)
        {
            ListViewItem sonlananCagri = new ListViewItem("Ticari Müþteri " + ticariMusteriBilgisi2.Text + "\n" + " NOT: "  + ticariMusteriNotu.Text);
            sonlananCagrilarLw.Items.Add(sonlananCagri);
            ticariMusteriBilgisi2.Text = "Operatör Müsait Durumdadýr";
            ticariMusteriNotu.Clear();
        }

        private void cagliSonlandirBireyselBtn1_Click(object sender, EventArgs e)
        {
            ListViewItem sonlananCagri = new ListViewItem("Bireysel Müþteri " + bireyselMusteriBilgisi1.Text + "\n" + " NOT: " + bireyselMusteriNotu.Text);
            sonlananCagrilarLw.Items.Add(sonlananCagri);
            bireyselMusteriBilgisi1.Text = "Operatör Müsait Durumdadýr";
            bireyselMusteriNotu.Clear();
        }

        private void cagriSonlandirBireyselBtn2_Click(object sender, EventArgs e)
        {
            ListViewItem sonlananCagri = new ListViewItem("Bireysel Müþteri " + bireyselMusteriBilgisi2.Text + "\n" + " NOT: " +  bireyselMusteriNotu.Text);
            sonlananCagrilarLw.Items.Add(sonlananCagri);
            bireyselMusteriBilgisi2.Text = "Operatör Müsait Durumdadýr";
            bireyselMusteriNotu.Clear();
        }
    }
}