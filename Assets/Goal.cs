using UnityEngine;


public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (!isPlayer1Goal)
            {
                Debug.Log("Player 1 Scored");
                GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
            }else
            {
                Debug.Log("Player 2 Scored");
                GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();
            }
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
