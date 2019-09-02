using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailprofilerTestApp
{
    public partial class InsertForm : Form
    {
        Singleton logic;
        OleDbConnection connection;
        public InsertForm()
        {
            InitializeComponent();
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\TestDatabase.accdb");

            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Maximum = 10000000000;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            logic = Singleton.Instance;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ValidateData() == true)
            {
                DialogResult confirmResult = MessageBox.Show("Chcete vytvořit výrobek s těmito parametry?",
                                    "Potvrzení vytvoření",
                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    logic.InsertIntoDatabaze(nameTextBox.Text, descriptionTextBox.Text,
                noteTextBox.Text, numericUpDown1.Value);
                    this.Close();
                }
                
                
            }
        }

        private bool ValidateData()
        {
            if(String.IsNullOrEmpty(nameTextBox.Text) == true)
            {
                label7.BackColor = Color.Red;
                label7.Text = "Pole nesmí být prázdné";
                return false;
            }
            if (String.IsNullOrEmpty(descriptionTextBox.Text) == true)
            {
                label8.BackColor = Color.Red;
                label8.Text = "Pole nesmí být prázdné";
                return false;
            }
            if(String.IsNullOrEmpty(noteTextBox.Text) == true)
            {
                label9.BackColor = Color.Red;
                label9.Text = "Pole nesmí být prázdné";
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
