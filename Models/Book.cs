﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Burduhos_Raluca_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]

        [Required(ErrorMessage = "Titlul cărții este obligatoriu.")]

        //[RegularExpression(@"^[A-Z]+[a-z\s]*$")]
        [StringLength(150, MinimumLength = 3)]
        //am adaugat regula: lungimea maxima a titlului 150, iar cea minima 3
        public string Title { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
