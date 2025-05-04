namespace MVCStudentRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        [Key]
        [Required]
        [StringLength(9, ErrorMessage = "BNumber must not exceed 9 characters.")]
        public string BNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string Surname { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        public short Age { get; set; }

        [Required]
        [StringLength(255)]
        public string AddressLine1 { get; set; }

        [StringLength(255)]
        public string AddressLine2 { get; set; }

        [Required]
        [StringLength(100)]
        public string CityTown { get; set; }

        [StringLength(10)]
        public string Postcode { get; set; }

        [Required]
        [StringLength(20)]
        public string Telephone { get; set; }

        [Required]
        [StringLength(255)]
        [EmailAddress]
        public string Email { get; set; }


        [Display(Name = "Assessement 1")]
        public short? Assessment1Mark { get; set; }
        [Display(Name = "Assessement 2")]
        public short? Assessment2Mark { get; set; }
        [Display(Name = "Overall Marks")]
        public short? OverallMark { get; set; }

    }
}
