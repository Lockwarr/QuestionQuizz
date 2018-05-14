using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionQuizz.Models
{
    //Mapping to DB table
    [Table("ThreeChoiceQuestion")]
    public class ThreeChoiceQuestionTable
    {
        [Key]
        public int Id { get; set; }
        public string Statement { get; set; }
        public string Choices { get; set; }
        public int CorrectAnwserIndex { get; set; }


        public ThreeChoiceQuestionTable() { }
    }
}
