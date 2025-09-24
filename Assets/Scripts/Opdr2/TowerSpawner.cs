using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject towerPrefab; 

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(towerPrefab);
        }
    }
}
