namespace CagriMerkeziUygulamasi_200601078
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //    Metehan Yan�k -- 200601078 -- �zmir Bak�r�ay �niversitesi Bilgisayar M�hendisli�i
        //    Metehan Yan�k -- 200601078 -- �zmir Bak�r�ay �niversitesi Bilgisayar M�hendisli�i
        //    Metehan Yan�k -- 200601078 -- �zmir Bak�r�ay �niversitesi Bilgisayar M�hendisli�i
        MusteriKuyrugu musteriKuyrugu = new MusteriKuyrugu();

        int i;
        int k;
        int x;
        string atananCagri1;
        string atananCagri2;

        //Girilen M��teri T�r�ne G�re Y�nlendirmeler ve Atamalar Ger�ekle�tirildi.
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
                MessageBox.Show("GE�ERL� B�R DE�ER G�R�N�Z!!!");
            }
        }

        //Bu K�s�mda M��teri Temsilcilerine Gerekli ��lemler Atand�
        private void birinciTicariTemsilci_Click(object sender, EventArgs e)
        {
            if (ticariMusteriBilgisi1.Text == "-")
            {
                ticariMusteriBilgisi1.Text = musteriKuyrugu.TicariKuyrukCagriAtama();
                ticariMusteriLw.Items.Remove(ticariMusteriLw.Items[0]);
            }
            else if (ticariMusteriBilgisi1.Text == "Operat�r M�sait Durumdad�r")
            {
                ticariMusteriBilgisi1.Text = musteriKuyrugu.TicariKuyrukCagriAtama();
                ticariMusteriLw.Items.Remove(ticariMusteriLw.Items[0]);
            }
            else
            {
                MessageBox.Show("Aktif �a�r� Bulunmakta!");
            }

        }

        private void ikinciTicariTemsilci_Click(object sender, EventArgs e)
        {
            if (ticariMusteriBilgisi2.Text == "-")
            {
                ticariMusteriBilgisi2.Text = musteriKuyrugu.TicariKuyrukCagriAtama();
                ticariMusteriLw.Items.Remove(ticariMusteriLw.Items[0]);
            }
            else if (ticariMusteriBilgisi2.Text == "Operat�r M�sait Durumdad�r")
            {
                ticariMusteriBilgisi2.Text = musteriKuyrugu.TicariKuyrukCagriAtama();
                ticariMusteriLw.Items.Remove(ticariMusteriLw.Items[0]);
            }
            else
            {
                MessageBox.Show("Aktif �a�r� Bulunmakta!");
            }
        }

       
        private void birinciBireyselTemsilci_Click(object sender, EventArgs e)
        {
            if (bireyselMusteriBilgisi1.Text == "-")
            {
                bireyselMusteriBilgisi1.Text = musteriKuyrugu.BireyselKuyrukCagriAtama();
                bireyselMusteriLw.Items.Remove(bireyselMusteriLw.Items[0]);
            }
            else if (bireyselMusteriBilgisi1.Text == "Operat�r M�sait Durumdad�r")
            {
                bireyselMusteriBilgisi1.Text = musteriKuyrugu.BireyselKuyrukCagriAtama();
                bireyselMusteriLw.Items.Remove(bireyselMusteriLw.Items[0]);
            }
            else
            {
                MessageBox.Show("Aktif �a�r� Bulunmakta!");
            }
           
        }

        private void ikinciBireyselTemsilci_Click(object sender, EventArgs e)
        {
            if (bireyselMusteriBilgisi2.Text == "-")
            {
                bireyselMusteriBilgisi2.Text = musteriKuyrugu.BireyselKuyrukCagriAtama();
                bireyselMusteriLw.Items.Remove(bireyselMusteriLw.Items[0]);
            }
            else if (bireyselMusteriBilgisi2.Text == "Operat�r M�sait Durumdad�r")
            {
                bireyselMusteriBilgisi2.Text = musteriKuyrugu.BireyselKuyrukCagriAtama();
                bireyselMusteriLw.Items.Remove(bireyselMusteriLw.Items[0]);
            }
            else
            {
                MessageBox.Show("Aktif �a�r� Bulunmakta!");
            }
        }

        private void ticariMusteriLw_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Buray� Yanl��l�kla A�t�m, Sildi�imde Design K�sm� Hata Veriyordu, B�yle B�rakmam Gerekti....
        }

     
        //Bu K�s�mda �a�r� Sonland�r�ld�ktan Sonra Gerekli ��lemlerin Yap�lmas� Sa�land�
        private void cagriSonlandirBtn_Click(object sender, EventArgs e)
        {
            ListViewItem sonlananCagri = new ListViewItem("Ticari M��teri " + ticariMusteriBilgisi1.Text + "\n" + " NOT: " + ticariMusteriNotu.Text);
            sonlananCagrilarLw.Items.Add(sonlananCagri);
            ticariMusteriBilgisi1.Text = "Operat�r M�sait Durumdad�r";
            ticariMusteriNotu.Clear();
        }

        private void cagriSonlandirBtn2_Click(object sender, EventArgs e)
        {
            ListViewItem sonlananCagri = new ListViewItem("Ticari M��teri " + ticariMusteriBilgisi2.Text + "\n" + " NOT: "  + ticariMusteriNotu.Text);
            sonlananCagrilarLw.Items.Add(sonlananCagri);
            ticariMusteriBilgisi2.Text = "Operat�r M�sait Durumdad�r";
            ticariMusteriNotu.Clear();
        }

        private void cagliSonlandirBireyselBtn1_Click(object sender, EventArgs e)
        {
            ListViewItem sonlananCagri = new ListViewItem("Bireysel M��teri " + bireyselMusteriBilgisi1.Text + "\n" + " NOT: " + bireyselMusteriNotu.Text);
            sonlananCagrilarLw.Items.Add(sonlananCagri);
            bireyselMusteriBilgisi1.Text = "Operat�r M�sait Durumdad�r";
            bireyselMusteriNotu.Clear();
        }

        private void cagriSonlandirBireyselBtn2_Click(object sender, EventArgs e)
        {
            ListViewItem sonlananCagri = new ListViewItem("Bireysel M��teri " + bireyselMusteriBilgisi2.Text + "\n" + " NOT: " +  bireyselMusteriNotu.Text);
            sonlananCagrilarLw.Items.Add(sonlananCagri);
            bireyselMusteriBilgisi2.Text = "Operat�r M�sait Durumdad�r";
            bireyselMusteriNotu.Clear();
        }
    }
}