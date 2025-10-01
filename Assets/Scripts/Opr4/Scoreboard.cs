using TMPro;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    private int score = 0;
    private TMP_Text textField;
    void Start()
    {
        textField = GetComponent<TMP_Text>();
        pickup.OnPickup += GetPickupPoints;   //We "abboneren" ons op het Action Event
    }
    private void GetPickupPoints(int customPoints)
    {              //Als het bericht binnenkomt dat de enemy dood is voeren we de functie uit
        score += customPoints;
        textField.text = "score: " + score;
    }
}
