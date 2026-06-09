using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    [Header("HUD Ёлементы")]
    [SerializeField] private Slider hpSlider;
    [SerializeField] private TextMeshProUGUI coinsText;

    private float currentHP = 100f;
    private float maxHP = 100f;
    private int currentCoins = 100;

    private void Start()
    {
        Time.timeScale = 1f;
        UpdateUI();
    }

    public void ChangeHP(float amount)
    {
        currentHP += amount;
        currentHP = Mathf.Clamp(currentHP, 0f, maxHP);

        hpSlider.DOValue(currentHP / maxHP, 0.3f);
    }

    public void AddCoins(int amount)
    {
        currentCoins += amount;
        if (currentCoins < 0) currentCoins = 0;
        UpdateUI();
    }

    private void UpdateUI()
    {
        coinsText.text = currentCoins.ToString();
    }
}
