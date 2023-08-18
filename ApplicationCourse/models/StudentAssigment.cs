using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.models
{
    public class StudentAssigment :BaseEntity
    {
        // class StudentAssigment properties


        [Range(0, 4, ErrorMessage = "please enter number from 0 to 4")]
        
        public int Evaluation { get; set; }


       
        public string Solution { get; set; }


        public string Comment { get; set; }

        
        public int AssigmentId { get; set; }


        public int StudentId { get; set; }



        //Navigation Property

        public ApplicationUser Students { get; set; }
        public Assigment Assigment { get; set; }



    }
}
