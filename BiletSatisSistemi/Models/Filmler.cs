using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BiletSatisSistemi.Models
{
    public class Filmler
    {

        [Required(ErrorMessage = "Filim Id boş geçilemez")]
        [Display(Name = "Filim Id")]
        public long FilimId { get; set; }

        [Required(ErrorMessage = "Film Adı  boş geçilemez")]
        [Display(Name = "Film Adı")]
        [MaxLength(50, ErrorMessage = "Film Adı  maks 50 karakter olabilir")]
        [MinLength(2, ErrorMessage = "Film Adı  min 2 karakter olabilir")]
        public string FilimAdi { get; set; }

        [Required(ErrorMessage = "Yönetmen Adı boş geçilemez")]
        [Display(Name = "Yönetmen Adı")]
        [MaxLength(50, ErrorMessage = "Yönetmen Adı  maks 50 karakter olabilir")]
        [MinLength(2, ErrorMessage = "Yönetmen Adı  min 2 karakter olabilir")]
        public string Yonetmen { get; set; }

        [Required(ErrorMessage = "Oyuncu Adı  boş geçilemez")]
        [Display(Name = "Oyuncu Adı")]
        [MaxLength(100, ErrorMessage = "Oyuncu Adı  maks 100 karakter olabilir")]
        [MinLength(2, ErrorMessage = "Oyuncu Adı  min 2 karakter olabilir")]
        public string Oyuncular { get; set; }

        [Required(ErrorMessage = "Süre alanı  boş geçilemez")]
        [Display(Name = "Süre")]
        [MaxLength(3, ErrorMessage = "Süre  maks 3 karakter olabilir")]
        [MinLength(1, ErrorMessage = " Süre  min 1 karakter olabilir")]
        public int Sure { get; set; }

        [Required(ErrorMessage = "Katagori alanı  boş geçilemez")]
        [Display(Name = "Katagori")]
        [MaxLength(100, ErrorMessage = "Katagori   maks 100 karakter olabilir")]
        [MinLength(2, ErrorMessage = "Katagori  min 2 karakter olabilir")]
        public string Katagori { get; set; }

        [Required(ErrorMessage = "Resim alanı  boş geçilemez")]
        [Display(Name = "Resim")]
        [MaxLength(100, ErrorMessage = "Resim   maks 100 karakter olabilir")]
        [MinLength(2, ErrorMessage = "Resim  min 2 karakter olabilir")]
        public string Resim { get; set; }


        [Required(ErrorMessage = "Özet alanı  boş geçilemez")]
        [Display(Name = "Özet")]
        public string Ozet { get; set; }

        [Required(ErrorMessage = "Vizyona  Tarihi gerekli")]
        [Display(Name = "Vizyon Tarihi")]
        public string Vizyontrh { get; set; }

        public virtual ICollection<FilmYorum> FilimYorums { get; set; }
        public virtual ICollection<SatılanBilet> SatılanBilets { get; set; }

    }
      
}