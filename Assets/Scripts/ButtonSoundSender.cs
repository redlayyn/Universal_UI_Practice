using UnityEngine;
using UnityEngine.UI;

public class ButtonSoundSender : MonoBehaviour
{
    [Header("Конкретный звук для этой кнопки")]
    [SerializeField] private AudioClip concreteSound;
    private void Start()
    {
        Button currentButton = GetComponent<Button>();

        if (currentButton != null && concreteSound != null)
        {
            currentButton.onClick.AddListener(SendToAudioManager);
        }
    }

    private void SendToAudioManager()
    {
        if (AudioManager.instance != null)
        {
            AudioManager.instance.PlaySound(concreteSound);
        }
        else
        {
            Debug.LogWarning("AudioManager не найден на сцене! Проверь, создан ли объект AudioManagerObject.");
        }
    }
}
