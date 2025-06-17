using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueApp.UserControls.Views
{
    public partial class Configuration : UserControl
    {
        // Inicializar a lista de moedas
        private string[] CURRENCY = new string[]
        {
            "BRL - Real Brasileiro",
            "USD - Dólar Americano",
            "EUR - Euro"
        };
        private static string selectedCurrency = "BRL - Real Brasileiro";
        public static string SelectedCurrencyPrefix
        {
            get
            {
                return selectedCurrency switch
                {
                    "BRL - Real Brasileiro" => "BRL",
                    "USD - Dólar Americano" => "USD",
                    "EUR - Euro" => "EUR",
                    _ => "BRL"
                };
            }
        }

        private static new string CompanyName { get; } = "Ibis Vitória Aeroporto";

        public Configuration()
        {
            InitializeComponent();
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            txtBoxCompanyName.Text = CompanyName;
        }

        private void LoadCombobox()
        {
            cmbBoxCurrency.Items.Clear();
            foreach (string currency in CURRENCY)
            {
                cmbBoxCurrency.Items.Add(currency);
            }
            cmbBoxCurrency.SelectedIndex = 0;
        }

        private void cmbBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxCurrency.SelectedItem is null) return;
            selectedCurrency = cmbBoxCurrency.SelectedItem.ToString()!;
        }
    }
}
