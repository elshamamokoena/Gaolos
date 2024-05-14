namespace Gaolos.Web.App.ViewModels
{
    public class LoggedInUserViewModel
    {
        public LoggedInUserViewModel(string name, string surname, string email, string userId)
        {
            Name = name;
            Surname = surname;
            Email = email;
            UserId = Guid.Parse(userId);
        }
        public string Name { get; set; } 
        public string Surname { get; set; }
        public string Email { get; set; }
        public Guid  UserId { get; set; }
    }
}
