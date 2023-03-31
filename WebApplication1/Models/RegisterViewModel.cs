using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Ad alanı boş geçilemez")]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
