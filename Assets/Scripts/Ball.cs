using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private int point;
    public int Point { get { return point; } }

    [SerializeField] private BallColor ballColor;
    [SerializeField] private MeshRenderer rd;

    private void Awake()
    {
        rd = GetComponent<MeshRenderer>();
    }

    public void SetColorAndPoint(BallColor col)
    {
        switch (col)
        {
            case BallColor.White:
                point = 0;
                rd.material.color = Color.white;
                break;
        }
    }
}
 public enum BallColor
    {
        White,
        Red,
        Yellow,
        Green,
        Brown,
        Blue,
        Pink,
        Black
        
    }
