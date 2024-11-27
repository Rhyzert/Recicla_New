using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;
using Domain.Entities;

namespace ApplicationService.Prototype
{

    public  class ColetaPrototypeApplication
    {
        private readonly SqlContext _context;

        public ColetaPrototypeApplication(SqlContext context)
        {
            _context = context;
        }


    }
}
