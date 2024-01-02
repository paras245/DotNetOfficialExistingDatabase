using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DotNetOfficialExistingDatabase.Data;
using DotNetOfficialExistingDatabase.Models;

namespace DotNetOfficialExistingDatabase.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly DotNetOfficialExistingDatabase.Data.BulkyContext _context;

        public IndexModel(DotNetOfficialExistingDatabase.Data.BulkyContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
