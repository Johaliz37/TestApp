using System;
using System.Collections.Generic;
using System.Text;
using Agreement.DAL.Models;

namespace Agreement.Logic.BL
{
    public class General
    {
        public DevInMotionContext DBConnection()
        {
            return DBContext.DevInMotionContext.GetConnection();
        }
    }
}
