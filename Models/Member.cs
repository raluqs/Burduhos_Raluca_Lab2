using System.ComponentModel.DataAnnotations;

namespace Burduhos_Raluca_Lab2.Models
{
    public class Member
    {
        public int ID { get; set; }


        [RegularExpression(@"^[A-Z]+[a-z\s]*$", ErrorMessage = 
        "Prenumele trebuie sa inceapa cu majuscula(ex.Ana sau Ana Maria sau AnaMaria")]
        [StringLength(30, MinimumLength = 3)]
        public string? FirstName { get; set; }
        [RegularExpression(@"^[A-Z]+[a-z\s]*$")]
        [StringLength(30, MinimumLength = 3)]
        public string? LastName { get; set; }
        [StringLength(70)]
        public string? Adress { get; set; }
        public string Email { get; set; }

        public Member()
        {
            Email = "";
        }
        [RegularExpression(@"^0?\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$",
            ErrorMessage = "Telefonul trebuie sa fie de forma '0722-123-123' sau'0722.123.123' sau '0722 123 123'")]
        //am adaugat 0? pentru a obliga utilizatorul ca prima cifra introdusa din nr de telefon sa fie 0
        public string? Phone { get; set; }

        [Display(Name = "Full Name")]
        public string? FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public ICollection<Borrowing>? Borrowings { get; set; }
    }
}
