using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_1214073
{
    public partial class validasi : Form
    {
        public validasi()
        {
            InitializeComponent();
        }

        private void validasi_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "Textbox huruf tidak boleh kosong!");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {
                if ((txtHuruf.Text).All(char.IsLetter))
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Betul");
                }
                else
                {
                    epWrong.SetError(txtHuruf, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "");
                }
            }
        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                epWarning.SetError(txtAngka, "Textbox Angka tidak boleh kosong!");
                epWrong.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "");
            }
            else
            {

                if ((txtAngka.Text).All(char.IsNumber))
                {
                    epCorrect.SetError(txtAngka, "Betul");
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "");
                }
                else
                {
                    epCorrect.SetError(txtAngka, "Inputan hanya boleh Angka!");
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "");
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtEmail, "Textbox Email tidak boleh kosong!");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
            else
            {

                if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "Betul");
                }
                else
                {
                    epWrong.SetError(txtEmail, "Inputan hanya boleh Angka!");
                    epWarning.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "");
                }
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (txtAngka1.Text == "")
            {
                epWarning.SetError(txtAngka1, "Textbox Email tidak boleh kosong!");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");
            }
            else
            {
                if ((txtAngka1.Text).All(char.IsNumber))
                {
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka1, "Betul");
                }
                else
                {
                    epWrong.SetError(txtAngka1, "Inputan hanya boleh Angka!");
                    epWarning.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka1, "");
                }
                if (txtAngka2.Text == "")
                {
                    epWarning.SetError(txtAngka2, "Textbox Email tidak boleh kosong!");
                    epWrong.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "");
                }
            }
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            int angka1 = int.Parse(txtAngka1.Text);
            int angka2 = int.Parse(txtAngka2.Text);
            if (txtAngka2.Text == "")
            {
                string input = String.Empty;
                epWarning.SetError(txtAngka2, "Textbox Angka2 tidak boleh kosong!");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }
            else
            {
                if ((txtAngka2.Text).All(char.IsNumber))
                {
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "Betul");
                }
                else
                {
                    epWrong.SetError(txtAngka2, "Inputan hanya boleh Angka!");
                    epWarning.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "");
                }                    

            }
            if (angka1 > angka2)
            {
                epWarning.SetError(txtAngka1, "");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "Betul");

                epWarning.SetError(txtAngka2, "");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "Betul");

            }
            else
            {
                epWarning.SetError(txtAngka1, "Inputan harus lebih dari Angka1");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");


                epWarning.SetError(txtAngka2, "Inputan harus kurang dari Angka1");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }
        }
    }
}
                
            
        
    