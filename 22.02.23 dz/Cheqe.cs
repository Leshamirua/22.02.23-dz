using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._02._23_dz
{
    abstract public class Cheqe
    {
        private protected double money;
        private protected string currency;
        public Cheqe()
        {
            money = 0;
            currency = null;
        }
        public Cheqe(double money, string currency)
        {
            this.money = money;
            this.currency = currency;
        }
        abstract public string GetCheque();
    }

    public class NoCheque : Cheqe
    {
        public NoCheque(double money, string currency) : base(money, currency)
        {
        }

        public override string GetCheque()
        {
            return null;
        }
    }

    public class PaperCheque : Cheqe
    {
        public PaperCheque(double money, string currency) : base(money, currency)
        {
        }

        public override string GetCheque()
        {
            return $"------CHEQUE------\nTotal:{money} {currency}";
        }
    }

    public class ECheque : Cheqe
    {
        public ECheque(double money, string currency) : base(money, currency)
        {
        }

        public override string GetCheque()
        {
            Console.WriteLine("Enter email.");
            string mail = Console.ReadLine();
            return $"------CHEQUE------\nTotal:{money} {currency}\nCopy was sent to {mail}";
        }
    }
}
