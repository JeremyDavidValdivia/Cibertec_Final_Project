using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    [Table("Books")]
    public partial class Books
    {
        public Books()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int title_id { get; set; }

        [Required]
        [StringLength(100)]
        public string title { get; set; }

        [StringLength(10)]
        public string type { get; set; }

        public int pub_id { get; set; }

        [Required]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public decimal price { get; set; }

        [StringLength(50)]
        public string advance { get; set; }

        [StringLength(50)]
        public string royalty { get; set; }

        [StringLength(50)]
        public string ytd_sales { get; set; }

        [StringLength(100)]
        public string notes { get; set; }

        public DateTime pubdate { get; set; }
    }
}
