using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageLux.ViewModel
{
    public class KvittoViewModel
    {
        public double Price = 60;
        private double time;

        public double Time
        {
            get { return time; }
            set { time = value; }
        }
        private double cost;

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

    }
}