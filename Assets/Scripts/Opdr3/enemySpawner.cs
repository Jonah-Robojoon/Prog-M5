using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(enemyPrefab);
        }
    }
}
