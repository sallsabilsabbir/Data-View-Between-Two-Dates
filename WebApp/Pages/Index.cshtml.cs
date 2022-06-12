using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public IEnumerable<EmpJoinDateClass> results { get; set; }

        public void OnGet()
        {

            results = _db.NewEmployeeJoin.ToList();
        }

       public void OnPost(DateTime startdate, DateTime enddate)
        {
            results = (from x in _db.NewEmployeeJoin where(x.Joindate<=startdate)&&(x.Joindate>=enddate) select x).ToList();
        }
    }
}
