using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreTextScript.coinAmount += 1;
        Destroy(gameObject);
        GameObject.Find("SoundObject").GetComponents<AudioSource>()[0].Play();
    }
}
