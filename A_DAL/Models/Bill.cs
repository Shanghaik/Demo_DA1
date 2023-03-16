using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    internal class Bill
    {
        public Guid Id { get; set; }
        public Guid IdNV { get; set; }
        public Guid IdKH { get; set; }
        public DateTime CreateDate { get; set; }
        public int Status { get; set; }
        public string Note { get; set; }
        public virtual List<BillDetails> Details { get; set; } // Navigation
    }
}
