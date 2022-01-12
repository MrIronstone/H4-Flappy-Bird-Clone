using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    [SerializeField] private GameObject pipes;
    [SerializeField] private GameObject floor;
    [SerializeField] private float yposition;



    private void Update()
    {
        if((timer > maxTime) && (GameManager.instance.isGameRunning))
        {
            GameObject newlySpawnedPipe = Instantiate(pipes);

            Vector3 randomHeight = new Vector3(0, Random.Range(-yposition, yposition));

            newlySpawnedPipe.transform.position = transform.position + randomHeight;
            Destroy(newlySpawnedPipe, 10);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}

