using ISPKlijenti_API.Models;
using ISPKlijenti_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPKlijenti_UI.Clients
{
    public partial class InstaliranaOpremaAddForm : Form
    {
        WebAPIHelper klijentiService = new WebAPIHelper("http://localhost:8960/", "api/Klijenti");
        WebAPIHelper opremaService = new WebAPIHelper("http://localhost:8960/", "api/OpremaMaterijal");
        WebAPIHelper instaliranaOpremaService = new WebAPIHelper("http://localhost:8960/", "api/InstaliranaOprema");


        private InstaliranaOprema instalirano { get; set; }

        public InstaliranaOpremaAddForm()
        {
            InitializeComponent();
        }

        private void InstaliranaOpremaAddForm_Load(object sender, EventArgs e)
        {
            BindKlijenti();
            BindOpremaMaterijal();         
        }

        private void BindKlijenti()
        {
            HttpResponseMessage response = klijentiService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Klijenti> klijenti = response.Content.ReadAsAsync<List<Klijenti>>().Result;
                klijenti.Insert(0, new Klijenti());
                cbxKlijent.DataSource = klijenti;
                cbxKlijent.ValueMember = "Id";
                cbxKlijent.DisplayMember = "Ime";
            }
        }

        private void BindOpremaMaterijal()
        {
            HttpResponseMessage response = opremaService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<OpremaMaterijal> oprema = response.Content.ReadAsAsync<List<OpremaMaterijal>>().Result;
                oprema.Insert(0, new OpremaMaterijal());
                cbxOpremaMaterijal.DataSource = oprema;
                cbxOpremaMaterijal.ValueMember = "Id";
                cbxOpremaMaterijal.DisplayMember = "Naziv";
            }
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            instalirano = new InstaliranaOprema();

            openFileDialog.ShowDialog();
            txtSlika.Text = openFileDialog.FileName;

            Image image = Image.FromFile(txtSlika.Text);

            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            instalirano.Slika = ms.ToArray();

            if (image.Width > 350)
            {
                Image resizedImage = UIHelper.ResizeImage(image, new Size(350, 350));

                Image croppedImage = resizedImage;
                int croppedXPosition = (resizedImage.Width - 270) / 2;
                int croppedYPosition = (resizedImage.Height - 270) / 2;

                if (resizedImage.Width >= 270 && resizedImage.Height >= 270)
                {
                    croppedImage = UIHelper.CropImage(resizedImage, new Rectangle(croppedXPosition, croppedYPosition, 270, 270));
                    pictureBox.Image = croppedImage;
                }

            }
            else
            {
                MessageBox.Show("Slika treba biti najmanje 350x350 px");
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (instalirano == null)
            {
                instalirano = new InstaliranaOprema();
            }

            instalirano.KlijentId = Convert.ToInt32(cbxKlijent.SelectedValue);
            instalirano.OpremaMaterijalId = Convert.ToInt32(cbxOpremaMaterijal.SelectedValue);
            instalirano.Kolicina = (int)numKolicina.Value;

            HttpResponseMessage response = instaliranaOpremaService.PostResponse(instalirano);
        }
    }
}
