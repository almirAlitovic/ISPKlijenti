using ISPKlijenti_API.Models;
using ISPKlijenti_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPKlijenti_UI
{
    public partial class LoginForm : Form
    {
        WebAPIHelper zaposleniciService = new WebAPIHelper("http://localhost:8960/", "api/Zaposlenici");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = zaposleniciService.getActionResponse("GetZaposlenikByUsername", txtKorisnickoIme.Text);
            if (response.IsSuccessStatusCode)
            {
                Zaposlenici zaposlenik = response.Content.ReadAsAsync<Zaposlenici>().Result;

                if (UIHelper.GenerateHash(txtLozinka.Text, zaposlenik.LozinkaSalt) == zaposlenik.LozinkaHash)
                {               
                    if (zaposlenik.Aktivan == false)
                    {
                        lblPoruka.Text = "Neaktivano korisničko ime.";
                        lblPoruka.Visible = true;
                        txtKorisnickoIme.Text = "";
                        txtLozinka.Text = "";
                    }
                    else
                    {
                        Global.logiraniZaposlenik = zaposlenik;
                        this.DialogResult = DialogResult.OK;
                        lblPoruka.Visible = false;
                        this.Close();
                    }
                }
                else
                {
                    lblPoruka.Text = "Neispravno korisničko ime ili lozinka.";
                    lblPoruka.Visible = true;
                    txtKorisnickoIme.Text = "";
                    txtLozinka.Text = "";
                }
            }
        }
    }
}
