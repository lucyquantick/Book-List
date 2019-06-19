using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using CRUD_Razor_2_1.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD_Razor_2_1.Pages.BookList
{
	public class IndexModel : PageModel
	{

		// To access DB need applicationDbContext object - use dependency injection for this
		private readonly ApplicationDbContext _db;

		[TempData]
		public string Message { get; set; }

		public IEnumerable<Book> Books { get; set; }

		public IndexModel(ApplicationDbContext db)
		{
			_db = db;
		}

		// Similar to having actions in controllers, with Razor pages we have handlers
		public async Task OnGet()
		{
			Books = await _db.Books.ToListAsync();
		}

	}
}