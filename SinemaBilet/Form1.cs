using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SinemaBilet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        LinkedList list = new LinkedList();

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.AdSoyad = txtAd.Text;
            musteri.AdSoyad += " " + txtSoyad.Text;
            musteri.koltukno = Convert.ToInt32(txtKltNO.Text);
            list.InsertPos(musteri.koltukno, musteri);

            txtAd.Text = " ";
            txtSoyad.Text = " ";
            txtKltNO.Text = " ";

            MessageBox.Show("Kayıt Başarılı!!");
            
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            int k_no = Convert.ToInt32(txtIptal.Text);

            list.DeletePos(k_no);

            txtIptal.Text = " ";

            MessageBox.Show("İptal Edilmiştir");


            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 61; i++)
            {
                list.InsertFirst(null);            
            }


        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string str = "";
            for (int i = 1; i <=60 ; i++)
            {
                Node n = (Node)list.GetElement(i);
                if(n.Data != null)
                {
                    Musteri m = (Musteri)n.Data;
                    str += m.koltukno + " "+ m.AdSoyad + Environment.NewLine;
                    
                }
                
                
            }
            MessageBox.Show(str);
        }







    }
}
