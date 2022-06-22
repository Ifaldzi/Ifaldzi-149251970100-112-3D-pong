using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public List<Transform> spawnPoints;
    public GameObject ballObject;

    public GameObject poolingObjectParent;
    public List<GameObject> pooledObjects;
    public int maxBall;

    private int ballCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < maxBall; i++)
        {
            GameObject temp = Instantiate(ballObject, poolingObjectParent.transform, poolingObjectParent);
            temp.SetActive(false);
            pooledObjects.Add(temp);
        }

        SpawnRandomBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private GameObject GetPooledObject()
    {
        foreach (GameObject pooledObject in pooledObjects)
        {
            if (!pooledObject.activeInHierarchy)
            {
                return pooledObject;
            }
        }

        return null;
    }

    private void SpawnRandomBall()
    {
        int randomIndex = Random.Range(0, spawnPoints.Capacity);
        Transform spawnPoint = spawnPoints[randomIndex];
        SpawnRandomBall(spawnPoint.position);
    }

    private void SpawnRandomBall(Vector3 position)
    {
        if (ballCount >= maxBall)
        {
            return;
        }

        GameObject ball = GetPooledObject();

        if (ball == null)
        {
            return;
        }

        Vector3 direction = position.normalized;

        ball.transform.position = position;
        ball.GetComponent<BallController>().direction = - new Vector3(direction.x, 0, direction.z);
        ball.SetActive(true);

        ballCount++;
    }
}
