using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionQuizz.Models
{
    public class YesNoQuestion
    {
        [Key]
        public int Id { get; set; }
        public string Statement { get; set; }
        public string Author { get; set; }
        public bool IsTrue { get; set; }

        public YesNoQuestion()  { }
    }

}
