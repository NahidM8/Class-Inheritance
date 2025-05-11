namespace StringBuilder_Class_Inheritance.Models
{
    public class Account
    {
        public void Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Username ve password bos olmamalidir");
            }
            else if (username == "lorem123" && password == "123456*")
                Console.WriteLine("Giris ugurludur");
            else
                Console.WriteLine("Email ve ya password sehvdir");
        }
    }
}
