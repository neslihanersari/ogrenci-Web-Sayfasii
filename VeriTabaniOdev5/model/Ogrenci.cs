using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VeriTabaniOdev5.Forms;

namespace VeriTabaniOdev5.model
{
    public class Ogrenci
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OgrenciId { get; set; }

        [Required]
        public string Ad { get; set; }

        public string Soyad { get; set; }

       

        public int BolumId { get; set; }
        public Bolum Bolum { get; set; }
        public ICollection<OgrenciDers> OgrenciDersler { get; set; }


  
}
}
