using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPalyer : MonoBehaviour
{
    public Transform Player;
    public Vector2 offset = new Vector2(0,0);

    // Update is called once per frame
    void Update()
    {
        if (Player.position.y > transform.position.y - offset.y)
        {
            transform.position = new Vector3(transform.position.x + offset.x, Player.position.y + offset.y, transform.position.z);
        }
    }
}
