using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Store.Models.EF
{
    [Table("tb_Contact")]
    public class Contact : CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Ten Khong Duoc De Trong")]
        [StringLength(150, ErrorMessage ="Khong Duoc Vuot Qua 150 Ky Tu")]
        public string Name { get; set; }
        [StringLength(150, ErrorMessage = "Khong Duoc Vuot Qua 150 Ky Tu")]
        public string Email { get; set; }
        public string Website { get; set; }
        [StringLength(4000)]
        public string Message { get; set; }
        public bool IsRead { get; set; }
    }
}