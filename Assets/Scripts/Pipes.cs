using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{

    private void FixedUpdate()
    {
        if (GameManager.instance.isGameRunning)
        {
            transform.position += (Vector3.left * GameManager.instance.gameSpeed * Time.deltaTime);
        }
        
    }
}
