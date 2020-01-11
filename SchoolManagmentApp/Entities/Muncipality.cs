using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Muncipality
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression("^\\d{4}$")]
        public string ZipCode { get; set; }
        public virtual IEnumerable<School> Schools { get; set; }
    }
}
