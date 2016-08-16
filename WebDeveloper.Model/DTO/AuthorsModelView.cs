using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.Model.DTO
{
    public class AuthorsModelView
    {
        public int au_id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "LName", ResourceType = typeof(Resources.Resource))]
        public string au_lname { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "FName", ResourceType = typeof(Resources.Resource))]
        public string au_fname { get; set; }

        [StringLength(50)]
        [Display(Name = "Phone", ResourceType = typeof(Resources.Resource))]
        public string au_phone { get; set; }

        [StringLength(50)]
        [Display(Name = "City", ResourceType = typeof(Resources.Resource))]
        public string au_city { get; set; }

        [StringLength(50)]
        [Display(Name = "State", ResourceType = typeof(Resources.Resource))]
        public string au_state { get; set; }

        [StringLength(50)]
        [Display(Name = "Zip", ResourceType = typeof(Resources.Resource))]
        public string au_zip { get; set; }

        [StringLength(50)]
        [Display(Name = "Sex", ResourceType = typeof(Resources.Resource))]
        public string au_sex { get; set; }

        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        [Display(Name = "Salary", ResourceType = typeof(Resources.Resource))]
        public decimal au_salary { get; set; }

        [StringLength(50)]
        [Display(Name = "Subject", ResourceType = typeof(Resources.Resource))]
        public string au_subject { get; set; }
    }
}