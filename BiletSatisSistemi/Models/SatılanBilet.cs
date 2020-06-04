using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BiletSatisSistemi.Models
{
    public class SatılanBilet
    {
        [Required(ErrorMessage = "Bilet No  boş geçilemez")]
        [Display(Name = "Filim Id")]
        public long FiliId { get; set; }

        [Required(ErrorMessage = "Filim Id boş geçilemez")]
        [Display(Name = "Bilet No")]
        public string BiletNo{ get; set; }

        [Required(ErrorMessage = "Film Adı  boş geçilemez")]
        [Display(Name = "Film Adı")]
        public string FilmAdi { get; set; }

        [Required(ErrorMessage = "Filim Günü gerekli")]
        [Display(Name = "Filim Günü")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime FilmGunu { get; set; }


        [Required(ErrorMessage = "Filim Saati  boş geçilemez")]
        [Display(Name = "Filim Saati")]
        public string FilmSaati { get; set; }
        [Required(ErrorMessage = "Filim Saati  boş geçilemez")]
        [Display(Name = "Filim Saati")]

        public string KoltukNo { get; set; }

        [Required(ErrorMessage = "Katagori   boş geçilemez")]
        [Display(Name = "Katagori")]
        public string Katagori { get; set; }

        [Required(ErrorMessage = "Ad boş geçilemez")]
        [MaxLength(50, ErrorMessage = "Ad maks 50 karakter olabilir")]
        [MinLength(2, ErrorMessage = "Ad min 2 karakter olabilir")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Cep Telefonu gerekli")]
        [Display(Name = "Cep Telefonu")]
        [RegularExpression(@"(([\+]90?)|([0]?))([ ]?)((\([0-9]{3}\))|([0-9]{3}))([ ]?)([0-9]{3})(\s*[\-]?)([0-9]{2})(\s*[\-]?)([0-9]{2})",
           ErrorMessage = "Girilen telefon formatı geçersiz")]
        public string CepTelefonu { get; set; }

        [Required(ErrorMessage = "Email boş geçilemez")]
        [DisplayName("Eposta Adresi")] //using System.ComponentModel;
        [DataType(DataType.EmailAddress,
        ErrorMessage = "Eposta adresiniz formata uygun değil")]     
        public string Email { get; set; }

        public virtual Filmler Filmler { get; set; }


    }
}