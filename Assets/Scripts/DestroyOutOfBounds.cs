using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    private float sideBound = 30.0f;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            // Do dùng ObjectPooler nên không cần hủy thức ăn bắn ra mà 
            // chỉ cần ẩn đi để tái sử dụng lại các Object có sẵn trong ObjectPooler.
            // Destroy(gameObject);
            gameObject.SetActive(false);
        }
        else if (transform.position.z < lowerBound)
        {
            // Debug.Log("Game Over!");
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x > sideBound)
        {
            // Debug.Log("Game Over!");
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x < -sideBound)
        {
            // Debug.Log("Game Over!");
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
