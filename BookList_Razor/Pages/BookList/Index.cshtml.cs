using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookList_Razor.Pages.BookList
{
    public class IndexModel : PageModel
    {
        public string SomeData { get; set; }
        public void OnGet()
        {
            SomeData = "Hello from page model!";
        }
    }
}