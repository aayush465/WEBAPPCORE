using System.ComponentModel.DataAnnotations.Schema;

namespace QuizWebAppCore.Models;

[Table("Users")]
public class User
{
    public int UserId { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public string UserType { get; set; }
}
