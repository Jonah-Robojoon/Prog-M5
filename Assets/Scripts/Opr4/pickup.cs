using UnityEngine;
using System;

public class pickup : MonoBehaviour
{
    public static event Action<int> OnPickup; //Definitie van een Action Event
    [SerializeField] private int scoreValue = 50; //Punten waarde van de pickup

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Picked up!");
            OnPickup?.Invoke(scoreValue);
            Destroy(gameObject);

        }
    }
}
