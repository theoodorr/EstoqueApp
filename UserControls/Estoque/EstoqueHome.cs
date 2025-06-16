using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueApp.UserControls.Estoque
{
    public partial class EstoqueHome : UserControl
    {
        public Action NewEntryClicked;
        public EstoqueHome()
        {
            InitializeComponent();
            btnNewEntry.Click += (sender, e) => { NewEntryClicked?.Invoke(); };
            
        }
    }
}
