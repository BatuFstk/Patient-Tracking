using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Patient_Follow_Up.Class
{
    internal static class FirestoreHelper
    {
        static string fireconfig = @"
        {
  ""type"": ""service_account"",
  ""project_id"": ""patient-followup-5a2b9"",
  ""private_key_id"": ""8d0074d400901a9a1c44eab6db073614386877b4"",
  ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQClVWQLYDqyIDQe\nHaIPkRz/7aflV1WjwrRudN37D9x6jw7z9lKI6zhgEd/1luOeHrtHtgS+1raSUGDU\nTjGwXL1hRTH3ZW2L0UJVt8CozHnr7knNCVGeqGkU7gvcDzdbpbv/QpSNvqBCtxWV\nY8WsQI/c3oDi+prNGfTvjkJ4sU0ZTC3Gre8jrLxAsJcrXK1B9R0qqWyX4VJTwJz7\nytb/vfmpLqHJUEkbM0mlBy+1R8ivjKwEUv7DR7sX3/Wls/ETkZtfE7X1RnX7nMVg\nI2/5rQZLQNpsn68Nsmsqmmom0wmOTay2tynNgwNE+6G8HMmevZLsRPW3ortcQx6T\nR/Cc5y29AgMBAAECggEASpTUDgupPqwnRoSQlBwebFbNO7gjYj2VPhSLBFO53jGF\nicjOn4QYSMIXeMZJxIzRZ750so/SCPuoSm1BnfCf326i5RqEiaNqnJdJGfwvbZ3u\n/cab4onO6Ume4PSeQMHpJfNnZu+chKvpWRwKUjNHkldu5bUtuqLgamYOlzpH8MZB\nq72/sqL5Dked2PKPi7kHK5DpBxGK1B/lABRixE/hAmj/S64B9NL6ZRKWnhWcwAtr\nwM72ct6V/JYz0nLMPG9onTSVOQfuBTufMjNOaAr/PQVwZnO4/RhGtQKKQzvrjkHu\nPsVdZxRE8BggFxzYWN+NMYkEKVU3ZLIi5Bzwjf4BcwKBgQDhKUeROPRDlaUbnWCN\n3ogLKT3jA4jLpiJNi1Vgb8j6kX+Sd572UwVawDP4/Oi913p/fX2lPhVHUoEHO5EJ\nrfoxDKe6XM5f0LfvpH1F/2qGjeFiQK4XoJj39OY0K9egziutOURoOqxx6CwV1iV0\nbYPux51pWV/LVGUAv+whlCCdMwKBgQC7+mbX+bQ+cwWX22m7gCcZfZ/aGBV4GmUZ\n9IcNMsFjby13hzsMfKuw0I/31a1AILnAP5zm0gAsUA6VC3IQ3CmRJ1paYBCz05XC\nL6UjDSn12TTwl/EYF6R+m3h1irQi1oEZWou/8jTG3YkP8ldD9nE0A0eVfftNJ2Vf\n2utwhLCpTwKBgQC7sFNOBPHonIdjO47O897nnttNrxaK29PgW/MxTj10UXDMQRar\nMo1WFr28IeZIyaP9PjhMVDIcn/OaedbvAK170ZbHTLFjQXLyOmWKwdykiQSFiHEW\nlPKuTuDOQHWgP/w8i24wjChPUz/cfAQAx4Ggu5jFxpCJx7HiLBnD69w77QKBgDIM\nbF9qi3PpGf8hmxgh+ccOrIXbzbOJi4uKkH6SGe1Ih5mAdtdPRkMwdHRu/s7JJ8uo\n5DSMiyFBO3CxeHBGvgZ4rNTNKQVH+2KVXuljMt3TNAYu3jEk8lYHPN5GzMlNxVej\nxPuZGDYue7S0OEnPDrrjeKazwTn8mEAaQH9XxNV/AoGAcjJEgPXJdg7kqWMtqQR7\nX6v6+cwZs4eGrbvOjwrhkIVUo5GFzkKogaErl+9gO/QWuXPlJWMuCQ0sIhD06iTw\nPJgqIk7ifb1mts9+zJiA5IoLujFbnzI2neColfuIU7anxYqymH0/fJE5HbR7AoMY\nLbBs3cS+WD1F9Qbal2Y5Xlw=\n-----END PRIVATE KEY-----\n"",
  ""client_email"": ""firebase-adminsdk-ujwt8@patient-followup-5a2b9.iam.gserviceaccount.com"",
  ""client_id"": ""117589097741975941876"",
  ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
  ""token_uri"": ""https://oauth2.googleapis.com/token"",
  ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
  ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-ujwt8%40patient-followup-5a2b9.iam.gserviceaccount.com"",
  ""universe_domain"": ""googleapis.com""
}
";

        static string filepath = "";
        public static FirestoreDb Database;

        public static void SetEnvironmentVariable()
        {

            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filepath, fireconfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            Database = FirestoreDb.Create("patient-followup-5a2b9");
            File.Delete(filepath);


        }



    }
}