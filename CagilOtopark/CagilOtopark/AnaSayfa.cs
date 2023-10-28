using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CagilOtopark
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void abonelikTipleriniListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void varsayılanFiyatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboneEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboneleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void otoparkGirişKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void otoparkÇıkışKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void rapor1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void rapor2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void rapor3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGirisKaydi_Click(object sender, EventArgs e)
        {
            Ekranlar.OtoparkGiris.OtoparkGirisFrm otoparkGiris = new Ekranlar.OtoparkGiris.OtoparkGirisFrm();
            otoparkGiris.StartPosition = FormStartPosition.CenterScreen;
            otoparkGiris.ShowDialog();
        }

        private void btnCikisKaydi_Click(object sender, EventArgs e)
        {
            Ekranlar.OtoparkCikis.OtoparkCikisFrm otoparkCikis = new Ekranlar.OtoparkCikis.OtoparkCikisFrm();
            otoparkCikis.StartPosition = FormStartPosition.CenterScreen;
            otoparkCikis.ShowDialog();
        }

        private void btnAboneEkle_Click(object sender, EventArgs e)
        {
            Ekranlar.Aboneler.AboneEkleFrm aboneEkle = new Ekranlar.Aboneler.AboneEkleFrm();
            aboneEkle.StartPosition = FormStartPosition.CenterScreen;
            aboneEkle.ShowDialog();
        }

        private void btnAboneleriListele_Click(object sender, EventArgs e)
        {
            Ekranlar.Aboneler.AboneListesiFrm aboneListesi = new Ekranlar.Aboneler.AboneListesiFrm();
            aboneListesi.StartPosition = FormStartPosition.CenterScreen;
            aboneListesi.ShowDialog();
        }

        private void btnAboneTipiEkle_Click(object sender, EventArgs e)
        {
            Ekranlar.Abonelik.AboneTipiEkleFrm aboneTipiEkle = new Ekranlar.Abonelik.AboneTipiEkleFrm();
            aboneTipiEkle.StartPosition = FormStartPosition.CenterScreen;
            aboneTipiEkle.ShowDialog();
        }

        private void btnAboneTipleriniListele_Click(object sender, EventArgs e)
        {
            Ekranlar.Abonelik.AboneTipleriFrm aboneList = new Ekranlar.Abonelik.AboneTipleriFrm();
            aboneList.StartPosition = FormStartPosition.CenterScreen;
            aboneList.ShowDialog();
        }

        private void btnKapasiteFiyat_Click(object sender, EventArgs e)
        {
            Ekranlar.FiyatVeKapasite.FiyatVeKapasiteFrm fiyatVeKapasite = new Ekranlar.FiyatVeKapasite.FiyatVeKapasiteFrm();
            fiyatVeKapasite.StartPosition = FormStartPosition.CenterScreen;
            fiyatVeKapasite.ShowDialog();
        }

        private void btnRapor1_Click(object sender, EventArgs e)
        {
            Ekranlar.Raporlar.Rapor_1Frm rapor1 = new Ekranlar.Raporlar.Rapor_1Frm();
            rapor1.StartPosition = FormStartPosition.CenterScreen;
            rapor1.ShowDialog();
        }

        private void btnRapor2_Click(object sender, EventArgs e)
        {
            Ekranlar.Raporlar.Rapor_2Frm rapor2 = new Ekranlar.Raporlar.Rapor_2Frm();
            rapor2.StartPosition = FormStartPosition.CenterScreen;
            rapor2.ShowDialog();
        }

        private void btnRapor3_Click(object sender, EventArgs e)
        {
            Ekranlar.Raporlar.Rapor_3Frm rapor3 = new Ekranlar.Raporlar.Rapor_3Frm();
            rapor3.StartPosition = FormStartPosition.CenterScreen;
            rapor3.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
