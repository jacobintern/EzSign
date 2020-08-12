using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EzSign.Models
{
    public class ez_acc
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int auto_id { get; set; }
        [Key, Required]
        public string emp_id { get; set; }
        [Required]
        public string dept_id { get; set; }
        [Required]
        public string position_id { get; set; }
        [Required]
        public string first_name { get; set; }
        [Required]
        public string last_name { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string tel_h { get; set; }
        public string tel_o { get; set; }
        public string tel_ext { get; set; }
        public string tel_fax { get; set; }
        public string phone { get; set; }
        [Required]
        public string create_by { get; set; }
        [Required]
        public DateTime create_time { get; set; }
        public string edit_by { get; set; }
        public DateTime? edit_time { get; set; }
    }
}