using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageLux.ViewModel
{
    public class KvittoViewModel
    {
        public const float Price = 60;
        private int time;

        public int Time
        {
            get { return time; }
            set { time = value; }
        }
        private float cost;

        public float Cost
        {
            get { return cost; }
            set { cost = value; }
        }

    }
}