using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.Models;

namespace cw11.Services
{
    public interface IPeopleDbService
    {
        public IEnumerable<Person> GetPeople();
    }
}
