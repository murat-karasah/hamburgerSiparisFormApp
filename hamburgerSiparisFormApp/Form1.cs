using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hamburgerSiparisFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] fiyat = { 20, 24, 18 };
        double sipariFiyatBiriktir = 0;
        StringBuilder siparisnotlarim = new StringBuilder();
        double ekstra, toplamHesap;

        private void btn_siparis_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            siparisnotlarim.Clear();
            sipariFiyatBiriktir = 0;
            ekstra = 0;
            if (comboBox1.SelectedIndex!=-1)
            {
                sipariFiyatBiriktir = fiyat[comboBox1.SelectedIndex];
                siparisnotlarim.Append(comboBox1.SelectedItem.ToString());
                if (rdb_orta.Checked)
                {
                    siparisnotlarim.Append(" Orta Menü");
                }
                else if (rdb_buyuk.Checked)
                {
                    sipariFiyatBiriktir += 2;
                    siparisnotlarim.Append(" Büyük Menü (Farkı +2Tl) ");
                }
                else if (rdb_king.Checked)
                {
                    sipariFiyatBiriktir += 4;
                    siparisnotlarim.Append(" King Menü (Farkı +4Tl) ");
                }

                //Ekstralar groupbox kontrolünde içinde dönerek kontrol ediliyor.
                siparisnotlarim.Append(" Ekstralar ");

                foreach (Control checkekstra in groupBox1.Controls)
                {
                    if (checkekstra is CheckBox && (checkekstra as CheckBox).Checked)
                    {

                        siparisnotlarim.Append(" "+(checkekstra as CheckBox).Text+" ");
                        
                        ekstra += 0.50;
                    }
                }

                if (ekstra>0)
                {
                    siparisnotlarim.Append(" Ekstralar Tutar:  ");
                    siparisnotlarim.Append(ekstra.ToString("C2"));
                    sipariFiyatBiriktir += ekstra;

                }
                int adet = Convert.ToInt32(numericUpDown1.Value);
                sipariFiyatBiriktir *= adet;

                siparisnotlarim.Append("  "  + adet.ToString());
                siparisnotlarim.Append(" Adet :  ");
                siparisnotlarim.Append(" Toplam :  ");
                listBox1.Items.Add(siparisnotlarim.ToString()+sipariFiyatBiriktir.ToString("C2"));
                toplamHesap += sipariFiyatBiriktir;
            }


            formclear();

           


        }

        private void formclear()
        {
            foreach (Control checkekstra in groupBox1.Controls)
            {
                if (checkekstra is CheckBox && (checkekstra as CheckBox).Checked)
                {
                    (checkekstra as CheckBox).Checked = false;
                }
            }

            rdb_orta.Checked = true;
            rdb_buyuk.Checked = false;
            rdb_king.Checked = false;
            numericUpDown1.Value = 1;
            comboBox1.SelectedIndex = 0;
        }

        private void btn_hesap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + toplamHesap);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdb_orta.Checked = true;
            comboBox1.SelectedIndex = 0;


        }

       
    }
}
