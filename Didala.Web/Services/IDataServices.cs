using System;
using System.Threading.Tasks;

namespace Didala.Web.Services
{
    public interface IDataServices
    {
        Task<Models.Models.LoginResponse> Login(Models.Models.LoginModel loginModel);
    }
}
