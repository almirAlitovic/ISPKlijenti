using ISPKlijenti_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace ISPKlijenti_UI
{
    public class Global
    {
        public static Zaposlenici logiraniZaposlenik { get; set; }

        public static string GetMessage(string key)
        {
            ResourceManager rm = new ResourceManager("ISPKlijenti_UI.Messages", Assembly.GetExecutingAssembly());
            return rm.GetString(key);
        }

        public static decimal DecimalFromMaskedText(string text)
        {
            string txtValue = text;
            txtValue = txtValue.Replace(" ", "");

            int index = txtValue.IndexOf("KM");
            while (index >= 0)
            {
                txtValue = txtValue.Remove(index, 2);
                index = txtValue.IndexOf("KM");
            }

            index = txtValue.IndexOf("GB");
            while (index >= 0)
            {
                txtValue = txtValue.Remove(index, 2);
                index = txtValue.IndexOf("GB");
            }

            try
            {
                decimal val = Convert.ToDecimal(txtValue);
                return val;
            }
            catch (Exception ex)
            {
                throw (new Exception("Neuspjela konverzija iz teksta u decimal"));
            }
            finally
            {
            }
        }
    }
}
