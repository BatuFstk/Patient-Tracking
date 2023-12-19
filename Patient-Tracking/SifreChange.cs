using Google.Cloud.Firestore;
using Patient_Follow_Up.Class;
using Patient_Tracking.Class;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Patient_Tracking
{
    public partial class SifreChange : Form
    {
        private UserData loggedInUser;

        public SifreChange(UserData loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
        }

        private async void SifreDegisButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MevcutSifretextbox.Text) || string.IsNullOrEmpty(YeniSifre.Text) || string.IsNullOrEmpty(YeniSifreonay.Text))
            {
                MessageBox.Show("Lütfen tüm şifre alanlarını doldurun!");
                return;
            }

            if (YeniSifre.Text != YeniSifreonay.Text)
            {
                MessageBox.Show("Yeni şifreler uyuşmuyor!");
                return;
            }

            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("UserData").Document(loggedInUser.Username);

            try
            {
                UserData user = (await docRef.GetSnapshotAsync()).ConvertTo<UserData>();

                if (user != null && user.Password == MevcutSifretextbox.Text)
                {
                    // Şifreyi güncelle
                    user.Password = YeniSifre.Text;

                    // Firestore'a güncellenmiş kullanıcı bilgilerini yaz
                    await docRef.SetAsync(user);

                    MessageBox.Show("Şifre değiştirildi!");
                }
                else
                {
                    MessageBox.Show("Mevcut şifreyi yanlış girdiniz!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

    }
}
