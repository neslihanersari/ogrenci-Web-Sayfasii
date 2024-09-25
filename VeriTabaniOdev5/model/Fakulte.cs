using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriTabaniOdev5.model;


namespace VeriTabaniOdev5.model
{
    public class Fakulte
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FakulteId { get; set; }

        [Required]
        public string FakulteAd { get; set; }

        public List<Bolum> Bolumler { get; set; }


    }
}




    

