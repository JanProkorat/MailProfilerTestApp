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
    public partial class EditForm : Form
    {
        Singleton logic;
        public EditForm()
        {
            InitializeComponent();
            logic = Singleton.Instance;
            foreach(Vyrobek v in logic.Data)
            {
                comboBox1.Items.Add(v.ID +": "+ v.Nazev);
            }
            numericUpDown1.Maximum = 100000000000;
            numericUpDown1.DecimalPlaces = 2;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'testDatabaseDataSet.Výrobek'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.výrobekTableAdapter.Fill(this.testDatabaseDataSet.Výrobek);

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchID = comboBox1.SelectedItem.ToString().Split(' ')[0].Substring(0, comboBox1.SelectedItem.ToString().Split(' ')[0].Length-1);
            Vyrobek tmp = logic.Data.SingleOrDefault(v => v.ID == searchID);
            descriptionTextBox.Text = tmp.Popis;
            nameTextBox.Text = tmp.Nazev;
            IdTextBox.Text = tmp.ID;
            IdTextBox.ReadOnly = true;
            noteTextBox.Text = tmp.Poznamka;
            numericUpDown1.Value = decimal.Parse(tmp.Cena);
            createdTextBox.Text = tmp.Zalozeno;
            createdTextBox.ReadOnly = true;
            lastUpdatedTextBox.Text = tmp.Upraveno;
            lastUpdatedTextBox.ReadOnly = true;
            numOfPartsTextBox.Text = tmp.PocetDilu;
            numOfPartsTextBox.ReadOnly = true;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(ValidateData() == true)
            {
                DialogResult confirmResult = MessageBox.Show("Opravdu chcete upravit vybraný záznam?",
                                     "Potvrzení upravení",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    logic.UpdateProductsData(IdTextBox.Text, nameTextBox.Text, descriptionTextBox.Text,
                noteTextBox.Text, numericUpDown1.Value);
                    this.Close();
                }
                
            }
            
        }

        private bool ValidateData()
        {
            if (comboBox1.SelectedItem == null)
            {
                label11.Text = "Nevybrali jste výrobek k úpravě";
                return false;
            }
            if(string.IsNullOrEmpty(nameTextBox.Text) == true)
            {
                label10.Text = "Jméno nesmí být prázdné";
                return false;
            }
            if (string.IsNullOrEmpty(descriptionTextBox.Text) == true)
            {
                label12.Text = "Popis nesmí být prázdný";
                return false;
            }
            if (string.IsNullOrEmpty(noteTextBox.Text) == true)
            {
                label13.Text = "Poznámka nesmí být prázdná";
                return false;
            }
            return true;
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Text = numericUpDown1.Text.Replace(',', '.');
        }
    }
}
