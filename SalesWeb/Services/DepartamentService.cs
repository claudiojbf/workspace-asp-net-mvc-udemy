using SalesWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesWeb.Services
{
    public class DepartamentService
    {
        private readonly SalesWebContext _context;
        public DepartamentService(SalesWebContext context)
        {
            _context = context;
        }

        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
