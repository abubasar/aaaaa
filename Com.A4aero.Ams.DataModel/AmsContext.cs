using Microsoft.EntityFrameworkCore;
using System;

namespace Com.A4aero.Ams.DataModel
{
    public class AmsContext:DbContext
    {
        public AmsContext(DbContextOptions<AmsContext> options) : base(options) { }
     
       

    }
}
