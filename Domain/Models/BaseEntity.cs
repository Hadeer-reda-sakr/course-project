using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public abstract class BaseEntity
    {

        // Commn properties shard at all classes

        [Key]
        public int Id { get; set; }


        /* ---   created properties*/

        [DataType(DataType.Date)]
        public DateTime? CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public int CreatedBy { get; set; }

       
        //public int CreatedByRole { get; set; }

        /* ---   modified properties*/


        [DataType(DataType.Date)]
        public DateTime? ModifiedAt { get; set; } = DateTime.Now;

        public int? ModifiedBy { get; set; }

        //public int? ModifiedByRole { get; set; }

        /*--Is Active property --*/

        public bool IsActive { get; set; } = true;

    }
}
