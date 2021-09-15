//Written by Jenna Saleh
//Modified by Danny Christie
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    private Rigidbody2D rb;
    public float fallDelay;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(fall());
        }
    }
    IEnumerator fall()
    {
        yield return new WaitForSeconds(fallDelay);
        gameObject.SetActive(false);
        yield return 0;
    }
}
