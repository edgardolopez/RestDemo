using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        public String ProductId { get; set; }

        [Required]
        public String ProductDescription { get; set; }
    }
}
