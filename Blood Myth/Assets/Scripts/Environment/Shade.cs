﻿using UnityEngine;
using System.Collections;

public class Shade : MonoBehaviour
{
    public GameObject player;

    void OnTriggerStay2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            player.GetComponent<Player>().InShade();
        }
    }
}