using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components
{
    public partial class AuthModal
    {
        public LoginViewModel LoginViewModel { get; set; }
        public RegisterViewModel RegisterViewModel { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public string Message { get; set; }
        [Inject]
        private IAuthenticationService AuthenticationService { get; set; }

        public AuthModal()
        {
         //   LoginViewModel = new LoginViewModel();
        }

        protected override void OnInitialized()
        {
            LoginViewModel = new LoginViewModel();
            RegisterViewModel = new RegisterViewModel();

         //   return base.OnInitializedAsync();
        }

        protected async void HandleValidLoginSubmit()
        {
            var response = await AuthenticationService.Login(LoginViewModel.Email, LoginViewModel.Password);
            if (response.Success)
            {
                NavigationManager.NavigateTo("/account",true);
            }
            else
            {
                //  Message = response.Message;
                Message = "Username/password combination unknown";
            }
        }
        protected async void HandleValidRegisterSubmit()
        {
           var response= await AuthenticationService.Register(RegisterViewModel.Name,RegisterViewModel.Surname,
               RegisterViewModel.Email, RegisterViewModel.Password);

            if(response.Success)
            {
                NavigationManager.NavigateTo("/user/account");
            }
            else
            {
                Message = "error registering user";
            }

        }
        
    }
}
