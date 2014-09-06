namespace ATM.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   
    public class CardAccount
    {
        public int Id { get; set; }

        public string CardNumber { get; set; }

        public string CardPIN { get; set; }

        [Column(TypeName = "Money")]
        public decimal CardCash { get; set; }
    }
}
