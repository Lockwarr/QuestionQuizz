using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuestionQuizz.Models;
using QuestionQuizz.Models.DB;

namespace QuestionQuizz.Controllers
{
    public class HomeController : Controller
    {
        public static DBService dbService = new DBService();

        public IActionResult Index(int questionIndex)
        {
            List<YesNoQuestion> model = dbService.GetAllYesNoQuestions();
            if (questionIndex < model.Count)
            {
                ViewData["questionIndex"] = questionIndex + 1;
            }
            else
            {
                questionIndex = 1;
            }
            return View(model[questionIndex]);
        }

        public IActionResult ThreeChoices(int questionIndex)
        {

            List<ThreeChoiceQuestion> model = dbService.GetAllThreeChoiceQuestions();
            if (questionIndex < model.Count)
            {
                ViewData["questionIndex"] = questionIndex + 1;
            }
            else
            {
                questionIndex = 1;
            }
            return View(model[questionIndex]);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
