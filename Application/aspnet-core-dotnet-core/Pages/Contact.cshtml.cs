using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnet_core_dotnet_core.Pages
{
    public class ContactModel : PageModel
    {
        public List<string> TeamMembers {get; set;} 
    
        public void OnGet()
        {
            var nameList = new List<string>() {"John", "Peter", "Mark", "Frank"};
            TeamMembers = nameList;
        }
    }
}