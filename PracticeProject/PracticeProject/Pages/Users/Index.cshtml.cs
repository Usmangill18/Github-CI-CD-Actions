using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PracticeProject.Data;
using PracticeProject.Model;

namespace PracticeProject.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly PracticeProject.Data.PracticeProjectContext _context;

        public IndexModel(PracticeProject.Data.PracticeProjectContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                User = await _context.User.ToListAsync();
            }
        }
    }
}
