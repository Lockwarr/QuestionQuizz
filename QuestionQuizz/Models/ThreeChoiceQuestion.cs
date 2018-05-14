using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionQuizz.Models
{
    public class ThreeChoiceQuestion
    {
        public string Statement { get; set; }
        public List<string> Choices { get; set; }
        public int CorrectAnwserIndex { get; set; }

        public ThreeChoiceQuestion(ThreeChoiceQuestionTable table)
        {
            Statement = table.Statement;
            Choices = table.Choices.Split(',').ToList();
            CorrectAnwserIndex = table.CorrectAnwserIndex;
        }
    }
}
