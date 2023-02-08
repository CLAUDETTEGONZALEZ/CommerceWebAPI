namespace Logic.ILogic
{
    public interface ISecurityLogic
    {
        bool ValidateUserCredentials(string userName, string userPassWord, int idRol);
    }
}
