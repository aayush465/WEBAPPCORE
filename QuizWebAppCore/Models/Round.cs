namespace QuizWebAppCore.Models;

public class Round
{
    public int RoundId { get; set; }
    public string RoundName { get; set; }
    public string RoundNameNp { get; set; }
    public string RoundDescription { get; set; }
    public int Status { get; set; }
    public int RoundSequenceOrder { get; set; }
}
