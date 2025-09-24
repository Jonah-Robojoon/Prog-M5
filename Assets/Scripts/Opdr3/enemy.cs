using UnityEngine;

public class enemy : MonoBehaviour
{
    void Update()
    {
        Vector3 pos = transform.position;
        pos.z += 1f * Time.deltaTime;
        transform.position = pos;
    }
}
