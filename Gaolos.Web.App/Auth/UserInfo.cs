namespace Gaolos.Web.App.Auth
{
    public class UserInfo
    {
        public string UserId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool IsEmailConfirmed { get; set; }
        public Dictionary<string, string> Claims { get; set; } = [];
    }
}
