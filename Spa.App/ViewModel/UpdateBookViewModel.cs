using System.ComponentModel.DataAnnotations;

namespace Spa.App.ViewModel
{
    public class UpdateBookViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Kitap adı zorunludur.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Kitap adı 2-100 karakter arasında olmalıdır.")]
        [Display(Name = "Kitap Adı")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Yazar adı zorunludur.")]
        [StringLength(100, ErrorMessage = "Yazar adı en fazla 100 karakter olmalıdır.")]
        [Display(Name = "Yazar")]
        public string Author { get; set; }

        [Required(ErrorMessage = "ISBN zorunludur.")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "ISBN 5-20 karakter arasında olmalıdır.")]
        [Display(Name = "ISBN")]
        public string ISBN { get; set; }

        [StringLength(2000, ErrorMessage = "Açıklama en fazla 2000 karakter olmalıdır.")]
        [Display(Name = "Açıklama")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Tür zorunludur.")]
        [StringLength(50, ErrorMessage = "Tür en fazla 50 karakter olmalıdır.")]
        [Display(Name = "Tür")]
        public string Genre { get; set; }

    }
}
