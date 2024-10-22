namespace QuizWebAppCore.Models;
     
public class Question
    {
        public int QuestionId { get; set; }
        public string Question1 { get; set; }
        public string Answer { get; set; }
        public int RoundId { get; set; }
        public bool Status { get; set; }
        public string QuestionNo { get; set; }
        public string QuestionPath { get; set; }
        public string IsPicture { get; set; }
    }

