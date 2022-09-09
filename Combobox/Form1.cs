using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> ldict = new Dictionary<string, string>();
            ldict.Add("God Of War Ragnarok", "9 Noviembre 2022");
            ldict.Add("Gran Turismo 7", " 4 Marzo 2022");
            ldict.Add("Horizon Fofbidden West", "18 Febrero 2022");
            ldict.Add("Elden Ring", " 25 Febrero 2022");
            ldict.Add("Gotham Knights", "21 Octubre 2022");
            ldict.Add("Scorn", "21 Octubre 2022");
            lookUpEdit1.Properties.DataSource = ldict.ToList();
            lookUpEdit1.Properties.ValueMember = "Value";
            lookUpEdit1.Properties.DisplayMember = "Key";
      

            //seleccionamos la monedas
            var Moneda = new[]
            {
            new{moneda="Cordoba"},
            new{moneda="Dolar"},
            new{moneda="Euro" }
            };
            lookUpEdit2.Properties.DataSource = Moneda;
            lookUpEdit2.Properties.DisplayMember = "moneda";


            this.lookUpEdit3.Properties.DataSource = LlenarCombobox.GetPais();
            this.lookUpEdit3.Properties.DisplayMember = "Descripcion";
            this.lookUpEdit3.Properties.ValueMember = "ID";
        }
    }
}
