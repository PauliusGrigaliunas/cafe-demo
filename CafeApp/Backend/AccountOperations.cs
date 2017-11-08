using System;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class AccountOperations
    {
        public User RetrieveUserData(string email, string password) ///retrieves user's data on successful login
        {
            using (SqlConnection connection = DatabaseConnection.Connection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Email = '" + email + "' AND Password = '" + password + "'", connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            string reader_email = reader["Email"].ToString();
                            string reader_phone = reader["Phone"].ToString();
                            string reader_name = reader["Name"].ToString();
                            string reader_surname = reader["Surname"].ToString();
                            bool reader_premium = reader.GetBoolean(5);
                            return new User(reader_email, reader_phone, reader_name, reader_surname, reader_premium);
                        }
                    }
                }
            }
            return null;
        }

        public enum RegisterOutcome { Success, NameTaken, GeneralError };

        public RegisterOutcome Register(User toRegister, string password)
        {
            using (SqlConnection connection = DatabaseConnection.Connection())
            {
                connection.Open();

                //Check if user already exists
                using (SqlCommand command = new SqlCommand("SELECT Email From Users WHERE Email = '" + toRegister.Email + "'", connection))
                {
                    var result = command.ExecuteScalar();
                    if (result != null)
                        return RegisterOutcome.NameTaken;
                }

                //If name is not taken - register a new acc
                using (SqlCommand command = new SqlCommand("INSERT INTO Users (Email, Password, Name, Surname, Phone, Premium) VALUES (@Email, @Password, @Name, @Surname, @Phone, @Premium)", connection))
                {
                    command.Parameters.AddWithValue("@Email", toRegister.Email);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Name", toRegister.Name);
                    command.Parameters.AddWithValue("@Surname", toRegister.Surname);
                    command.Parameters.AddWithValue("@Phone", toRegister.Phone);
                    command.Parameters.AddWithValue("@Premium", toRegister.Premium.ToString());

                    int rowsChanged = command.ExecuteNonQuery();

                    if (rowsChanged < 0)
                        return RegisterOutcome.GeneralError;
                    else
                        return RegisterOutcome.Success;
                }

            }
            return RegisterOutcome.GeneralError;
        }

    }
}
