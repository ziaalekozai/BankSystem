namespace BankSystem.Model
    {/// <summary>
     /// Admin class save the admin informations </summary>
    public class Admin
        {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public double Salary { get; set; }
        public string Role { get; set; }
        }
    }