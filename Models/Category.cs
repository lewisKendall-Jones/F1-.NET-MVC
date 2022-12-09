using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }    

        public virtual ICollection<Result> Results { get; set; }
    }
}