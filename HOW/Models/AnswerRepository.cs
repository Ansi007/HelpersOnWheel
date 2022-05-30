namespace HOW.Models
{
    public class AnswerRepository
    {
        public int AddAnswer(Answer answer)
        {
            var context = new HelpersOnWheelContext();
            context.Answers.Add(answer);
            return context.SaveChanges();
        }
    }
}
