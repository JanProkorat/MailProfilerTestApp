using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailprofilerTestApp
{
    public partial class DeleteForm : Form
    {
        Singleton logic;
        public DeleteForm()
        {
            InitializeComponent();
            logic = Singleton.Instance;
            foreach (Vyrobek v in logic.Data)
            {
                comboBox1.Items.Add(v.ID + ": " + v.Nazev);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(ValidateComboNotEmpty() == true)
            {
                DialogResult confirmResult = MessageBox.Show("Opravdu chcete smazat vybraný záznam?",
                                     "Potvrzení smazání",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    logic.DeleteProductsFromDatabase(comboBox1.SelectedItem.ToString().Split(' ')[0].Substring(0, comboBox1.SelectedItem.ToString().Split(' ')[0].Length - 1));
                    this.Close();
                }
            }
            else
            {
                label2.Text = "Pole nesmí být prázdné";
            }
            
        }

        private bool ValidateComboNotEmpty()
        {
            if (comboBox1.SelectedItem == null)
            {
                return false;
            }
            return true;
        }
    }
}
