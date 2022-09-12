using HOW.Models.Interfaces;
namespace HOW.Models
{
    public class QuestionRepository : IQuestionRepository
    {
        public int AddQuestion(Question question)
        {
            var context = new HelpersOnWheelContext();
            context.Questions.Add(question);
            return context.SaveChanges();
        }

        public int UpdateQuestion(Question question)
        {
            var context = new HelpersOnWheelContext();
            Question q = context.Questions.Find(question);
            q = question;
            return context.SaveChanges();
        }

        public int DeleteQuestion(Question q)
        {
            var context = new HelpersOnWheelContext();
            foreach (var a in context.Questions)
            {
                if (a.Title == q.Title)
                {
                    context.Questions.Remove(a);
                }
            }
            return context.SaveChanges();
        }

        public List<Question> GetQuestions()
        {
            return new HelpersOnWheelContext().Questions.ToList();
        }
        public List<Question> GetQuestions(string Email)
        {
            var context = new HelpersOnWheelContext();
            return context.Questions.Select(q => q).Where(q => q.AuthorEmail == Email).ToList();
        }

        public List<Question> SearchQuesions(string name, string title)
        {
            if (name == null) name = "";
            if (title == null) title = "";
            var context = new HelpersOnWheelContext();
            List<Question> question = new List<Question>();
            foreach (var q in context.Questions)
            {
                if(q.AuthorEmail.Contains(name) && q.Title.Contains(title))
                {
                    question.Add(q);
                }
            }
            return question;
        }
    }
}
