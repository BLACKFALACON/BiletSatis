using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BiletSatisSistemi.Models
{
    public class FilmYorum
    {
        [Required(ErrorMessage = "Filim Id boş geçilemez")]
        [Display(Name = "Filim Id")]
        public long FiliId { get; set; }

        [Required(ErrorMessage = "Ad boş geçilemez")]
        [MaxLength(50, ErrorMessage = "Ad maks 50 karakter olabilir")]
        [MinLength(2, ErrorMessage = "Ad min 2 karakter olabilir")]
        public string Ad { get; set; }
     

        [Required(ErrorMessage = "Email boş geçilemez")]
        [DisplayName("Eposta Adresi")] //using System.ComponentModel;
        [DataType(DataType.EmailAddress,
        ErrorMessage = "Eposta adresiniz formata uygun değil")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Yorum alanı boş geçilemez")]
        [MaxLength(200, ErrorMessage = "Yorum maks 50 karakter olabilir")]
        [MinLength(5, ErrorMessage = "Yorum min 2 karakter olabilir")]
        public string Yorum { get; set; }

        public virtual Filmler Filimler { get; set; }

    }
}