using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTabaniOdev5.model
{
    public class OgrenciDers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OgrenciDersId { get; set; }
        [Required]
        public int OgrenciId { get; set; }
        public int DersId { get; set; }

        public Ogrenci Ogrenci { get; set; }
        public Ders Ders { get; set; }

        public int Yil { get; set; }
        public int YariYil { get; set; }
        public int Vize { get; set; }

        public int Final { get; set; }


    }
}
