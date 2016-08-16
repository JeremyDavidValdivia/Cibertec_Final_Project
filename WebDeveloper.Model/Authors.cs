using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    [Table("Authors")]
    public partial class Authors
    {
        public Authors()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int au_id { get; set; }

        [Required]
        [StringLength(50)]
        public string au_lname{ get; set; }

        [Required]
        [StringLength(50)]
        public string au_fname { get; set; }

        [StringLength(50)]
        public string au_phone { get; set; }

        [StringLength(50)]
        public string au_city { get; set; }

        [StringLength(50)]
        public string au_state { get; set; }

        [StringLength(50)]
        public string au_zip { get; set; }

        [StringLength(50)]
        public string au_sex { get; set; }

        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public decimal au_salary { get; set; }

        [StringLength(50)]
        public string au_subject { get; set; }
    }
}
