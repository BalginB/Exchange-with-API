using KomponentovaTvorba;
using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using CurrencyConverter = KomponentovaTvorba.CurrencyConverter;

namespace KomponentovaTvorba
{
    public partial class Form1 : Form
    {
        CurrencyConverter currencyConverter;

        public Form1()
        {
            InitializeComponent();
            currencyConverter = new CurrencyConverter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> symbolData = currencyConverter.GetSymbols();
            // Nastavení dat pro comboBoxy pro výběr měn

            cmbFromCurrency.Items.Clear();
            cmbToCurrency.Items.Clear();


            cmbFromCurrency.DataSource = new BindingSource(symbolData, null);
            cmbFromCurrency.DisplayMember = "Value";
            cmbFromCurrency.ValueMember = "Key";


            cmbToCurrency.DataSource = new BindingSource(symbolData, null);
            cmbToCurrency.DisplayMember = "Value";
            cmbToCurrency.ValueMember = "Key";

            timer.Start(); // Spuštění časovače

        }

        private void btnConvert_Click_1(object sender, EventArgs e)
        {
            if (txtFromCurrencyAmount.Text != "")
            {
                // Získání vybraných měn a částky pro převod
                string fromCurrency = ((KeyValuePair<string, string>)cmbFromCurrency.SelectedItem).Key;
                string toCurrency = ((KeyValuePair<string, string>)cmbToCurrency.SelectedItem).Key;
                double currencyAmount = double.Parse(txtFromCurrencyAmount.Text);

                // Provedení konverze a zobrazení výsledné částky
                double finalValue = currencyConverter.Convert(fromCurrency, toCurrency, currencyAmount);
                txtToCurrencyAmount.Text = finalValue.ToString();
              
            }


        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Aktualizace zobrazení aktuálního času a data
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            // Zavření aplikace po kliknutí na tlačítko X, což znamená Exit
            this.Close();
        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.Red;
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.White;

        }

        Point lastPoint;

        private void bckgImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void bckgImage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);    
        }
    }
}
