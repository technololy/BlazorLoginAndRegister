using System;
using Didala.Models.Models;
using Microsoft.AspNetCore.Components;

namespace Didala.Web.Pages
{
    public partial class Landing
    {
        [Inject]
        public Services.IDataServices dataServices { get; set; }
        [Inject] public NavigationManager NavManager { get; set; }

        private LoginModel loginModel = new LoginModel();

        private async void HandleValidSubmitAsync()
        {
            var login = loginModel;
            var response = await dataServices.Login(login);
            if (response != null && response.IsSuccessful)
            {
                Data.DataStore.isAuthenticated = true;
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

            }
        }
    }
}
