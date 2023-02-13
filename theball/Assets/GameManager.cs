using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour   
{

    public int StageNo;

    public bool isBallMoving;

    public GameObject ballPrefab;
    public GameObject ball;

    public GameObject goButton;
    public GameObject retryButton;
    public GameObject clearText;

    // Start is called before the first frame update
    void Start()
    {

        retryButton.SetActive(false);
        isBallMoving = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushGoButton ()
    {

        Rigidbody2D rd = ball.GetComponent<Rigidbody2D>();
        rd.isKinematic = false;

        retryButton.SetActive(true);
        goButton.SetActive(false);
        isBallMoving = true;

    }

    public void PushRetryButton ()
    {

        Destroy(ball);

        ball = (GameObject)Instantiate(ballPrefab);

        retryButton.SetActive(false);
        goButton.SetActive(true);
        isBallMoving = false;

    }

    public void StageClear ()
    {
        clearText.SetActive(true);
        retryButton.SetActive(false);
    }

}
