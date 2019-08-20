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
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAcronym newForm = new CreateAcronym();
            newForm.ShowDialog();
            this.Close();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            List<String> matchingAcronyms = null;
            if (validateNewAcronym())
            {
                
                foreach (IDataConnection db in GlobalConnections.connList)
                {
                    matchingAcronyms = db.findAcronym(textBox1.Text);
                }
                if (matchingAcronyms != null)
                {
                    foreach (string elem in matchingAcronyms) {
                        listBox2.Items.Add(elem);
                    }
                }
            }        }

        private bool validateNewAcronym()
        {
            if (textBox1.Text == "") return false;

            return true;
        }

    }
}
