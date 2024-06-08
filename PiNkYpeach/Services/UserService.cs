using Microsoft.AspNetCore.Identity;
using PiNkYpeach.Data;
using PiNkYpeach.Data.Services.Interfaces;

namespace PiNkYpeach.Data.Services
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
