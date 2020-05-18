using Cwiczenia10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia10.Services
{
    public class EfDbService : IDbServices
    {
        public s16878Context _context { get; set; }

        public EfDbService(s16878Context context)
        {
            _context = context;
        }
        public void PromoteStudents()
        {
            var list = _context.Student.Where(s => s.FirstName != null).ToList();
            
        }

        public void Update(string id)
        {
            var list = _context.Student.First(s => s.IndexNumber == id);
            list.FirstName = "Adam";
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            _context.Remove(_context.Student.Single(s => s.IndexNumber == id));
            _context.SaveChanges();
        }
    }
}
