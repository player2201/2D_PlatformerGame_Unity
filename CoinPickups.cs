﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickups : MonoBehaviour
{
    [SerializeField] AudioClip coinPickupsSFX;
    [SerializeField] int pointsPerCoin = 100;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameSession>().AddToScore(pointsPerCoin);
        AudioSource.PlayClipAtPoint(coinPickupsSFX, Camera.main.transform.position);
        Destroy(gameObject);
    }
}
