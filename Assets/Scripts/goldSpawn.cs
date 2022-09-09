using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class goldSpawn : MonoBehaviour
{
    public GameObject gem;
    public GameObject gold;
    public GameObject ruby;
    public GameObject copium;
    public GameObject lapis;
    public GameObject x2speed;
    public GameObject x2gold;

    public GameObject parentSpawn;
    public GameObject rocketPlayer;

    static int random;
    static int randomGoldName;

    public TMP_Text layerName;
    public TMP_Text layerMeter;

    string randomGoldString;

    Vector3 spawnGoldVector;
    Quaternion spawnRotateVector;

    public int rocketMeter;

    bool spawnYes = true;

    bool level2Audio = true;
    bool level3Audio = true;
    bool level4Audio = true;
    bool level5Audio = true;
    bool level6Audio = true;
    bool level7Audio = true;
    bool level8Audio = true;
    bool level9Audio = true;
    bool level10Audio = true;

    // Start is called before the first frame update
    void Start()
    {
        spawnRotateVector = new Quaternion(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        rocketMeter = (int)rocketPlayer.transform.position.y;

        if (rocketMeter < 100)
        {
            layerMeter.text = "Next Space Layer: " + (100 - rocketMeter) + " sM";
            layerName.text = "Space Layer: Atmosphere";

            if (spawnYes == true)
            {
                randomGoldName = Random.Range(1, 13);
                switch (randomGoldName)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        goldSpawnPosition();

                        Instantiate(gold, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 10:
                        goldSpawnPosition();

                        Instantiate(gem, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 11:
                        goldSpawnPosition();

                        Instantiate(x2gold, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 12:
                        goldSpawnPosition();

                        Instantiate(x2speed, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;
                }

            }

        }

        else if (rocketMeter < 250)
        {
            layerMeter.text = "Next Space Layer: " + (250 - rocketMeter) + " sM";
            layerName.text = "Space Layer: Bitbisphere";

            if (level2Audio)
            {
                level2Audio = false;
                audioManage.PlaySound("NewLayer");
            }

            if (spawnYes == true)
            {
                randomGoldName = Random.Range(1, 13);
                switch (randomGoldName)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                        goldSpawnPosition();

                        Instantiate(gold, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 9:
                    case 10:
                        goldSpawnPosition();

                        Instantiate(gem, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 11:
                        goldSpawnPosition();

                        Instantiate(x2gold, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 12:
                        goldSpawnPosition();

                        Instantiate(x2speed, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;
                }

            }
        }

        else if (rocketMeter < 500)
        {
            layerMeter.text = "Next Space Layer: " + (500 - rocketMeter) + " sM";
            layerName.text = "Space Layer: Qunisphere";

            if (level3Audio)
            {
                level3Audio = false;
                audioManage.PlaySound("NewLayer");
            }

            if (spawnYes == true)
            {
                randomGoldName = Random.Range(1, 13);
                switch (randomGoldName)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                        goldSpawnPosition();

                        Instantiate(gold, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 7:
                    case 8:
                    case 9:
                        goldSpawnPosition();

                        Instantiate(gem, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 10:
                        goldSpawnPosition();

                        Instantiate(copium, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 11:
                        goldSpawnPosition();

                        Instantiate(x2gold, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 12:
                        goldSpawnPosition();

                        Instantiate(x2speed, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;
                }

            }
        }

        else if (rocketMeter < 800)
        {
            layerMeter.text = "Next Space Layer: " + (800 - rocketMeter) + " sM";
            layerName.text = "Space Layer: Dethratosphere";

            if (level4Audio)
            {
                level4Audio = false;
                audioManage.PlaySound("NewLayer");
            }

            if (spawnYes == true)
            {
                randomGoldName = Random.Range(1, 13);
                switch (randomGoldName)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        goldSpawnPosition();

                        Instantiate(gold, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 5:
                    case 6:
                    case 7:
                    case 8:
                        goldSpawnPosition();

                        Instantiate(gem, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 9:
                    case 10:
                        goldSpawnPosition();

                        Instantiate(copium, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 11:
                        goldSpawnPosition();

                        Instantiate(x2gold, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 12:
                        goldSpawnPosition();

                        Instantiate(x2speed, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;
                }

            }

        }

        else if (rocketMeter < 1200)
        {
            layerMeter.text = "Next Space Layer: " + (1200 - rocketMeter) + " sM";
            layerName.text = "Space Layer: Morbio";

            if (level5Audio)
            {
                level5Audio = false;
                audioManage.PlaySound("NewLayer");
            }

            if (spawnYes == true)
            {
                randomGoldName = Random.Range(1, 13);
                switch (randomGoldName)
                {
                    case 1:
                    case 2:
                    case 3:
                        goldSpawnPosition();

                        Instantiate(gold, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 4:
                    case 5:
                    case 6:
                        goldSpawnPosition();

                        Instantiate(gem, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 7:
                    case 8:
                    case 9:
                        goldSpawnPosition();

                        Instantiate(copium, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 10:
                        goldSpawnPosition();

                        Instantiate(lapis, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 11:
                        goldSpawnPosition();

                        Instantiate(x2gold, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 12:
                        goldSpawnPosition();

                        Instantiate(x2speed, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;
                }

            }

        }

        else if (rocketMeter < 1700)
        {
            layerMeter.text = "Next Space Layer: " + (1700 - rocketMeter) + " sM";
            layerName.text = "Space Layer: Fartasphere";

            if (level6Audio)
            {
                level6Audio = false;
                audioManage.PlaySound("NewLayer");
            }

            if (spawnYes == true)
            {
                randomGoldName = Random.Range(1, 13);
                switch (randomGoldName)
                {
                    case 1:
                    case 2:
                        goldSpawnPosition();

                        Instantiate(gold, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 3:
                    case 4:
                    case 5:
                        goldSpawnPosition();

                        Instantiate(gem, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 6:
                    case 7:
                    case 8:
                        goldSpawnPosition();

                        Instantiate(copium, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 9:
                    case 10:
                        goldSpawnPosition();

                        Instantiate(lapis, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 11:
                        goldSpawnPosition();

                        Instantiate(x2gold, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 12:
                        goldSpawnPosition();

                        Instantiate(x2speed, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;
                }

            }

        }

        else if (rocketMeter < 2400)
        {
            layerMeter.text = "Next Space Layer: " + (2400 - rocketMeter) + " sM";
            layerName.text = "Space Layer: ????";

            if (level7Audio)
            {
                level7Audio = false;
                audioManage.PlaySound("NewLayer");
            }

            if (spawnYes == true)
            {
                randomGoldName = Random.Range(1, 13);
                switch (randomGoldName)
                {
                    case 1:
                        goldSpawnPosition();

                        Instantiate(gold, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 2:
                    case 3:
                        goldSpawnPosition();

                        Instantiate(gem, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 4:
                    case 5:
                    case 6:
                        goldSpawnPosition();

                        Instantiate(copium, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 7:
                    case 8:
                    case 9:
                        goldSpawnPosition();

                        Instantiate(lapis, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 10:
                        goldSpawnPosition();

                        Instantiate(ruby, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 11:
                        goldSpawnPosition();

                        Instantiate(x2gold, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 12:
                        goldSpawnPosition();

                        Instantiate(x2speed, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;
                }

            }

        }

        else if (rocketMeter < 3200)
        {
            layerMeter.text = "Next Space Layer: " + (3200 - rocketMeter) + " sM";
            layerName.text = "Space Layer: Hitrasphere";

            if (level8Audio)
            {
                level8Audio = false;
                audioManage.PlaySound("NewLayer");
            }

            if (spawnYes == true)
            {
                randomGoldName = Random.Range(1, 13);
                switch (randomGoldName)
                {
                    case 1:
                        goldSpawnPosition();

                        Instantiate(gold, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 2:
                        goldSpawnPosition();

                        Instantiate(gem, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 3:
                    case 4:
                    case 5:
                        goldSpawnPosition();

                        Instantiate(copium, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 6:
                    case 7:
                    case 8:
                        goldSpawnPosition();

                        Instantiate(lapis, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 9:
                    case 10:
                        goldSpawnPosition();

                        Instantiate(ruby, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 11:
                        goldSpawnPosition();

                        Instantiate(x2gold, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 12:
                        goldSpawnPosition();

                        Instantiate(x2speed, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;
                }

            }

        }

        else if (rocketMeter < 4000)
        {
            layerMeter.text = "Next Space Layer: " + (4000 - rocketMeter) + " sM";
            layerName.text = "Space Layer: Innosphere";

            if (level9Audio)
            {
                level9Audio = false;
                audioManage.PlaySound("NewLayer");
            }

            if (spawnYes == true)
            {
                randomGoldName = Random.Range(1, 13);
                switch (randomGoldName)
                {
                    case 1:
                        goldSpawnPosition();

                        Instantiate(gold, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 2:
                        goldSpawnPosition();

                        Instantiate(gem, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 3:
                    case 4:
                        goldSpawnPosition();

                        Instantiate(copium, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 5:
                    case 6:
                    case 7:
                        goldSpawnPosition();

                        Instantiate(lapis, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 8:
                    case 9:
                    case 10:
                        goldSpawnPosition();

                        Instantiate(ruby, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 11:
                        goldSpawnPosition();

                        Instantiate(x2gold, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 12:
                        goldSpawnPosition();

                        Instantiate(x2speed, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;
                }

            }

        }

        else if (rocketMeter < 5000)
        {
            layerMeter.text = "Next Space Layer: " + (5000 - rocketMeter) + " sM";
            layerName.text = "Space Layer: Atrotosphere";

            if (level10Audio)
            {
                level10Audio = false;
                audioManage.PlaySound("NewLayer");
            }

            if (spawnYes == true)
            {
                randomGoldName = Random.Range(1, 13);
                switch (randomGoldName)
                {
                    case 1:
                        goldSpawnPosition();

                        Instantiate(gold, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 2:
                        goldSpawnPosition();

                        Instantiate(gem, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 3:
                        goldSpawnPosition();

                        Instantiate(copium, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 4:
                    case 5:
                    case 6:
                        goldSpawnPosition();

                        Instantiate(lapis, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        goldSpawnPosition();

                        Instantiate(ruby, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 11:
                        goldSpawnPosition();

                        Instantiate(x2gold, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;

                    case 12:
                        goldSpawnPosition();

                        Instantiate(x2speed, spawnGoldVector, spawnRotateVector);
                        StartCoroutine(goldSpawnDelay());
                        break;
                }

            }

        }
        else if (rocketMeter >= 5000)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("EndScene");
        }

        
    }

    IEnumerator goldSpawnDelay()
    {
        spawnYes = false;
        yield return new WaitForSeconds(0.16f);
        spawnYes = true;
    }


    public void goldSpawnPosition()
    {
        random = Random.Range(-7, 8);
        spawnGoldVector = new Vector3(random, transform.parent.position.y, 0);
    }

}


