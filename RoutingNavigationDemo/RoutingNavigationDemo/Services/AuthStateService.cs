namespace RoutingNavigationDemo.Services
{
    public class AuthStateService
    {
        public bool IsLoggedIn { get; set; } = false;
        public string UserName { get; set; } = string.Empty;

        public void Login(string userName)
        {
            IsLoggedIn = true;
            UserName = userName;
        }

        public void Logout()
        {
            IsLoggedIn = false;
            UserName = string.Empty;
        }
    }





}
