using SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepApi.Services
{
    public interface IIdentityService
    {
        Task<bool> CreateUserAsync(SignUp model);

        Task<bool> CreateErrandAsync(CreateErrandIssueViewModel model);
        
    }
}
