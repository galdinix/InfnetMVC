using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InfnetMVC.Data;
using InfnetMVC.Models;

namespace InfnetMVC.Views.Alunos
{
    public class IndexModel : PageModel
    {
        private readonly InfnetMVC.Data.ApplicationDbContext _context;

        public IndexModel(InfnetMVC.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Aluno> Aluno { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Aluno != null)
            {
                Aluno = await _context.Aluno.ToListAsync();
            }
        }
    }
}
