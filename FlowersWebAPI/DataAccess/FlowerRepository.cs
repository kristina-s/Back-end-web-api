using DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class FlowerRepository: IRepository<FlowerDto>
    {
        private readonly AppDbContext _context;
        public FlowerRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(FlowerDto entity)
        {
            _context.Flowers.Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<FlowerDto> GetAll()
        {
            return _context.Flowers;
        }
    }
}
