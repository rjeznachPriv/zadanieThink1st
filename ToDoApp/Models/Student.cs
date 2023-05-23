using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models {
    public class Student : Person {

        [StringLength(250, ErrorMessage = "Univeristy should be shorter or equal to 250 characters")]
        public string University { get; set; }
    }
}