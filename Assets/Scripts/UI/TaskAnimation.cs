using DG.Tweening;
using TMPro;
using UnityEngine;

public class TaskAnimation : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI tmpText;
    [SerializeField] private float duration = 2f;

    private void Start()
    {
            var color = tmpText.color;
            color.a = 0;
            tmpText.color = color;
            tmpText.DOFade(1f, duration).SetEase(Ease.InOutQuad);        
    }
}
