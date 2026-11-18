using UnityEngine;

public class BrickSpawner : MonoBehaviour
{
  public GameObject brickPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int row = 0; row < 6; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                float x = -5.5f + col * 1.6f;
                float y = 3.5f - row * 0.8f;

                Instantiate(brickPrefab, new Vector3(x, y, 0), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
