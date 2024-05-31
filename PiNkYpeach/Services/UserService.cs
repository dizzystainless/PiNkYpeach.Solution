using Microsoft.AspNetCore.Identity;
using PiNkYpeach.Web.Data;
using PiNkYpeach.Web.Services.Interfaces;

namespace PiNkYpeach.Web.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationContext _context;

        public UserService(ApplicationContext context)
        {
            _context = context;
        }


    }
}
