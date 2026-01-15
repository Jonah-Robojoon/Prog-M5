using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointScript : MonoBehaviour
{
    private int _points = 0;
    private TextMeshProUGUI _scoreText;

    void Start()
    {
        CollectorScript.CoinCollected += OnCollect;
        _scoreText = GetComponent<TextMeshProUGUI>();
    }
    void OnDisable()
    {
        CollectorScript.CoinCollected -= OnCollect;

    }
    void OnCollect(int score)
    {
        _points += score;
        _scoreText.text = "Score: " + _points + "     " + score;
    }
}
