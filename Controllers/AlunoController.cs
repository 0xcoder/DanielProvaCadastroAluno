using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroAluno.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadastroAluno.Controllers
{
    public class AlunoController : Controller
    {

        private readonly Context _context;

        public AlunoController(Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.aluno.ToListAsync());
        }
    }
}
