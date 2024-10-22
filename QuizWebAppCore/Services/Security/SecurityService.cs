namespace QuizWebAppCore.Services.Security;

public class SecurityService: ISecurityService
{
    public Boolean CheckSession(object id)
    {
        if (id == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
