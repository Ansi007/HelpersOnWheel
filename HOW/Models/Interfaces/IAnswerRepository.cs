namespace HOW.Models.Interfaces
{
    public interface IAnswerRepository
    {
        public int AddAnswer(string email, string title, Answer answer);

        public List<Answer> GetAnswers(string email, string title);
    }
}
