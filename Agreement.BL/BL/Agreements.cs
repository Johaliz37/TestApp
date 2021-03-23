using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Agreement.Logic.BL
{
    public class Agreements
    {
        private General objGeneral { get; set; }
        public async Task<List<Models.dtoAgreement>> GetAgreement()
        {
            objGeneral = new General();
            List<Models.dtoAgreement> lstResult;


            using (var dbContext = objGeneral.DBConnection())
            {
                lstResult = await (from agreement in dbContext.Agreement
                                   select new Models.dtoAgreement
                                   {
                                       Id = agreement.Id,
                                       Name = agreement.Name,
                                       Description = agreement.Description,
                                       Amount = agreement.Amount
                                   }).ToListAsync();
            }

            return lstResult;
        }
    }
}
