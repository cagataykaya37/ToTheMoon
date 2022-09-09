using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class copiumDestroy : MonoBehaviour
{
    moveRocket MoveRocket;

    // Start is called before the first frame update
    void Start()
    {
        MoveRocket = GameObject.Find("Rocket").GetComponent<moveRocket>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "CoinDestroy" || collision.gameObject.name == "MonsterLeft" || collision.gameObject.name == "MonsterRight")
        {
            Destroy(this.gameObject);
        }
    }

    private void OnMouseDown()
    {
        Destroy(this.gameObject);
        MoveRocket.copiumIncrease();
    }

}
