using Google.Cloud.Firestore;
using Patient_Follow_Up.Class;
using Patient_Tracking.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Tracking
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            var db = FirestoreHelper.Database;


            if (string.IsNullOrEmpty(Kayıttckimliktext.Text) || string.IsNullOrEmpty(Kayıtsifretext.Text) || string.IsNullOrEmpty(DoktorAdi.Text) || string.IsNullOrEmpty(DoktorSoyadi.Text))
            {
                MessageBox.Show("Tc Kimlik No , Adınız , Soyadınız ve Şifre Bölümünü Eksiksiz doldurunuz!");
                return;
            }
            if (Kayıttckimliktext.Text.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır.");
                return;
            }

            if (CheckIfUserAlreadyExist())
            {
                MessageBox.Show("Bu Kimlik Numarasına Sahip Bir Kullanıcı Bulunmaktadır!");
                return;
            }

            var data = GetWriteData();
            DocumentReference docRef = db.Collection("UserData").Document(data.Username);
            docRef.SetAsync(data);
            MessageBox.Show("Hesap oluşturuldu!");


        }

        private void backtologinbutton_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            Close();
        }

        private UserData GetWriteData()
        {
            string username = Kayıttckimliktext.Text.Trim();
            string password = Security.Encrypt(Kayıtsifretext.Text);
            string docadi = DoktorAdi.Text.Trim();
            string docsoyadi = DoktorSoyadi.Text.Trim();

            return new UserData()
            {
                Username = username,
                Password = password,
                DoktorName = docadi,
                DoktorSurname = docsoyadi

            };
        }

        private bool CheckIfUserAlreadyExist()
        {
            string username = Kayıttckimliktext.Text.Trim();

            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("UserData").Document(username);

            try
            {
                UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

                if (data != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata oluştu: " + ex.Message);
                return false;
            }
        }

        private void Kayıttckimliktext_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Kayıttckimliktext.Text))
            {
                return;
            }


            string numericText = new string(Kayıttckimliktext.Text.Where(char.IsDigit).ToArray());


            if (Kayıttckimliktext.Text != numericText)
            {
                Kayıttckimliktext.Text = numericText;
                Kayıttckimliktext.SelectionStart = numericText.Length;
            }
        }
    }
}
