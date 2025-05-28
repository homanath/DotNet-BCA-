using LinqTest.Models;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new BcaVContext())
        {
            var users = context.UserLists.ToList();

            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.UserId}, Name: {user.UserName}, Login: {user.LoginId}, Active: {user.IsActive}");
            }
        }
    }
}
