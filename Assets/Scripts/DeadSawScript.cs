using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadSawScript : MonoBehaviour
{
    public Transform saw;
    public Transform player;
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        saw.transform.position = Vector2.MoveTowards(saw.position, player.position, speed * Time.deltaTime);
    }
}
