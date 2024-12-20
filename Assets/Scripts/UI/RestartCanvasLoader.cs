using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
public class RestartCanvasLoader : MonoBehaviour
{
    [SerializeField] private Image PanelImg;
    [SerializeField] private Image RestartBtnImg;
    [SerializeField] private Image RestartBtnIconImg;

    [SerializeField] private Button RestartBtn;
    [SerializeField] private ClickRegistrar clickregistr;
    [SerializeField] private GameRestarter gameRestarter;

    public void RestartCanvasload()
    {
        RestartBtn.interactable = true;        
        PanelImg.raycastTarget = true;

        PanelImg.DOFade(0.5f, 2).SetEase(Ease.InOutQuad);
        RestartBtnImg.DOFade(1f, 2).SetEase(Ease.InOutQuad);
        RestartBtnIconImg.DOFade(1f, 2).SetEase(Ease.InOutQuad);

        clickregistr.BlockMouse();
    }
    public void RestartGame()
    {
        RestartBtn.interactable = false;

        RestartBtnImg.DOKill();
        RestartBtnIconImg.DOKill();

        RestartBtnImg.DOFade(0f, 1).SetEase(Ease.InOutQuad);
        RestartBtnIconImg.DOFade(0f, 1).SetEase(Ease.InOutQuad);
        PanelImg.DOFade(1f, 3).SetEase(Ease.InOutQuad).OnComplete(() => 
        {
            gameRestarter.RestartScene();
        }
        );        
    }
}
