using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIFizyo.Model
{
    public class Kullanıcı
    {
     

            [Key]
            public int KullanıcıID { get; set; }

            [Required(ErrorMessage = "{0} gerekli."), Display(Name = "E-posta"), StringLength(50, MinimumLength = 6, ErrorMessage = "{0} en az {2} en fazla {1} karakter olabilir."), DataType(DataType.EmailAddress, ErrorMessage = "Geçersiz {0}")]
            public string Eposta { get; set; }

            [Required(ErrorMessage = "{0} gerekli."), Display(Name = "Şifre"), StringLength(20, MinimumLength = 6, ErrorMessage = "{0} en az {2} en fazla {1} karakter olabilir."), DataType(DataType.Password), RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{6,}$", ErrorMessage = "Şifre en az bir küçük harf bir büyük harf ve bir rakam içermelidir.")]
            public string Şifre { get; set; }

            [NotMapped, Display(Name = "Şifre Tekrarı"), DataType(DataType.Password), Compare("Şifre", ErrorMessage = "Şifre ve tekrarı uyuşmuyor.")]
            public string ŞifreTekrarı { get; set; }

            [Required(ErrorMessage = "{0} Gerekli."), Display(Name = "Rol")]
            public int RolID { get; set; }


        public Rol Rol { get; set; } // navigasyon için gerekli







    }
}
