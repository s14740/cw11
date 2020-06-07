using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.Models;

namespace cw11.Services
{
    public class EfPeopleDbService : IPeopleDbService
    {

        private readonly PeopleDbContext _context;
        public EfPeopleDbService(PeopleDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Person> GetPeople()
        {
            return _context.Persons.ToList();
        }
    }
}
