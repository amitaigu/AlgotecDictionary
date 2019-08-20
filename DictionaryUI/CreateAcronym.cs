using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgotecDictionary;

namespace DictionaryUI
{
    public partial class CreateAcronym : Form
    {
        public CreateAcronym()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (validateNewAcronym())
            {
                Acronym x = new Acronym(textBox1.Text, textBox2.Text, textBox3.Text);
                foreach (IDataConnection db in GlobalConnections.connList)
                {
                    db.CreateAcronym(x);
                }
                MessageBox.Show("Acronym entered successfully!");
                this.Hide();

                UI newForm = new UI();
                newForm.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("This form has invalid information");
            }

            

        }

        private bool validateNewAcronym()
        {
            if ((textBox1.Text == "") || (textBox2.Text == "")) return false;

            return true;
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
