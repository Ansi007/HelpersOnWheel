namespace HOW.Models.Interfaces
{
    public interface ISeekerRepository
    {
        public int AddSeeker(Seeker s);
        public List<Seeker> GetSeekers();
        public bool ValidateSeeker(Login l);
        public string ValidateEmail(String email);
    }
}
