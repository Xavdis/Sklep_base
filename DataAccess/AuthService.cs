namespace Sklep_base.DataAccess
{
    public class AuthService
    {
        private readonly SQLFunctions _sqlFunctions;
        public AuthService()
        {
            _sqlFunctions = new SQLFunctions();
        }

        public bool Login(string username, string password)
        {
            return _sqlFunctions.ValidateUser(username, password);
        }

        public bool Register(string username, string password)
        {
            if (_sqlFunctions.IsUserExists(username) == true)
                return false;
            else
            {
                _sqlFunctions.CreateUser(username, password);
                return true;
            }
        }
    }
}
