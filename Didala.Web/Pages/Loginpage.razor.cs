using System;
using Didala.Models.Models;
using Didala.Web.Services;
using Microsoft.AspNetCore.Components;

namespace Didala.Web.Pages
{
    public partial class LoginPage
    {
        [Inject]
        public Services.IDataServices dataServices { get; set; }
        [Inject]
        public Services.AppState AppState { get; set; }
        [Inject] public NavigationManager NavManager { get; set; }
        [Inject] public Services.AlertModalService AlertModalService { get; set; }


        private LoginModel loginModel = new LoginModel();
        bool IsTaskRunning = false;

        public async void HandleValidSubmitAsync()
        {
            IsTaskRunning = true;
            var login = loginModel;
            var response = await dataServices.Login(login);
            IsTaskRunning = false;
            if (response != null && response.IsSuccessful)
            {
                Data.DataStore.isAuthenticated = true;
                AppState.LoggedIn = true;
                if (Data.DataStore.userType.ToLower().Contains("influencer"))
                {
                    NavManager.NavigateTo("/InfluencersDashboard");
                }
                else if (Data.DataStore.userType.ToLower().Contains("brand"))
                {
                    NavManager.NavigateTo("/BrandsDashboard");
                }
                else
                {
                    NavManager.NavigateTo("/Dashboard");
                }

            }
            else
            {
                AlertModalService.Show("Oops", "Wrong username/password", false);

            }
        }
    }
}
