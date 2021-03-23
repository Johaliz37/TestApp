using System;
using System.Collections.Generic;
using System.Text;

namespace Agreement.Logic.DBContext
{
    public class DevInMotionContext
    {
        public static Agreement.DAL.Models.DevInMotionContext GetConnection()
        {
            return new Agreement.DAL.Models.DevInMotionContext();

        }
    }
}
