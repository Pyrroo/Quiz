using UnityEngine;

public class AnswerChecker : MonoBehaviour
{
    private Sprite correctAnswer;
    [SerializeField] private NextLvlBtnAnimation btnAnimation;
    [SerializeField] private ParticleStarter particleStarter;
    public void Check(Cell answer)
    {
        if (answer.GetSymbol() == correctAnswer)
        {
            answer.PlayCorrectAnimation();
            particleStarter.PlayParticles(answer.GetComponent<Transform>());
            btnAnimation.PlayFadeIn();
        }
        else
        {
            answer.PlayWrongAnimation();
        }
    }
    public void SetAnswer(Sprite answer)
    {
        correctAnswer = answer;        
    }
}
