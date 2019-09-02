using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailprofilerTestApp
{
    public partial class Form1 : Form
    {

        Singleton logic;
        public Form1()
        {
            InitializeComponent();
            logic = Singleton.Instance;
            logic.LoadProductsFromDatabaze();
            dataGridView1.DataSource = new BindingSource(logic.Data,null);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'testDatabaseDataSet.Díl'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.dílTableAdapter.Fill(this.testDatabaseDataSet.Díl);
            // TODO: Tento řádek načte data do tabulky 'testDatabaseDataSet.Výrobek'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.výrobekTableAdapter.Fill(this.testDatabaseDataSet.Výrobek);

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            InsertForm itf = new InsertForm();
            itf.ShowDialog();
        }

        private void ToolStripButton7_Click(object sender, EventArgs e)
        {
            //logic.Data.ResetBindings();
            dataGridView1.Refresh();

            
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            EditForm ef = new EditForm();
            ef.ShowDialog();
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            DeleteForm df = new DeleteForm();
            df.ShowDialog();
        }

        private void PřidatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertForm itf = new InsertForm();
            itf.ShowDialog();
        }

        private void UpravitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm ef = new EditForm();
            ef.ShowDialog();
        }

        private void SmazatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteForm df = new DeleteForm();
            df.ShowDialog();
        }

        private void KonecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Opravdu chcete ukončit aplikaci?",
                                    "Potvrzení ukončení",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        
        
            
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Opravdu chcete ukončit aplikaci?", "Potvrzení ukončení", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    e.Cancel = true;
            }
        }

    }

}
