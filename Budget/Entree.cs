using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget {
    public class Entree {
        public DateTime Date { get; set; }
        public String Raison { get; set; }
        public decimal Montant { get; set; }

        public Entree(DateTime _date, String _raison, decimal _montant) {
            this.Date = _date;
            this.Raison = _raison;
            this.Montant = _montant;
        }

        public string[] EntreeToString() {
            string[] row = {
                Date.ToString("yyyy-MM-dd"),
                Raison,
                Montant.ToString()
            };

            return row;
        }

        public string EntreeToStringOutput() {
            return Date.ToString("yyyy-MM-dd") + ";" +
                Raison + ";" +
                Montant.ToString("0.00");
        }
    }
}
