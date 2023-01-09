using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiateBrickWall : MonoBehaviour
{
    public GameObject brickPrefab;
    // Start is called before the first frame update
    void Start()
    {
        // Instantiate a wall of bricks
        for (int j = 0; j < 8; j++)
        {
            for (int i = -5; i < 7; i++)
            {
                // Create a new brick at the desired position and rotation
                GameObject brick = Instantiate(brickPrefab, new Vector3(i * 1, j * 1, -3), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
