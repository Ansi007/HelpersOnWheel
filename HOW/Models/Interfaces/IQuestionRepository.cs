namespace HOW.Models.Interfaces
{
    public interface IQuestionRepository
    {
        public int AddQuestion(Question question);
        public int UpdateQuestion(Question question);
        public int DeleteQuestion(Question q);
        public List<Question> GetQuestions();
        public List<Question> GetQuestions(string Email);
        public List<Question> SearchQuesions(string name, string title);

    }
}
