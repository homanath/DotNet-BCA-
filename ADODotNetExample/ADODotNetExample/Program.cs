using System.Data;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
namespace AdoDotNetExample
{
    public class Program
    {
        private const String conString =
            "Data Source=localhost;Database=BcaV;Integrated Security=SSPI;TrustServerCertificate=true";
        //  "Server=localhost;Initial Catalog=BcaV;Integrated Security=True;Trust_Server_Certificate=true";
        //  "Data Source=localhost;Database=BcaV;User Id=sa;Password=12345";
        private static SqlConnection conn = new SqlConnection(conString);
        //conn.ConnectionString = conString;
        private static SqlCommand cmd = new SqlCommand("", conn);
        public static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Select an option:\n1. Insert \n2. Update");
                Console.WriteLine("3. Delete\n4. List\n5. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        if (Insert())
                            Console.WriteLine("Insertion successful.");
                        else
                            Console.WriteLine("Insertion failed.");
                        break;
                    case 2:
                        Update();
                        break;
                    case 3:
                        Delete();
                        break;
                    case 4: Show(); break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
                Console.ReadKey();
            } while (true);
        }
        public static bool Insert()
        {
            String? userName, userPassword, userId;
            Console.WriteLine("Enter your name:");
            userName = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            userPassword = Console.ReadLine();
            Console.WriteLine("Enter your user Id:");
            userId = Console.ReadLine();
            cmd.CommandText = "insert into UserList(userId,userName,loginId,loginPassword,isActive)" +
                "values((Select max(userId)+1 from UserList),@userName,@userId,@userPassword,1)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@userPassword", userPassword);
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery() == 1;
            }
            catch
            {
                Console.WriteLine("Insert error.");
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
            return false;
        }
        public static bool Update()
        {
            String? userName, userPassword, oldUserId, newUserId;
            Console.WriteLine("Enter user Id to update:");
            oldUserId = Console.ReadLine();
            Console.WriteLine("Enter your new name:");
            userName = Console.ReadLine();
            Console.WriteLine("Enter your new password:");
            userPassword = Console.ReadLine();
            Console.WriteLine("Enter your new user Id:");
            newUserId = Console.ReadLine();
            cmd.CommandText = "Update UserList set UserName=@userName,loginId=@loginId,loginPassword=@loginPassword Where loginId=@oldUserId";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@loginId", newUserId);
            cmd.Parameters.AddWithValue("@loginPassword", userPassword);
            cmd.Parameters.AddWithValue("@oldUserId", oldUserId);
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery() == 1;
            }
            catch
            {
                Console.WriteLine("Update error.");
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
            return false;
        }
        public static bool Delete()
        {
            String? userId;
            Console.WriteLine("Enter user Id to remove:");
            userId = Console.ReadLine();
            cmd.CommandText = "Delete From UserList Where LoginId=@userId";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@userId", userId);
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery() == 1;
            }
            catch
            {
                Console.WriteLine("Deletion error.");
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
            return false;
        }
        public static void Show()
        {
            cmd.CommandText = "Select userName,loginPassword,loginId,isActive From UserList";
            try
            {
                conn.Open();
                //do your database stuff
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("List of Users:\nUser Name\tPassword\tLogin Id\tIs Active?");
                while (reader.Read())
                {
                    Console.WriteLine(Convert.ToString(reader["userName"]) + "\t" + Convert.ToString(reader["loginPassword"]) + "\t\t" + Convert.ToString(reader["loginId"]) + "\t\t" + Convert.ToBoolean(reader["isActive"]));
                }
                reader.Close();
                conn.Close();
            }
            catch
            {
                Console.WriteLine("Database Error.");
            }
        }
    }
}
