using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class starDestroy : MonoBehaviour
{
    bool starDestroyBool = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(starDestoryDelay());
    }

    // Update is called once per frame
    void Update()
    {
        if (starDestroyBool) Destroy(this.gameObject);
    } 
    

    IEnumerator starDestoryDelay()
    {
        yield return new WaitForSeconds(40);
        starDestroyBool = true;
    }

}
