using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace Patient_Tracking.Class
{
    [FirestoreData]
    public class UserData
    {
        [FirestoreProperty]
        public string Username { get; set; }
        [FirestoreProperty]
        public string Password { get; set; }
        [FirestoreProperty]
        public string DoktorName { get; set; }
        [FirestoreProperty]
        public string DoktorSurname { get; set; }


    }
}
