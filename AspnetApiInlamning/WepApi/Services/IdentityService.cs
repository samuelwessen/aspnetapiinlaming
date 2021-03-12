using Microsoft.Extensions.Configuration;
using SharedLibrary.Entities;
using SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepApi.Data;

namespace WepApi.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly SqlDbContext _context;
        private IConfiguration _configuration { get; }

        public IdentityService(SqlDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        


        public async Task<bool> CreateUserAsync(SignUp model)
        {
            if (!_context.ServiceWorkers.Any(sw => sw.Email == model.Email))
            {
                try
                {
                    var sw = new ServiceWorker()
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Email = model.Email
                    };
                    sw.CreatePasswordWithHash(model.Password);
                    _context.ServiceWorkers.Add(sw);
                    await _context.SaveChangesAsync();

                    return true;
                }
                catch
                {

                }
            }

            return false;
        }

        
        public async Task<bool> CreateErrandAsync(CreateErrandIssueViewModel model)
        {
            try
            {
                var errand = new ErrandIssue()
                {
                    CustomersName = model.CustomersName,
                    ServiceWorkerId = model.ServiceWorkerId,
                    Created = model.Created,
                    Changed = model.Changed,
                    ErrandStatus = model.ErrandStatus,
                    Description = model.Description
                };
                _context.ErrandIssues.Add(errand);
                await _context.SaveChangesAsync();

                return true;
            }
            catch { }

            return false;
        }
    }
}
