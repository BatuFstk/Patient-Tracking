using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using Patient_Follow_Up.Class;
using Patient_Tracking.Class;

namespace Patient_Tracking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tckimliktextbox.Text) || string.IsNullOrEmpty(Sifretextbox.Text))
            {
                MessageBox.Show("Tc Kimlik no ve şifre alanlarını doldurun!");
                return;
            }
            if (Tckimliktextbox.Text.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır.");
                return;


            }
            string username = Tckimliktextbox.Text.Trim();
            string password = Sifretextbox.Text;

            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("UserData").Document(username);

            try
            {
                UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

                if (data != null)
                {
                    if (password == (data.Password))
                    {
                        MessageBox.Show("Giriş Başarılı!");
                        Hide();
                        Anasayfa form = new Anasayfa(data);
                        form.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adını veya Şifreyi Girdiniz!");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adını veya Şifreyi Yanlış Girdiniz!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void Tckimliktextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tckimliktextbox.Text))
            {
                return;
            }


            string numericText = new string(Tckimliktextbox.Text.Where(char.IsDigit).ToArray());


            if (Tckimliktextbox.Text != numericText)
            {
                Tckimliktextbox.Text = numericText;
                Tckimliktextbox.SelectionStart = numericText.Length;
            }
        }

        private void BacktoregisterButton_Click(object sender, EventArgs e)
        {

            Hide();
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
            Close();

        }
    }
    }
    

