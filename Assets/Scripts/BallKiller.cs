using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class BallKiller : MonoBehaviour
{
    public eColor color;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Ontrigger");
        if (col.tag == "Player")
        {
            Debug.Log(col.tag.ToString() + "entered in trigger " + color.ToString());
            if(col.GetComponent<Player>().currentCollor != color)
            {
                col.GetComponent<Player>().Die();
            }
        }
    }

    
}
