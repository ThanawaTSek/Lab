using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManaGer : MonoBehaviour
{
    [SerializeField] private int playerScore;
    public int PlayerScore { get { return playerScore; } set { playerScore = value; } }

    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private GameObject[] ballPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
