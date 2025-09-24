using UnityEngine;

public class Tower : MonoBehaviour
{
    void Start()
    {
        float randomScale = Random.Range(0.5f, 5f);


        transform.localScale = new Vector3(randomScale, randomScale, randomScale);

        transform.position = new Vector3(Random.Range(-10f, 10f), transform.position.y, Random.Range(-10f, 10f));
    }
}
