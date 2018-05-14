using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionQuizz.Models.DB
{
    public class DBService : DbContext
    {
        public DbSet<YesNoQuestion> YesNoQuestion { get; set; }
        public DbSet<ThreeChoiceQuestionTable> ThreeChoiceQuestionTable { get; set; }

        private static string CONNECTION_STRING = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuestionAnwserDatabase;Integrated Security=True";

        public List<YesNoQuestion> GetAllYesNoQuestions()
        {
            return YesNoQuestion.ToList();
        }
        public List<ThreeChoiceQuestion> GetAllThreeChoiceQuestions()
        {
            var result = new List<ThreeChoiceQuestion>();

            for (int i = 0; i < ThreeChoiceQuestionTable.ToList().Count; i++)
            {
                var element = ThreeChoiceQuestionTable.ToList()[i];
                result.Add(new ThreeChoiceQuestion(element));
            }

            return result;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION_STRING);
        }
    }
}
