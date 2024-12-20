using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class NextLvlBtnAnimation : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Button button;
    [SerializeField] private Image buttonImg;
    [SerializeField] private Image buttonIcon;    
    private void Start()
    {
        button.interactable = false;
        buttonImg.DOFade(0f, 0).SetEase(Ease.InOutQuad);
        buttonIcon.DOFade(0f, 0).SetEase(Ease.InOutQuad);
    }
    public void PlayFadeIn()
    {
        button.interactable = true;
        buttonImg.DOFade(1f, 0.5f).SetEase(Ease.InOutQuad);
        buttonIcon.DOFade(1f, 0.5f).SetEase(Ease.InOutQuad);
    }
    public void PlayFadeOut()
    {
        button.interactable = false;
        buttonImg.DOFade(0f, 0.5f).SetEase(Ease.InOutQuad);
        buttonIcon.DOFade(0f, 0.5f).SetEase(Ease.InOutQuad);
    }
}