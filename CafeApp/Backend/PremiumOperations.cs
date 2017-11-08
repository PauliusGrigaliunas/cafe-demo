using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Serialization;

namespace Backend
{
    public class LoginDetails
    {
        public string email;
        public string password;

        public LoginDetails()
        {
        }

        public LoginDetails(string username, string password)
        {
            this.email = username;
            this.password = password;
        }
    }

    public class PremiumOperations
    {
        string _filepath = "PremiumUserLogin.xml";

        public void WritePremiumUserFile(LoginDetails userLogDetails)
        {
            using (Stream fs_w = new FileStream(_filepath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(LoginDetails));
                serializer.Serialize(fs_w, userLogDetails);
            }
        }

        public LoginDetails GetPremiumLogin()
        {
            LoginDetails userFromXML;
            if (File.Exists(_filepath))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(LoginDetails));

                using (FileStream fs_r = File.OpenRead(_filepath))
                {
                    userFromXML = (LoginDetails)deserializer.Deserialize(fs_r);
                }

                //Checking if it's a premium user
                using (SqlConnection connection = DatabaseConnection.Connection())
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Users WHERE Email = '" + userFromXML.email + "' AND Password = '" + userFromXML.password + "' AND Premium = 'true'";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            return new LoginDetails(reader["Email"].ToString(), reader["Password"].ToString());
                        }
                    }
                } 
            }
            //in case of file not existing OR user not having premium status
            return null;
        }

    }
}
