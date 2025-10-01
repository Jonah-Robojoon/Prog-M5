using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float moveSpeed = 5f;
        float rotateSpeed = 100f;

        float moveInput = Input.GetAxis("Vertical"); // W/S or Up/Down
        transform.Translate(Vector3.forward * moveInput * moveSpeed * Time.deltaTime);

        float rotateInput = Input.GetAxis("Horizontal"); // A/D or Left/Right
        transform.Rotate(Vector3.up, rotateInput * rotateSpeed * Time.deltaTime);
    }
}
