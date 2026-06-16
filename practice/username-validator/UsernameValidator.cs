public class UsernameValidator
{
    public static void UsernameLengthValidator (string username)
    {
        if (username.Length < 3)
        {
            throw new InvalidUsernameException ($"[USER-{username}] INVALID USERNAME LENGTH DETECTED: Username contains less than 3 characters.", username);
        }
        else if (username.Length > 15)
        {
            throw new InvalidUsernameException ($"[USER-{username}] INVALID USERNAME LENGTH DETECTED: Username contains more than 15 characters.", username);
        }
    }
    public static void UsernameCharacterValidator (string username)
    {
        if (username.Contains(' '))
        {
            throw new InvalidUsernameException ($"[USER-{username}] INVALID USERNAME CHARACTER DETECTED: Username contains whitespace.", username);
        }
    }
    
}