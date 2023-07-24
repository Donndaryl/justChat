using System.Data.SQLite;

namespace justChat.Models
{
    public class User : DB
    {
        int id;
        string userName;
        string password;
        string firstName;
        string lastName;
        string adress;
        int isAdmin;

        public User(int id, string userName, string password, string firstName, string lastName, string adress, int isAdmin)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.adress = adress;
            this.isAdmin = isAdmin;
        }

        public User() { }

        public User  createUser(SQLiteDataReader reader)
        {
            int ? id = reader["id"] != DBNull.Value ? Convert.ToInt32(reader["id"]) : (int?)null;
            string? userName = reader["userName"] != DBNull.Value ? Convert.ToString(reader["userName"]) : null;
            string? firstName = reader["firstName"] != DBNull.Value ? Convert.ToString(reader["firstName"]) : null;
            string? lastName = reader["lastName"] != DBNull.Value ? Convert.ToString(reader["lastName"]) : null;
            string? adress = reader["adress"] != DBNull.Value ? Convert.ToString(reader["adress"]) : null;
            int? isAdmin = reader["isAdmin"] != DBNull.Value ? Convert.ToInt32(reader["isAdmin"]) : (int?)null;
            string? password = reader["password"] != DBNull.Value ? Convert.ToString(reader["password"]) : null;


        }

    }
}
