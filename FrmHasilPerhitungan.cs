using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class FrmHasilPerhitungan : Form
    {
        private IList<Calculator> listOfCalculator = new List<Calculator>();

        public FrmHasilPerhitungan()
        {
            InitializeComponent();
            InisialisasiListView();
        }
        private void InisialisasiListView()
        {
            lvwHasil.View = View.Details;
            lvwHasil.FullRowSelect = true;
            lvwHasil.Columns.Add("", 750, HorizontalAlignment.Left);
        }
        private void FrmInput_OnProses(Calculator calc)
        {
            listOfCalculator.Add(calc);

            ListViewItem item = new ListViewItem();
            lvwHasil.Items.Add(calc.teks);
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            FrmInputNilai frmInput = new FrmInputNilai();
            frmInput.OnProses += FrmInput_OnProses;

            frmInput.ShowDialog();
        }
    }
}
