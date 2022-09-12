namespace HOW.Models.Interfaces
{
    public interface IHelperRepository
    {
        public int AddHelper(Helper h);
        public List<Helper> GetHelpers();
        public bool ValidateHelper(Login l);
        public string ValidateEmail(String email);
    }
}
