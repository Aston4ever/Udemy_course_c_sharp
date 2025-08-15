namespace Quize;

public class Question
{
    public string QuestionText { get; set; }
    public string[] Answers { get; set; }
    public int CorectAnswerIndex { get; set; }

    public Question(string questiontext, string[] answers, int corectAnswerIndex)
    {
        questiontext =  questiontext;
        Answers = answers;
        CorectAnswerIndex = corectAnswerIndex;
    }

    public bool IsCorrect(int userChoice)
    {
        return userChoice == CorectAnswerIndex;
    }
    
}