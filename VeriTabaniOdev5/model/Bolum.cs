using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeriTabaniOdev5.model
{
    public class Bolum
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BolumId { get; set; }

        [Required]
        public string BolumAd { get; set; }

        public List<Ogrenci> Ogrenciler { get; set; }

        public int FakulteId { get; set; }
        public Fakulte Fakulte { get; set; }
    }
}
