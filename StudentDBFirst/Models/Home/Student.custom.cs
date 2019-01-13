using System.ComponentModel.DataAnnotations;

namespace StudentDBFirst.Models.DB
{
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
    }

    public class StudentMetadata
    {
        [Display(Name = "Student Id:")]
        public int StudentId { get; set; }

        [Display(Name = "Full Name:")]
        [Required(ErrorMessage = "Full Name is required.")]
        public string FullName { get; set; }

        [Display(Name = "Email:")]
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        [Display(Name = "Mobile:")]
        public string Mobile { get; set; }

        [Display(Name = "Telephone:")]
        public string Telephone { get; set; }

        [Display(Name = "Notes:")]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }
}