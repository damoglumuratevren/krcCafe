using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE.Entity.Concrete.UserEn
{
    [Table("Users")]
    public class User : BaseEntity
    {
        [Key, Required, Display(Name = "Kullanıcı Id")]
        public int UserId { get; set; }

        [Required, StringLength(30), Display(Name = "Adı")]
        public string Name { get; set; }

        [Required, StringLength(30), Display(Name = "Soyadı")]
        public string Surname { get; set; }

        [Required, StringLength(32), Display(Name = "Hash şifre")]
        public string HashPasword { get; set; }

        [Required, StringLength(32), Display(Name = "salt şifre")]
        public string Saltpassword { get; set; }


        [Required, StringLength(30), Display(Name = "Kullanıcı Adı")]
        [Index(IsUnique = true)]
        public string Username { get; set; }
    }
}
