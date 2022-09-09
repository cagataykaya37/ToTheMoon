using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldDownMove : MonoBehaviour
{
    moveRocket MoveRocket;

    bool moveGoldDelay = true;

    // Start is called before the first frame update
    void Start()
    {
        MoveRocket = GameObject.Find("Rocket").GetComponent<moveRocket>();
    }

    // Update is called once per frame
    void Update()
    {

        if (MoveRocket.rocketLevel == 1 && moveGoldDelay)
        {
            StartCoroutine(goldMoveDelay());
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 0.04f, this.gameObject.transform.position.z);
        }

        else if (MoveRocket.rocketLevel <= 3 && moveGoldDelay)
        {
            StartCoroutine(goldMoveDelay());
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 0.05f, this.gameObject.transform.position.z);
        }

        //else if (this.gameObject.transform.position.y < 507 && moveGoldDelay)
        //{
        //    StartCoroutine(goldMoveDelay());
        //    this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 0.08f, this.gameObject.transform.position.z);
        //}

        else if (MoveRocket.rocketLevel <= 5 && moveGoldDelay)
        {
            StartCoroutine(goldMoveDelay());
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 0.04f, this.gameObject.transform.position.z);
        }

        //else if (this.gameObject.transform.position.y < 1207 && moveGoldDelay)
        //{
        //    StartCoroutine(goldMoveDelay());
        //    this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 0.06f, this.gameObject.transform.position.z);
        //}

        else if (MoveRocket.rocketLevel == 6 && moveGoldDelay)
        {
            StartCoroutine(goldMoveDelay());
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 0.03f, this.gameObject.transform.position.z);
        }

        else if (MoveRocket.rocketLevel == 7 && moveGoldDelay)
        {
            StartCoroutine(goldMoveDelay());
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 0.02f, this.gameObject.transform.position.z);
        }

        else if (MoveRocket.rocketLevel == 8 && moveGoldDelay)
        {
            StartCoroutine(goldMoveDelay());
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 0.02f, this.gameObject.transform.position.z);
        }

    }

    IEnumerator goldMoveDelay()
    {
        moveGoldDelay = false;
        yield return new WaitForSeconds(0.01f);
        moveGoldDelay = true;
    }

}
