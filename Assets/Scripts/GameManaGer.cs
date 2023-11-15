using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManaGer : MonoBehaviour
{
    [SerializeField] private int playerScore;
    public int PlayerScore { get { return playerScore; } set { playerScore = value; } }

    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private GameObject[] ballPosition;

    public static GameManaGer instance;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        
        SetBall(BallColor.Red,1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetBall(BallColor col, int i)
    {
        GameObject obj = Instantiate(ballPrefab, ballPosition[i].transform.position, Quaternion.identity);
        Ball b = obj.GetComponent<Ball>();
            b.SetColorAndPoint(col);
    }
}
