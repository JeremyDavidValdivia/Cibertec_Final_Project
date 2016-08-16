using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebDeveloper.Model
{
    [Table("BookAuthor")]
    public partial class BookAuthor
    {
        public BookAuthor()
        {

        }

        [Key]
        public int bo_id { get; set; }

        public int au_id { get; set; }

        public int title_id { get; set; }

        [Required]
        [StringLength(100)]
        public string au_ord { get; set; }

        [StringLength(50)]
        public string royaltyper { get; set; }

    }
}
