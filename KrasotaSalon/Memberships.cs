using System;
using System.Collections.Generic;
using System.Text;

namespace KrasotaSalon
{
    public class PremiumMembership : Membership
    {
        public override decimal GetDiscount()
        {
            return 0.2M;
        }

        public override string ToString()
        {
            return "Premium membership with 20% discount.";
        }
    }


    public class GoldenMembership : Membership
    {
        public override decimal GetDiscount()
        {
            return 0.15M;
        }

        public override string ToString()
        {
            return "Golden membership with 15% discount.";
        }
    }


    public class SilverMembership : Membership
    {
        public override decimal GetDiscount()
        {
            return 0.1M;
        }

        public override string ToString()
        {
            return "Silver membership with 10% discount.";
        }
    }


    public class NoMembership : Membership
    {
        public override decimal GetDiscount()
        {
            return 0;
        }

        public override string ToString()
        {
            return "No membership.";
        }
    }
}
