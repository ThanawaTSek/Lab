using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Ball b = collision.gameObject.GetComponent<Ball>();
        if (b != null)
        {
            GameManaGer.instance.PlayerScore += b.Point;
            GameManaGer.instance.UpdateScoreText();
            Destroy(b.gameObject);
        }
    }
}
