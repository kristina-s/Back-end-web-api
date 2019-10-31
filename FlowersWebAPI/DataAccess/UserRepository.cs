using DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class UserRepository : IRepository<UserDto>
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(UserDto entity)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<UserDto> GetAll()
        {
            return _context.Users;
        }
    }
}
