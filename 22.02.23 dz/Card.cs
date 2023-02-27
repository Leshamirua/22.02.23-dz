using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._02._23_dz
{
    public class Card
    {
        public double Money { get; set; }
        readonly int cvc;
        readonly long id;
        readonly string currency;
        public long Id { get { return id; } }
        public string Currency { get { return currency; } }

        readonly int pin;


        public Card(double money, string currency, int cvc, long id, int pin)
        {
            Money = money;
            this.cvc = cvc;
            this.id = id;
            this.pin = pin;
            this.currency = currency;
        }

        public bool CheckCVC(int cvc)
        {
            return cvc == this.cvc;
        }
        public bool CheckPIN(int pin)
        {
            return pin == this.pin;
        }
    }
}
