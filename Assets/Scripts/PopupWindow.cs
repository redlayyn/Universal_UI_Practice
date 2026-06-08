using UnityEngine;
using DG.Tweening; 

public class PopupWindow : MonoBehaviour
{
    private void OnEnable()
    {
        transform.localScale = Vector3.zero;

        transform.DOScale(1f, 0.4f).SetEase(Ease.OutBack).SetUpdate(true);
    }

    public void CloseWindow()
    {
        transform.DOScale(0f, 0.3f).SetEase(Ease.InBack).OnComplete(() => {
            gameObject.SetActive(false);
        }).SetUpdate(true);
    }
}
