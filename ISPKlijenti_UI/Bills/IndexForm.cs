using ISPKlijenti_API.Models;
using ISPKlijenti_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Net;
using System.Net.Mime;

namespace ISPKlijenti_UI.Bills
{
    public partial class IndexForm : Form
    {
        WebAPIHelper racuniService = new WebAPIHelper("http://localhost:8960/", "api/Racuni");
        WebAPIHelper uplateService = new WebAPIHelper("http://localhost:8960/", "api/Uplate");


        public IndexForm()
        {
            InitializeComponent();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            LoadRacuni();
        }

        private void LoadRacuni()
        {
            HttpResponseMessage response = racuniService.getActionResponse("GetRacunByKlijent", txtKlijent.Text);
            if (response.IsSuccessStatusCode)
            {
                dgvRacuni.AutoGenerateColumns = false;
                dgvRacuni.DataSource = response.Content.ReadAsAsync<List<isp_Racuni_SelectByKlijent_Result>>().Result;
            }
        }

        private void txtKlijent_TextChanged(object sender, EventArgs e)
        {
            LoadRacuni();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            CreateForm f = new CreateForm();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void IndexForm_Activated(object sender, EventArgs e)
        {
            LoadRacuni();
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {


            isp_Racuni_SelectById_Result racun = new isp_Racuni_SelectById_Result();
            HttpResponseMessage response = racuniService.getActionResponse("GetRacunById", dgvRacuni.SelectedRows[0].Cells[0].Value.ToString());
            if (response.IsSuccessStatusCode)
            {
                racun = response.Content.ReadAsAsync<isp_Racuni_SelectById_Result>().Result;
            }

            MailAddress posiljalac = new MailAddress("impactdoo.noreply@gmail.com", "Impact d.o.o");
            if (racun.Email != null)
            {
                MailAddress primalac = new MailAddress("almir.alitovic@edu.fit.ba"); //treba da stoji racun.Email - fiksirano radi testiranja
                MailMessage msg = new MailMessage(posiljalac, primalac);
                msg.Subject = "Račun za mjesec " + racun.Mjesec;
                msg.Body = "Poštovani " + racun.Klijent + ", \n\n\nVaš račun za mjesec " + racun.Mjesec +
                    " iznosi: " + racun.IznosSaPDV + " KM \n(PDV je uključen u cijenu)";
                SendMail(msg);
            }
            else
            {
                MessageBox.Show("Selektovani klijent nema e-mail adresu.");
            }
        
            //string file = @"C:\Users\Almir\source\repos\ISPKlijenti\ISPKlijenti_UI\Files\CV_Melisa_Vrabac.pdf";
            //// Create the file attachment for this e-mail message.
            //Attachment data = new Attachment(file);
            //// Add time stamp information for the file.
            //ContentDisposition disposition = data.ContentDisposition;
            //disposition.CreationDate = System.IO.File.GetCreationTime(file);
            //disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
            //disposition.ReadDate = System.IO.File.GetLastAccessTime(file);
            //// Add the file attachment to this e-mail message.
            //msg.Attachments.Add(data);
        }

        public static void SendMail(MailMessage Message)
        {
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.googlemail.com";
            client.Port = 587;
            client.UseDefaultCredentials = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("impactdoo.noreply@gmail.com", "imp123#$");
            client.Send(Message);
        }

        private void btnStampaj_Click(object sender, EventArgs e)
        {
            isp_Racuni_SelectById_Result racun = new isp_Racuni_SelectById_Result();
            HttpResponseMessage response = racuniService.getActionResponse("GetRacunById", dgvRacuni.SelectedRows[0].Cells[0].Value.ToString());
            if (response.IsSuccessStatusCode)
            {
                racun = response.Content.ReadAsAsync<isp_Racuni_SelectById_Result>().Result;

                Reports.rptRacun_Form frm = new Reports.rptRacun_Form(racun);
                frm.Show();
            }
        }

        private void btnPromjeniStatus_Click(object sender, EventArgs e)
        {
            Racuni racun = new Racuni();
            HttpResponseMessage response = racuniService.GetResponse(dgvRacuni.SelectedRows[0].Cells[0].Value.ToString());
            if (response.IsSuccessStatusCode)
            {
                racun = response.Content.ReadAsAsync<Racuni>().Result;
                if (racun.Placeno == false)
                {
                    racun.Placeno = true;
                    HttpResponseMessage putResponse = racuniService.PutResponse(racun.Id, racun);
                    LoadRacuni();

                    Uplate uplata = new Uplate();
                    uplata.KlijentId = racun.KlijentId;
                    uplata.UslugaId = racun.UslugaId;
                    uplata.Iznos = racun.IznosSaPDV;
                    HttpResponseMessage postResponse = uplateService.PostResponse(uplata);
                }

                
            }
        }
    }
}
