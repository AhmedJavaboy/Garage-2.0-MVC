using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using  System.Data.Entity;

namespace GarageLux.DataAccessLayer
{
    public class IncheckedVehicleContext:DbContext
    {
        public IncheckedVehicleContext() : base("DbGarageLux")
        {

        }

        public DbSet<Models.IncheckedVehicle> Vehicles { get; set; }
    }
}