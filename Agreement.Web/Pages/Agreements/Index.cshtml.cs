using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Agreement.Web.Pages.Agreements
{
    public class IndexModel : PageModel
    {
        public IList<Agreement.Logic.Models.dtoAgreement> dtoAgremment { get; set; }

        public IndexModel()
        {
            try
            {
                Agreement.Logic.BL.Agreements agreements = new Logic.BL.Agreements();
                dtoAgremment =agreements.GetAgreement().GetAwaiter().GetResult();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
