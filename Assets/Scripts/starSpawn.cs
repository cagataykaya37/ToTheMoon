using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starSpawn : MonoBehaviour
{
    bool spawnYes = true;
    Vector3 spawnStarVector;
    int random;
    int randomStarName;

    public GameObject star1;
    public GameObject star2;
    public GameObject parentSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        randomStarName = Random.Range(1, 3);
        if (randomStarName == 1 && spawnYes)
        {
            starSpawnPosition();
            Instantiate(star1, spawnStarVector, new Quaternion(0, 0, 0, 0));
            StartCoroutine(starSpawnDelay());
        }
        else if (randomStarName == 2 && spawnYes)
        {
            starSpawnPosition();
            Instantiate(star2, spawnStarVector, new Quaternion(0, 0, 0, 0));
            StartCoroutine(starSpawnDelay());
        }

    }

    IEnumerator starSpawnDelay()
    {
        spawnYes = false;
        yield return new WaitForSeconds(2f);
        spawnYes = true;
    }

    public void starSpawnPosition()
    {
        random = Random.Range(-7, 8);
        spawnStarVector = new Vector3(random, transform.parent.position.y, -0.5f);
    }

}
