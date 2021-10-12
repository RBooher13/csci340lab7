using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab7_3.Data;
using Lab7_3.Models;

namespace Lab7_3.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly Lab7_3.Data.Lab7_3Context _context;

        public IndexModel(Lab7_3.Data.Lab7_3Context context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
