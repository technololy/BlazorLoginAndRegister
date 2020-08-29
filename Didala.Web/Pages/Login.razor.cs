using System;
using Didala.Models.Models;
using Microsoft.AspNetCore.Components;

namespace Didala.Web.Pages
{
    public partial class Login
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
                if (Data.DataStore.userType == ("Influencers"))
                {
                    NavManager.NavigateTo("/InfluencersDashboard");
                }
                else if (Data.DataStore.userType == ("Brands"))
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
