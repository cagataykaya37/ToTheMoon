using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterAttackRight : MonoBehaviour
{
    goldSpawn GoldSpawn;
    moveRocket MoveRocket;

    int randomAttack;
    public int rightAttackCount;

    bool attackDelayBool = true;
    bool rightAttackAudio = true;

    public GameObject parentMonster;

    SpriteRenderer monsterSprite;
    SpriteRenderer hitSprite;

    // Start is called before the first frame update
    void Start()
    {
        GoldSpawn = GameObject.Find("ScriptManage").GetComponent<goldSpawn>();
        MoveRocket = GameObject.Find("Rocket").GetComponent<moveRocket>();

        monsterSprite = GetComponent<SpriteRenderer>();
        hitSprite = GameObject.Find("HitRight").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("rightAttack", rightAttackCount);

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
                GameObject.Find("Monster2").GetComponent<Animator>().Play("monsterAttackRightAB");
            }

        }
        else if (attackDelayBool && GoldSpawn.rocketMeter < 500)
        {
            StartCoroutine(attackDelay());
            randomAttack = Random.Range(1, 101);

            if (randomAttack < 3)
            {
                monsterSprite.enabled = true;
                GameObject.Find("Monster2").GetComponent<Animator>().Play("monsterAttackRightAB");
            }

        }
        else if (attackDelayBool && GoldSpawn.rocketMeter < 800)
        {
            StartCoroutine(attackDelay());
            randomAttack = Random.Range(1, 101);

            if (randomAttack < 4)
            {
                monsterSprite.enabled = true;
                GameObject.Find("Monster2").GetComponent<Animator>().Play("monsterAttackRightAB");
            }

        }
        else if (attackDelayBool && GoldSpawn.rocketMeter < 1200)
        {
            StartCoroutine(attackDelay());
            randomAttack = Random.Range(1, 101);

            if (randomAttack < 5)
            {
                monsterSprite.enabled = true;
                GameObject.Find("Monster2").GetComponent<Animator>().Play("monsterAttackRightAB");
            }

        }
        else if (attackDelayBool && GoldSpawn.rocketMeter < 1700)
        {
            StartCoroutine(attackDelay());
            randomAttack = Random.Range(1, 101);

            if (randomAttack < 6)
            {
                monsterSprite.enabled = true;
                GameObject.Find("Monster2").GetComponent<Animator>().Play("monsterAttackRightAB");
            }

        }
        else if (attackDelayBool && GoldSpawn.rocketMeter < 2400)
        {
            StartCoroutine(attackDelay());
            randomAttack = Random.Range(1, 101);

            if (randomAttack < 8)
            {
                monsterSprite.enabled = true;
                GameObject.Find("Monster2").GetComponent<Animator>().Play("monsterAttackRightAB");
            }

        }
        else if (attackDelayBool && GoldSpawn.rocketMeter < 3200)
        {
            StartCoroutine(attackDelay());
            randomAttack = Random.Range(1, 101);

            if (randomAttack < 8)
            {
                monsterSprite.enabled = true;
                GameObject.Find("Monster2").GetComponent<Animator>().Play("monsterAttackRightAB");
            }

        }
        else if (attackDelayBool && GoldSpawn.rocketMeter < 3200)
        {
            StartCoroutine(attackDelay());
            randomAttack = Random.Range(1, 101);

            if (randomAttack < 10)
            {
                monsterSprite.enabled = true;
                GameObject.Find("Monster2").GetComponent<Animator>().Play("monsterAttackRightAB");
            }

        }
        else if (attackDelayBool && GoldSpawn.rocketMeter < 4000)
        {
            StartCoroutine(attackDelay());
            randomAttack = Random.Range(1, 101);

            if (randomAttack < 12)
            {
                monsterSprite.enabled = true;
                GameObject.Find("Monster2").GetComponent<Animator>().Play("monsterAttackRightAB");
            }

        }
        else if (attackDelayBool && GoldSpawn.rocketMeter < 5000)
        {
            StartCoroutine(attackDelay());
            randomAttack = Random.Range(1, 101);

            if (randomAttack < 15)
            {
                monsterSprite.enabled = true;
                GameObject.Find("Monster2").GetComponent<Animator>().Play("monsterAttackRightAB");
            }

        }


        if (parentMonster.transform.position.x <= -4.7f)
        {
            rightAttackCount++;
            hitSprite.enabled = true;

            if (rightAttackAudio)
            {
                rightAttackAudio = false;
                audioManage.PlaySound("MonsterHit");
            }
            
            MoveRocket.gameSpeedVector = MoveRocket.gameSpeedVector * 0.99f;
            GameObject.Find("Monster2").GetComponent<Animator>().Play("monsterAttackLeftAB");
        }
        else if(parentMonster.transform.position.x > -4.7f && parentMonster.transform.position.x < -3.5f)
        {
            rightAttackAudio = true;
            hitSprite.enabled = false;
        }
        else if(parentMonster.transform.position.x >= 0.25f)
        {
            rightAttackAudio = true;
            monsterSprite.enabled = false;
        }
        else if (parentMonster.transform.position.x < 0.24f)
        {
            rightAttackAudio = true;
            monsterSprite.enabled = true;
        }

    }

    private void OnMouseDown()
    {
        monsterSprite.enabled = false;
        GameObject.Find("Monster2").GetComponent<Animator>().Play("BaseAB");
        audioManage.PlaySound("MonsterDead");
    }

    IEnumerator attackDelay()
    {
        attackDelayBool = false;
        yield return new WaitForSeconds(7f);
        attackDelayBool = true;
    }


}
