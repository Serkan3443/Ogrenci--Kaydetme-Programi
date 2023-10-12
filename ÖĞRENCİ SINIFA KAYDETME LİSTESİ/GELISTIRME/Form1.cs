using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GELISTIRME
{
    public partial class FormSinifListesi : Form
    {
        public FormSinifListesi()
        {
            InitializeComponent();
        }
        private int SiniflarID;//Global değişken heryerde gözüken değişkendir
        private void FormSinifListesi_Load(object sender, EventArgs e)
        {
            OkulSabahDBEntities db = new OkulSabahDBEntities();

            SiniflarListesi();//PART2

            //*****************************
            //Bölümler
            comboBoxBolumu.ValueMember = "BolumlerID";
            comboBoxBolumu.DisplayMember = "BolumAdi";
            comboBoxBolumu.DataSource = db.Bolumler.ToList();
            comboBoxBolumu.SelectedIndex = -1;//PART2 

            //************************************
            //Öğretmenler
            comboBoxSinifOgretmeni.ValueMember = "OgretmenlerID";
            comboBoxSinifOgretmeni.DisplayMember = "OgretmenAdi";
            //PART2
            var OgretmenListesi =
                (from o in db.Ogretmenler
                 select new
                 {
                     ogretmenlerID = o.OgretmenlerID,
                     OgretmenAdi = o.OgretmenAdi + " " + o.OgretmenSoyadi
                 }

                ).ToList();
            comboBoxSinifOgretmeni.DataSource = OgretmenListesi;//PART2SON
            comboBoxSinifOgretmeni.SelectedIndex = -1;//PART2 

        }

        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            //PART2
            if(string.IsNullOrWhiteSpace(textBoxSinifNo.Text) || string.IsNullOrWhiteSpace(textBoxSinifSubesi.Text))
            {
                MessageBox.Show("Sınıf no ve şubesi dolu olmak zorunda");
                return;
            }
            //Part2SON

            //PART2
            if(comboBoxBolumu.SelectedIndex==-1 || comboBoxSinifOgretmeni.SelectedIndex==-1)
            {
                MessageBox.Show("Öğretmen veya bölüm seçimini yapmadınız");
                return;
            }
            //PART2SON

            OkulSabahDBEntities db = new OkulSabahDBEntities();

            //Ling nedir 
            var DataVarmi=db.Siniflar.FirstOrDefault(s=>s.SınıfNo==textBoxSinifNo.Text && s.SınıfSubesi==textBoxSinifSubesi.Text);  
            if (DataVarmi==null)//yani veri eklenmemişse eklesin yani aşağıdaki işlemleri yapsın
            {
                Siniflar siniflar = new Siniflar();

                //tablodaki kolonlara girilen değerleri atıyoruz
                siniflar.SınıfNo = textBoxSinifNo.Text;
                siniflar.SınıfSubesi = textBoxSinifSubesi.Text;
                siniflar.OgretmenID = (int)comboBoxSinifOgretmeni.SelectedValue;
                siniflar.BolumID = (int)comboBoxBolumu.SelectedValue;
                siniflar.AktifMi = radioButtonAktif.Checked ? true : false;

                db.Siniflar.Add(siniflar);//şu yukarıdaki 5 alanı da Siniflar Tablosuna ekler

                int sonuc = db.SaveChanges();// ekledikten sonra SQL`e kayıt işlemi yapar



                if (sonuc > 0)
                {
                    SiniflarListesi();//PART2
                    MessageBox.Show("Sınıf ekleme Başarılı");
                }
                else
                {
                    MessageBox.Show("Sınıf DB`ye eklenirken hata oluştu");
                } 
            }
            else
            {
                MessageBox.Show("Bu sınıf daha önce eklenmiş ");
            }

        }
        //PART2
        private void Temizle()
        {
            textBoxSinifNo.Clear();
            textBoxSinifSubesi.Clear();
            comboBoxBolumu.SelectedIndex = -1;
            comboBoxSinifOgretmeni.SelectedIndex = -1;
            radioButtonAktif.Checked = false;
            radioButtonPasif.Checked = false;
        }
        //PART2SON

        //PART2
        private void toolStripButtonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();//Temizle metodunu Temizle butonunda çağırdım çünkü Temizle butonuna tıkladığımda direkt tasarım alanında yazılan tüm verileri temizleyecektir
        }
        //PART2SON

        //PART2
        private void SiniflarListesi()
        {
            OkulSabahDBEntities db =new OkulSabahDBEntities();

            var siniflarList = (from s in db.Siniflar
                                join b in db.Bolumler on s.BolumID equals b.BolumlerID
                                join og in db.Ogretmenler on s.OgretmenID equals og.OgretmenlerID

                                select new
                                {
                                    SiniflarID = s.SınıflarID,
                                    Sınıfı = s.SınıfNo + "-" + s.SınıfSubesi,
                                    Bolumu = b.BolumAdi,
                                    SınıfOgretmeni = og.OgretmenAdi + " " + og.OgretmenSoyadi,
                                    AktifMi = s.AktifMi
                                }).ToList();
            dataGridViewSiniflar.DataSource = siniflarList;
        }
        //PART2 SON

        //PART2 
        private void dataGridViewSiniflar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SiniflarID = (int)dataGridViewSiniflar.Rows[e.RowIndex].Cells["SiniflarID"].Value;

            string sinif = dataGridViewSiniflar.Rows[e.RowIndex].Cells["Sınıfı"].Value.ToString();

            for (int i = 0; i < sinif.Split('-').Length; i++)
            {
                if (i==0)
                {
                    textBoxSinifNo.Text = sinif.Split('-')[i];
                }
                else if(i==1)
                {
                    textBoxSinifSubesi.Text = sinif.Split('-')[i];
                }
                else
                {
                    textBoxSinifSubesi.Text = textBoxSinifSubesi.Text+ '-' + sinif.Split('-')[i];
                }
            }



            comboBoxSinifOgretmeni.Text = dataGridViewSiniflar.Rows[e.RowIndex].Cells["SınıfOgretmeni"].Value.ToString();
            comboBoxBolumu.Text = dataGridViewSiniflar.Rows[e.RowIndex].Cells["Bolumu"].Value.ToString();
            bool aktifmi = (bool)dataGridViewSiniflar.Rows[e.RowIndex].Cells["AktifMi"].Value;

            if(aktifmi)
            {
                radioButtonAktif.Checked = true;
            }
            else
            {
                radioButtonPasif.Checked = true;
            }

        }
        //PART2SON


        //PART3 GÜNCELLEME İŞLEMİ ALANI
        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            try//Hata gelidiğinde uyarı bize iletsin diye try catch kullanndım
            {
                if(ZorunluAlanlar())
                {
                    return;//zorunlu alanlarda bir tanesi bile boş bırakılırsa true dönecek.Bu da bu alanda bu methodu sonlandıracak

                }

                OkulSabahDBEntities db = new OkulSabahDBEntities();

                var varmiSinif = db.Siniflar.Where(s => s.SınıflarID == SiniflarID).FirstOrDefault();

                if (varmiSinif != null)
                {
                    //girilen değerlere göre aynı data varsa güncelleme yapamasın
                    var Datavarmi = db.Siniflar.Where(s => s.SınıfNo == textBoxSinifNo.Text && s.SınıfSubesi == textBoxSinifSubesi.Text).FirstOrDefault();
                    if(Datavarmi != null)
                    {
                        MessageBox.Show("Aynı sınıf girilmiş, lütfen kontrol ediniz");
                        return;//aynı data varsa method sonlandır
                    }


                    varmiSinif.SınıfNo = textBoxSinifNo.Text;
                    varmiSinif.SınıfSubesi = textBoxSinifSubesi.Text;
                    varmiSinif.OgretmenID = (int)comboBoxSinifOgretmeni.SelectedValue;
                    varmiSinif.BolumID = (int)comboBoxBolumu.SelectedValue;
                    varmiSinif.AktifMi = radioButtonAktif.Checked ? true : false;
                    //kullanıcının kontroller yapılarına girdiği DB`deki sorgumuz ile (varmiSinif) kolonlara eşitliyoruz.
                    //DB işlemleri 
                    int sonuc = db.SaveChanges();

                    if (sonuc > 0)//yani sonuç doğruysa şunu yap:
                    {
                        MessageBox.Show("Güncelleme başarılı");
                        SiniflarListesi();//güncellemeden sonra GridView`e atsın
                        Temizle();//Güncellemeden sonra kontrolleri temizlesin
                        SiniflarID = -1;//son tıklanan ID değerli data hala global değişkende tutulur, glaobal değişkeni ID değeri taşıdığı için -1 olma olasılığı yok o nedenle -1 değeri atıyoruz.
                    }
                    else
                    {
                        MessageBox.Show("DB`ye eklerken bir hata oluştu");
                    }

                }
                else
                {
                    MessageBox.Show("Bir seçim yapmadınız");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme esnasında bir hata oluştu:\nHATA:" + ex);
              
            }
        }
        //PART3 SON

        //PART3
        private bool ZorunluAlanlar()
        {
            if(string.IsNullOrWhiteSpace(textBoxSinifNo.Text) || string.IsNullOrWhiteSpace(textBoxSinifSubesi.Text))
            {
                MessageBox.Show("Sınıf no şubesi dolu olmak zorunda");
                return true;
            }
            if(comboBoxBolumu.SelectedIndex==-1 || comboBoxSinifOgretmeni.SelectedIndex==-1)
            {
                MessageBox.Show("Öğretmen veya bölüm seçimini yapmadınız");
                return true; ;
            }
            return false;
        }
        //PART3 SON

        //PART3 SİLME ALANI
        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            OkulSabahDBEntities db = new OkulSabahDBEntities();

            var sinifiVarmi = db.Siniflar.Where(s => s.SınıflarID == SiniflarID).FirstOrDefault();

            if(sinifiVarmi != null)
            {
                DialogResult SilmeOnay = new DialogResult();//Bu nesne ekrana onay-teyit için yapılmıştır
                SilmeOnay = MessageBox.Show("Devam etmek istiyor musunuz:?", "---UYARI---", MessageBoxButtons.OKCancel);
                if (SilmeOnay==DialogResult.OK)
                {

                    db.Siniflar.Remove(sinifiVarmi);//Silme işlemi Remove ile yapılır

                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Sınıf silindi");
                        SiniflarListesi();
                        SiniflarID = -1;
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi yapılırken bir hata oluştu");
                    }
                }
                else
                {
                    MessageBox.Show("Silme işlemini iptal ettiniz");
                }
            }
            else
            {
                MessageBox.Show("Böyle bir sınıf yok zaten");
            }

        }
        //PART 3 SON 



    }
}
