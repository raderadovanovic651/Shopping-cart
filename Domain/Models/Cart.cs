using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int? ItemId { get; set; }
        public bool IsPaid { get; set; }
        [ForeignKey("ItemId")]
        public virtual Item Item { get; set; }
    }
}
