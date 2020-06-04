using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BiletSatisSistemi.Models
{
    public class Contact
    {

        [Required(ErrorMessage = "Yorum Id No boş geçilemez")]     
        public int YarumId { get; set; }

        [Required(ErrorMessage = "Ad boş geçilemez")]
        [MaxLength(50, ErrorMessage = "Ad maks 50 karakter olabilir")]
        [MinLength(2, ErrorMessage = "Ad min 2 karakter olabilir")]
        public string Ad { get; set; }
     
        [Required(ErrorMessage = "Email boş geçilemez")]     
        [DataType(DataType.EmailAddress,ErrorMessage = "Eposta adresiniz formata uygun değil")]     
        public string Email { get; set; }

        [Required(ErrorMessage = "Konu boş geçilemez")]
        [MaxLength(50, ErrorMessage = "Ad maks 50 karakter olabilir")]
        [MinLength(2, ErrorMessage = "Ad min 2 karakter olabilir")]
        public string Konu { get; set; }

        [Required(ErrorMessage = "Ad boş geçilemez")]
        [MaxLength(200, ErrorMessage = "Ad maks 50 karakter olabilir")]
        [MinLength(5, ErrorMessage = "Ad min 2 karakter olabilir")]
        public string Mesaj { get; set; }

  
    }
}