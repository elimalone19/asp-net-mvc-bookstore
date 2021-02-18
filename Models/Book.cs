using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace asp_net_fifth_assignment.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string Publisher { get; set; }
        [RegularExpression(@"^ (?: ISBN(?:-13) ?:? ) ? (?=[0 - 9]{13}$|(?=(?:[0-9]+[- ]){4})[- 0-9]{ 17}$)97[89][- ]?[0 - 9]{ 1,5}
[- ]?   [0 - 9] +[- ]?[0 - 9] +[- ]?[0 - 9]$", ErrorMessage = "You must supply a valid ISBN number.")]
        public string Isbn { get; set; }
        public string Classification { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

    }
}
