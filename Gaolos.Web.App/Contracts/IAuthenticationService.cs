﻿using Gaolos.Web.App.Services.Base;

namespace Gaolos.Web.App.Contracts
{
    public interface IAuthenticationService
    {
        Task<ApiResponse> Login(string email, string password);
        Task<ApiResponse> Register(string name, string surname, string email, string password);
        Task Logout();
    }
}
