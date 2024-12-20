using DG.Tweening;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField] private Sprite spriteSymbol;
    [SerializeField] private SpriteRenderer spriteRenderer;

    private Tweener tween;
    private Sequence sequence;
    public void SetSymbol(Sprite spritesymbol)
    {       
        spriteSymbol = spritesymbol;
        spriteRenderer.sprite = spriteSymbol;
        SpawnAnim();
    }
    public void ReSetSymbol(Sprite spritesymbol)
    {
        spriteSymbol = spritesymbol;
        spriteRenderer.sprite = spriteSymbol;
    }
    public Sprite GetSymbol()
    {
        return spriteSymbol;
    }
    public void SpawnAnim()
    {
        sequence = DOTween.Sequence();

        sequence.Append(transform.DOScale(0.5f, 0.3f).SetEase(Ease.InOutBounce));
        sequence.Append(transform.DOScale(0.3f, 0.3f).SetEase(Ease.InOutBounce));
        sequence.Append(transform.DOScale(0.4f, 0.3f).SetEase(Ease.InOutBounce));
    }
    public void PlayCorrectAnimation()
    {
        sequence.Kill(true);
        sequence = DOTween.Sequence();

        sequence.Append(spriteRenderer.transform.DOScale(0.5f, 0.2f).SetEase(Ease.InOutBounce));
        sequence.Append(spriteRenderer.transform.DOScale(0.3f, 0.2f).SetEase(Ease.InOutBounce));
        sequence.Append(spriteRenderer.transform.DOScale(0.4f, 0.2f).SetEase(Ease.InOutBounce));
    }
    public void PlayWrongAnimation()
    {
        tween.Kill(true);
        tween = spriteRenderer.transform.DOShakePosition(0.5f, strength: new Vector3(0.2f, 0, 0), vibrato: 10, randomness: 90, fadeOut: true);
    }
}
