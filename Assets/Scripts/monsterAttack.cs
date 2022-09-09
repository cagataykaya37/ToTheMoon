using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterAttack : MonoBehaviour
{
    goldSpawn GoldSpawn;
    moveRocket MoveRocket;

    int randomAttack;
    public int leftAttackCount;

    bool attackDelayBool = true;
    bool leftAttackAudio = true;

    public GameObject parentMonster;

    SpriteRenderer monsterSprite;
    SpriteRenderer hitSprite;

    // Start is called before the first frame update
    void Start()
    {
        GoldSpawn = GameObject.Find("ScriptManage").GetComponent<goldSpawn>();
        MoveRocket = GameObject.Find("Rocket").GetComponent<moveRocket>();

        monsterSprite = GetComponent<SpriteRenderer>();
        hitSprite = GameObject.Find("HitLeft").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("leftAttack", leftAttackCount);

        if (attackDelayBool && GoldSpawn.rocketMeter < 100)
        {
            StartCoroutine(attackDelay());
            randomAttack = Random.Range(1, 101);

            if (randomAttack == 0)
            {

            }

        }
        else if (attackDelayBool && GoldSpawn.rocketMeter < 250)
        {
            StartCoroutine(attackDelay());
            randomAttack = Random.Range(1, 101);

            if (randomAttack < 2)
            {
                monsterSprite.enabled = true;
                GameObject.Find("Monster").GetComponent<Animator>().Play("monsterAttackLeft");
            }

        }
        else if (attackDelayBool && GoldSpawn.rocketMeter < 500)
        {
            StartCoroutine(attackDelay());
            randomAttack = Random.Range(1, 101);

            if (randomAttack < 3)
            {
                monsterSprite.enabled = true;
                GameObject.Find("Monster").GetComponent<Animator>().Play("monsterAttackLeft");
            }

        }
        else if (attackDelayBool && GoldSpawn.rocketMeter < 800)
        {
            StartCoroutine(attackDelay());
            randomAttack = Random.Range(1, 101);

            if (randomAttack < 4)
            {
                monsterSprite.enabled = true;
                GameObject.Find("Monster").GetComponent<Animator>().Play("monsterAttackLeft");
            }

        }
        else if (attackDelayBool && GoldSpawn.rocketMeter < 1200)
        {
            StartCoroutine(attackDelay());
            randomAttack = Random.Range(1, 101);

            if (randomAttack < 5)
            {
                monsterSprite.enabled = true;
                GameObject.Find("Monster").GetComponent<Animator>().Play("monsterAttackLeft");
            }

        }
        else if (attackDelayBool && GoldSpawn.rocketMeter < 1700)
        {
            StartCoroutine(attackDelay());
            randomAttack = Random.Range(1, 101);

            if (randomAttack < 6)
            {
                monsterSprite.enabled = true;
                GameObject.Find("Monster").GetComponent<Animator>().Play("monsterAttackLeft");
            }

        }
        else if (attackDelayBool && GoldSpawn.rocketMeter < 2400)
        {
            StartCoroutine(attackDelay());
            randomAttack = Random.Range(1, 101);

            if (randomAttack < 8)
            {
                monsterSprite.enabled = true;
                GameObject.Find("Monster").GetComponent<Animator>().Play("monsterAttackLeft");
            }

        }
        else if (attackDelayBool && GoldSpawn.rocketMeter < 3200)
        {
            StartCoroutine(attackDelay());
            randomAttack = Random.Range(1, 101);

            if (randomAttack < 8)
            {
                monsterSprite.enabled = true;
                GameObject.Find("Monster").GetComponent<Animator>().Play("monsterAttackLeft");
            }

        }
        else if (attackDelayBool && GoldSpawn.rocketMeter < 3200)
        {
            StartCoroutine(attackDelay());
            randomAttack = Random.Range(1, 101);

            if (randomAttack < 10)
            {
                monsterSprite.enabled = true;
                GameObject.Find("Monster").GetComponent<Animator>().Play("monsterAttackLeft");
            }

        }
        else if (attackDelayBool && GoldSpawn.rocketMeter < 4000)
        {
            StartCoroutine(attackDelay());
            randomAttack = Random.Range(1, 101);

            if (randomAttack < 12)
            {
                monsterSprite.enabled = true;
                GameObject.Find("Monster").GetComponent<Animator>().Play("monsterAttackLeft");
            }

        }
        else if (attackDelayBool && GoldSpawn.rocketMeter < 5000)
        {
            StartCoroutine(attackDelay());
            randomAttack = Random.Range(1, 101);

            if (randomAttack < 15)
            {
                monsterSprite.enabled = true;
                GameObject.Find("Monster").GetComponent<Animator>().Play("monsterAttackLeft");
            }

        }


        if (parentMonster.transform.position.x >= 4.7f)
        {
            leftAttackCount++;
            hitSprite.enabled = true;
            MoveRocket.gameSpeedVector = MoveRocket.gameSpeedVector * 0.99f;

            if (leftAttackAudio)
            {
                leftAttackAudio = false;
                audioManage.PlaySound("MonsterHit");
            }

            GameObject.Find("Monster").GetComponent<Animator>().Play("monsterAttackRight");
        }
        else if(parentMonster.transform.position.x < 4.7f && parentMonster.transform.position.x > 3.5f)
        {
            leftAttackAudio = true;
            hitSprite.enabled = false;
        }
        else if(parentMonster.transform.position.x <= -0.25f)
        {
            leftAttackAudio = true;
            monsterSprite.enabled = false;
        }
        else if (parentMonster.transform.position.x > -0.24f)
        {
            leftAttackAudio = true;
            monsterSprite.enabled = true;
        }

    }

    private void OnMouseDown()
    {
        monsterSprite.enabled = false;
        GameObject.Find("Monster").GetComponent<Animator>().Play("Base");
        audioManage.PlaySound("MonsterDead");
    }

    IEnumerator attackDelay()
    {
        attackDelayBool = false;
        yield return new WaitForSeconds(8);
        attackDelayBool = true;
    }


}
