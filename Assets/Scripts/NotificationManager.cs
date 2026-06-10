using UnityEngine;
using TMPro;
using DG.Tweening;

public class NotificationManager : MonoBehaviour
{
    [Header("Элементы Уведомления")]
    [SerializeField] private GameObject notificationPanel;
    [SerializeField] private TextMeshProUGUI descriptionText;

    [Header("Настройки")]
    [SerializeField] private float showInterval = 7f;
    [SerializeField] private float duration = 3f;

    [ContextMenu("Test Notification")]
    private void Start()
    {
        notificationPanel.transform.localScale = Vector3.zero;
        notificationPanel.SetActive(false);

        InvokeRepeating(nameof(TriggerNotification), 2f, showInterval);
    }

    private void TriggerNotification()
    {
        string fullText = "Высокая активность кристаллов";

        if (fullText.Length > 40)
        {
            descriptionText.text = fullText.Substring(0, 40) + "...";
        }
        else
        {
            descriptionText.text = fullText;
        }

        notificationPanel.SetActive(true);
        notificationPanel.transform.DOScale(1f, 0.4f).SetEase(Ease.OutBack);

        DOVirtual.DelayedCall(duration, () => {
            notificationPanel.transform.DOScale(0f, 0.3f).SetEase(Ease.InBack).OnComplete(() => {
                notificationPanel.SetActive(false);
            });
        });
    }
}
