using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models {
    public class Person {

        [Required]
        public string Id { get; set; }

        [Required]
        public int Age { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "First Name should be between 3 and 50 characters")]
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last Name should be between 3 and 50 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

    }
}