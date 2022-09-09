using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class moveRocket : MonoBehaviour
{
    Vector3 moveRocketVector;

    static float gameSpeed = 0.01f;
    public float gameSpeedVector = 0;
    static float cameraSize = 5;

    public TMP_Text rocketLevelText;
    public TMP_Text radarLevelText;
    public TMP_Text toMoonText;
    public TMP_Text coinText;
    public TMP_Text radarGoldNeed;
    public TMP_Text rocketGoldNeed;

    public GameObject x2YellowGoldText;
    public GameObject x2YellowSpeedText;

    public int rocketLevel = 1;
    public int radarUpgradeCount = 1;
    int gold;
    public int goldTotal;
    public int time;

    bool moveBool = true;
    bool goldx2 = false;
    bool speedx2 = false;
    bool timerBool = true;

    public TMP_Text layerName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerBool)
        {
            StartCoroutine(timerDelay());
            time++;
        }

        PlayerPrefs.SetInt("TotalGoldAmount", goldTotal);
        PlayerPrefs.SetInt("RocketLevelInt", rocketLevel);
        PlayerPrefs.SetInt("RadarLevelInt", radarUpgradeCount);
        PlayerPrefs.SetInt("GameTime", time);

        if (moveBool)
        {
            StartCoroutine(rocketMoveDelay());

            if (speedx2)
            {
                gameSpeedVector = gameSpeedVector + (gameSpeed * 2);
                moveRocketVector = new Vector3(0, gameSpeedVector , 0);
                gameObject.transform.position = moveRocketVector;
            }

            else if (!speedx2)
            {
                gameSpeedVector = gameSpeedVector + gameSpeed;
                moveRocketVector = new Vector3(0, gameSpeedVector, 0);
                gameObject.transform.position = moveRocketVector;
            }
        }

        toMoonText.text = "Moon: " + (5000 - (int)gameObject.transform.position.y) + " sM";

    }

    IEnumerator rocketMoveDelay()
    {
        moveBool = false;
        yield return new WaitForSeconds(0.01f);
        moveBool = true;
    }

    public void rocketUpButton()
    {

        if(rocketLevel == 1 && gold >= 10)
        {
            gameSpeed = 0.02f;
            rocketLevel++;
            rocketLevelText.text = "Level 2";
            gold = gold - 10;
            coinText.text = "Coin: " + gold + "c";
            rocketGoldNeed.text = "Speed Up: 20c";
        }

        else if (rocketLevel == 2 && gold >= 20)
        {
            gameSpeed = 0.03f;
            rocketLevel++;
            rocketLevelText.text = "Level 3";
            gold = gold - 20;
            coinText.text = "Coin: " + gold + "c";
            rocketGoldNeed.text = "Speed Up: 40c";
        }

        else if (rocketLevel == 3 && gold >= 40)
        {
            gameSpeed = 0.04f;
            rocketLevel++;
            rocketLevelText.text = "Level 4";
            gold = gold - 40;
            coinText.text = "Coin: " + gold + "c";
            rocketGoldNeed.text = "Speed Up: 70c";
        }

        else if (rocketLevel == 4 && gold >= 70)
        {
            gameSpeed = 0.05f;
            rocketLevel++;
            rocketLevelText.text = "Level 5";
            gold = gold - 70;
            coinText.text = "Coin: " + gold + "c";
            rocketGoldNeed.text = "Speed Up: 100c";
        }

        else if (rocketLevel == 5 && gold >= 100)
        {
            gameSpeed = 0.06f;
            rocketLevel++;
            rocketLevelText.text = "Level 6";
            gold = gold - 100;
            coinText.text = "Coin: " + gold + "c";
            rocketGoldNeed.text = "Speed Up: 150c";
        }

        else if (rocketLevel == 6 && gold >= 150)
        {
            gameSpeed = 0.08f;
            rocketLevel++;
            rocketLevelText.text = "Level 7";
            gold = gold - 150;
            coinText.text = "Coin: " + gold + "c";
            rocketGoldNeed.text = "Speed Up: 200c";
        }

        else if (rocketLevel == 7 && gold >= 200)
        {
            gameSpeed = 0.1f;
            rocketLevel++;
            rocketLevelText.text = "Level 8";
            gold = gold - 200;
            coinText.text = "Coin: " + gold + "c";
            rocketGoldNeed.text = "Speed Up: 300c";
        }

        else if (rocketLevel == 8 && gold >= 300)
        {
            gameSpeed = 0.12f;
            rocketLevel++;
            rocketLevelText.text = "Level 9";
            gold = gold - 300;
            coinText.text = "Coin: " + gold + "c";
            rocketGoldNeed.text = "Speed Up: 500c";
        }

        else if (rocketLevel == 9 && gold >= 500)
        {
            gameSpeed = 0.15f;
            rocketLevel++;
            rocketLevelText.text = "Level MAX";
            gold = gold - 500;
            coinText.text = "Coin: " + gold + "c";
            rocketGoldNeed.text = "Speed Up: MAX";
        }

    }

    public void cameraAngle()
    {
        if(radarUpgradeCount == 1 && gold >= 10)
        {
            gold = gold - 10;
            coinText.text = "Coin: " + gold + "c";
            cameraSize = cameraSize + 0.2f;
            Camera.main.orthographicSize = cameraSize;
            radarUpgradeCount++;
            radarLevelText.text = "Level " + radarUpgradeCount;
            radarGoldNeed.text = "Radar Up: 20c";
        }

        else if (radarUpgradeCount == 2 && gold >= 20)
        {
            gold = gold - 20;
            coinText.text = "Coin: " + gold + "c";
            cameraSize = cameraSize + 0.2f;
            Camera.main.orthographicSize = cameraSize;
            radarUpgradeCount++;
            radarLevelText.text = "Level " + radarUpgradeCount;
            radarGoldNeed.text = "Radar Up: 40c";
        }

        else if (radarUpgradeCount == 3 && gold >= 40)
        {
            gold = gold - 40;
            coinText.text = "Coin: " + gold + "c";
            cameraSize = cameraSize + 0.2f;
            Camera.main.orthographicSize = cameraSize;
            radarUpgradeCount++;
            radarLevelText.text = "Level " + radarUpgradeCount;
            radarGoldNeed.text = "Radar Up: 70c";
        }

        else if (radarUpgradeCount == 4 && gold >= 70)
        {
            gold = gold - 70;
            coinText.text = "Coin: " + gold + "c";
            cameraSize = cameraSize + 0.2f;
            Camera.main.orthographicSize = cameraSize;
            radarUpgradeCount++;
            radarLevelText.text = "Level " + radarUpgradeCount;
            radarGoldNeed.text = "Radar Up: 100c";
        }

        else if (radarUpgradeCount == 5 && gold >= 100)
        {
            gold = gold - 100;
            coinText.text = "Coin: " + gold + "c";
            cameraSize = cameraSize + 0.2f;
            Camera.main.orthographicSize = cameraSize;
            radarUpgradeCount++;
            radarLevelText.text = "Level " + radarUpgradeCount;
            radarGoldNeed.text = "Radar Up: 150c";
        }

        else if (radarUpgradeCount == 6 && gold >= 150)
        {
            gold = gold - 150;
            coinText.text = "Coin: " + gold + "c";
            cameraSize = cameraSize + 0.2f;
            Camera.main.orthographicSize = cameraSize;
            radarUpgradeCount++;
            radarLevelText.text = "Level " + radarUpgradeCount;
            radarGoldNeed.text = "Radar Up: 200c";
        }

        else if (radarUpgradeCount == 7 && gold >= 200)
        {
            gold = gold - 200;
            coinText.text = "Coin: " + gold + "c";
            cameraSize = cameraSize + 0.2f;
            Camera.main.orthographicSize = cameraSize;
            radarUpgradeCount++;
            radarLevelText.text = "Level " + radarUpgradeCount;
            radarGoldNeed.text = "Radar Up: 300c";
        }

        else if (radarUpgradeCount == 8 && gold >= 300)
        {
            gold = gold - 300;
            coinText.text = "Coin: " + gold + "c";
            cameraSize = cameraSize + 0.2f;
            Camera.main.orthographicSize = cameraSize;
            radarUpgradeCount++;
            radarLevelText.text = "Level " + radarUpgradeCount;
            radarGoldNeed.text = "Radar Up: 500c";
        }

        else if(radarUpgradeCount == 9 && gold >= 500)
        {
            gold = gold - 500;
            coinText.text = "Coin: " + gold + "c";
            cameraSize = cameraSize + 0.2f;
            Camera.main.orthographicSize = cameraSize;
            radarUpgradeCount++;
            radarLevelText.text = "Max Level";
            radarGoldNeed.text = "Radar Up: MAX";
        }
    }

    public void goldIncrease()
    {
        if (goldx2)
        {
            gold = gold + 2;
            goldTotal = goldTotal + 2;
            coinText.text = "Coin: " + gold + " c";
            audioManage.PlaySound("GoldCollect");
        }
        else if (!goldx2)
        {
            gold = gold + 1;
            goldTotal = goldTotal + 1;
            coinText.text = "Coin: " + gold + " c";
            audioManage.PlaySound("GoldCollect");
        }
    }

    public void gemIncrease()
    {
        if (goldx2)
        {
            gold = gold + 6;
            goldTotal = goldTotal + 6;
            coinText.text = "Coin: " + gold + " c";
            audioManage.PlaySound("GoldCollect");
        }
        else if (!goldx2)
        {
            gold = gold + 3;
            goldTotal = goldTotal + 3;
            coinText.text = "Coin: " + gold + " c";
            audioManage.PlaySound("GoldCollect");
        }
    }

    public void copiumIncrease()
    {
        if (goldx2)
        {
            gold = gold + 10;
            goldTotal = goldTotal + 10;
            coinText.text = "Coin: " + gold + " c";
            audioManage.PlaySound("GoldCollect");
        }
        else if (!goldx2)
        {
            gold = gold + 5;
            goldTotal = goldTotal + 5;
            coinText.text = "Coin: " + gold + " c";
            audioManage.PlaySound("GoldCollect");
        }
    }

    public void lapisIncrease()
    {
        if (goldx2)
        {
            gold = gold + 14;
            goldTotal = goldTotal + 14;
            coinText.text = "Coin: " + gold + " c";
            audioManage.PlaySound("GoldCollect");
        }
        else if (!goldx2)
        {
            gold = gold + 7;
            goldTotal = goldTotal + 7;
            coinText.text = "Coin: " + gold + " c";
            audioManage.PlaySound("GoldCollect");
        }
    }

    public void rubyIncrease()
    {
        if (goldx2)
        {
            gold = gold + 20;
            goldTotal = goldTotal + 20;
            coinText.text = "Coin: " + gold + " c";
            audioManage.PlaySound("GoldCollect");
        }
        else if (!goldx2)
        {
            gold = gold + 10;
            goldTotal = goldTotal + 10;
            coinText.text = "Coin: " + gold + " c";
            audioManage.PlaySound("GoldCollect");
        }
    }

    public void goldx2Method()
    {
        StartCoroutine(goldboosterDelay());
    }

    public void speedx2Method()
    {
        StartCoroutine(speedboosterDelay());
    }

    IEnumerator goldboosterDelay()
    {
        audioManage.PlaySound("BoosterCollect");
        goldx2 = true;
        x2YellowGoldText.SetActive(true);
        yield return new WaitForSeconds(5);
        x2YellowGoldText.SetActive(false);
        goldx2 = false;
    }

    IEnumerator speedboosterDelay()
    {
        audioManage.PlaySound("BoosterCollect");
        speedx2 = true;
        x2YellowSpeedText.SetActive(true);
        yield return new WaitForSeconds(5);
        x2YellowSpeedText.SetActive(false);
        speedx2 = false;
    }

    IEnumerator timerDelay()
    {
        timerBool = false;
        yield return new WaitForSeconds(1);
        timerBool = true;
    }



}
