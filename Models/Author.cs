using System.ComponentModel.DataAnnotations;

namespace Damian_Ionut_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Display(Name = "AuthorFirst Name")]
        public string FirstName { get; set; }

        [Display(Name = "AuthorLast Name")]
        public string LastName { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
