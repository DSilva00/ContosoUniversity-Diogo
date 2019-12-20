using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoUniversity.Pages
{
    public class HelloModel : PageModel
    {

        public string Name { get; set; }
        /// <summary>
        /// This is a method that will be called when an http get occurs.
        /// </summary>

        public void OnGet()
        {
            Name = null;
        }

        public void OnPost()
        {
            this.Name = Request.Form["Name"];

        }

    }
}