namespace UsefulArchitecture.Domain.User
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class User : BaseEntity
    {
        [Required]
        [MaxLength(StringLengths.MediumLength)]
        public string Login { get; set; }

        [Required]
        [MaxLength(StringLengths.MediumLength)]
        public string Password { get; set; }

        [Required]
        [MaxLength(StringLengths.MediumLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(StringLengths.MediumLength)]
        public string SecondName { get; set; }

        [MaxLength(StringLengths.MediumLength)]
        public string LastName { get; set; }

        /// <summary>
        /// Повне імя <see cref="FirstName"/> <see cref="SecondName"/> <see cref="LastName"/>
        /// </summary>
        [NotMapped]
        public string FullName => $"{this.FirstName} {this.SecondName} {this.LastName}".TrimEnd();

        public int? Years { get; set; }
    }
}