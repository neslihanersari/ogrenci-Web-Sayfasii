using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace VeriTabaniOdev5.model
{
        public class Ders
        {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DersId { get; set; }
        [Required]

        public string DersAd { get; set; }


        public ICollection<OgrenciDers> OgrenciDersler { get; set; }
        
           
        }
    }



