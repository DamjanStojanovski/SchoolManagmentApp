using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class School
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string SchoolFullName { get; set; }
        [MaxLength(50)]
        [Required]
        public string SchoolShortName { get; set; }
        [RegularExpression(@"^07[0-9]\d{6}$")]
        [Required]
        //[Phone]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(100)]
        public string WebsiteURL { get; set; }
        [Required]
        [RegularExpression("^\\d{13}$")]
        public string VATNumber { get; set; }
        public Guid MuncipalityId { get; set; }
        [ForeignKey("MuncipalityId")]
        public virtual Muncipality Muncipality { get; set; }
    }
}
