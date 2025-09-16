using UnityEngine;

public class CreateBallScript : MonoBehaviour
{
    public GameObject prefab;
    private float elapsedTime = 0f;
    void Update()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color randColor = new Color(r, g, b, 1f);

        elapsedTime += Time.deltaTime;

        Vector3 randomPos = new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));

        if (elapsedTime > 1f)
        {
            CreateBall(randColor, randomPos);
            elapsedTime = 0f;
        }

    }

    private void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            float r = Random.Range(0f, 1f);
            float g = Random.Range(0f, 1f);
            float b = Random.Range(0f, 1f);
            Color randColor = new Color(r, g, b, 1f);

            Vector3 randomPos = new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));
            CreateBall(randColor, randomPos);   
        }
    }


    private GameObject CreateBall(Color c, Vector3 position)
    {

        GameObject ball = Instantiate(prefab, position, Quaternion.identity);
        Material material = ball.GetComponent<MeshRenderer>().material;

        // voor CORE pipeline
        material.SetColor("_Color", c);

        //Voor URP
        if (material.shader.name == "Universal Render Pipeline/Lit")
        {
            material.SetColor("_BaseColor", c);
        }

        DestoyBall(ball);
        return ball;

    }



    private GameObject DestoyBall(GameObject ball)
    {
        Destroy(ball, 3f);
        return null;
    }
}
