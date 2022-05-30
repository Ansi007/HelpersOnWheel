namespace HOW.Models
{
    public class QuestionRepository
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

        public int DeleteQuestion(Question question)
        {
            return 0;
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
    }
}
