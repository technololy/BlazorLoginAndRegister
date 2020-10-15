using System;
using Microsoft.AspNetCore.Components;

namespace Didala.Web.Services
{
    public class AlertModalService
    {
        public event Action<string, string, bool> OnShow;
        public event Action OnClose;

        public void Show(string title, string message, bool isSuccess)
        {

            OnShow?.Invoke(title, message, isSuccess);
        }

        public void Close()
        {
            OnClose?.Invoke();
        }
    }
}
