using System;
using Microsoft.AspNetCore.Components;

namespace Didala.Web.Shared
{
    public partial class AlertModal : ComponentBase, IDisposable
    {

        [Inject] Services.AlertModalService alertModalService { get; set; }

        protected bool isSuccess { get; set; }
        protected string Title { get; set; }
        protected bool IsVisible { get; set; }
        public string Message { get; set; }


        protected override void OnInitialized()
        {
            alertModalService.OnShow += ShowModal;
            alertModalService.OnClose += CloseModal;
        }

        public void ShowModal(string title, string message, bool isSuccess)
        {
            Title = title;
            IsVisible = true;
            this.isSuccess = isSuccess;
            Message = message;

            StateHasChanged();
        }

        public void CloseModal()
        {
            IsVisible = false;
            Title = "";


            StateHasChanged();
        }

        public void Dispose()
        {
            alertModalService.OnShow -= ShowModal;
            alertModalService.OnClose -= CloseModal;
        }
    }
}
