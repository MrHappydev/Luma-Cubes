using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GegnerCollision : MonoBehaviour
{
    public Transform spieler;
    public RawImage LOL;


    public Transform respawn;
    private void Start()
    {
        LOL.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        spieler.position = respawn.position;
        LOL.enabled = true;
        StartCoroutine(Wachstum());


    }

    private IEnumerator Wachstum()
    {
        Vector3 size = LOL.transform.localScale;
        while(LOL.transform.localScale.x < 5)
        {
            LOL.transform.localScale += new Vector3(0.06f, 0.06f, 0);
            yield return new WaitForSecondsRealtime(Time.fixedDeltaTime);
        }
        while(LOL.transform.localScale.x > size.x && LOL.transform.localScale.y > size.y)
        {
            LOL.transform.localScale -= new Vector3(0.06f, 0.06f, 0);
            yield return new WaitForSecondsRealtime(Time.fixedDeltaTime);
        }
        LOL.enabled = false;
        
    }


}
