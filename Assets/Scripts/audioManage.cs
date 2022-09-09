using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManage : MonoBehaviour
{
    public static AudioClip goldCollect, boosterCollect, monsterDead, monsterHit, newLayer;
    static AudioSource audioSourceManager;

    // Start is called before the first frame update
    void Start()
    {
        audioSourceManager = GetComponent<AudioSource>();

        goldCollect = Resources.Load<AudioClip>("GoldCollect");
        boosterCollect = Resources.Load<AudioClip>("BoosterCollect");
        monsterDead = Resources.Load<AudioClip>("MonsterDead");
        monsterHit = Resources.Load<AudioClip>("MonsterHit");
        newLayer = Resources.Load<AudioClip>("NewLayer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "GoldCollect":
                audioSourceManager.PlayOneShot(goldCollect);
                break;

            case "BoosterCollect":
                audioSourceManager.PlayOneShot(boosterCollect);
                break;

            case "MonsterDead":
                audioSourceManager.PlayOneShot(monsterDead);
                break;

            case "MonsterHit":
                audioSourceManager.PlayOneShot(monsterHit);
                break;

            case "NewLayer":
                audioSourceManager.PlayOneShot(newLayer);
                break;
        }
    }

}
