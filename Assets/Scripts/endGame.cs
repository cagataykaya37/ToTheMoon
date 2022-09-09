using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class endGame : MonoBehaviour
{

    public TMP_Text time;
    public TMP_Text gold;
    public TMP_Text radar;
    public TMP_Text rocket;
    public TMP_Text monster;

    //goldSpawn GoldSpawn;
    //moveRocket MoveRocket;
    //monsterAttack MonsterAttack;

    int spaceMinute;
    int spaceSecond;
    int totalTime;
    int totalAttack;
    int leftAttack;
    int rightAttack;

    // Start is called before the first frame update
    void Start()
    {
        //GoldSpawn = GetComponent<goldSpawn>();
        //MoveRocket = GetComponent<moveRocket>();
        //MonsterAttack = GetComponent<monsterAttack>();

        totalTime = PlayerPrefs.GetInt("GameTime");
        leftAttack = PlayerPrefs.GetInt("leftAttack");
        rightAttack = PlayerPrefs.GetInt("rightAttack");
        totalAttack = leftAttack + rightAttack;
    }

    // Update is called once per frame
    void Update()
    {
        reWork:
        if(totalTime >= 60)
        {
            totalTime = totalTime - 60;
            spaceMinute++;
            goto reWork;

        }
        else
        {
            spaceSecond = totalTime;
        }

        gold.text = "Total Gold Collected: " + PlayerPrefs.GetInt("TotalGoldAmount");
        rocket.text = "Rocket Level: " + PlayerPrefs.GetInt("RocketLevelInt");
        radar.text = "Radar Level: " + PlayerPrefs.GetInt("RadarLevelInt");
        monster.text = "Monster Attack: " + totalAttack;
        time.text = "Space Mission Time: " + spaceMinute + "m " + spaceSecond + "s";

    }
}
