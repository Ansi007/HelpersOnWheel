namespace HOW.Models
{
    public class AnswerRepository
    {
        public int AddAnswer(string email, string title, Answer answer)
        {
            var context = new HelpersOnWheelContext();
            foreach(var q in context.Questions)
            {
                if(q.AuthorEmail == email && q.Title == title)
                {
                    q.Answers.Add(answer);
                    break;
                }
            }
            return context.SaveChanges();
        }

        public List<Answer> GetAnswers(string email, string title)
        {
            var context = new HelpersOnWheelContext();
            int postId = -1;
            List<Answer> answers = new List<Answer>();
            foreach(var q in context.Questions)
            {
                if(q.AuthorEmail == email && q.Title == title)
                {
                    postId = q.Id;
                    break;
                }
            }
            if(postId != -1)
            {
                foreach(var a in context.Answers)
                {
                    if(a.PostId == postId)
                    {
                        answers.Add(a);
                    }
                }
            }
            return answers;
        }
    }
}
