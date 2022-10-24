using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartQuit : MonoBehaviour
{
    public GameObject startButton;
    public GameObject quitButton;
    public GameObject myName;
    public GameObject[] scores;
    public Food food;
    public Snake snake;

    private void OnMouseDown()
    {
        if (transform.name=="START" && !quitButton.activeSelf)
        {
            quitButton.SetActive(true);
            myName.SetActive(false);
            foreach (var i in scores)
            {
                i.SetActive(true);
            }
            food.RandomizePosition();
            SwipeManager.Instance.isStart = true;
            startButton.SetActive(false);
        }

        if (transform.name=="STOP" && !startButton.activeSelf)
        {
            SwipeManager.Instance.isStart = false;
            SceneManager.LoadScene(0);
            //startButton.SetActive(true);
            //myName.SetActive(true);
            //foreach (var i in scores)
            //{
            //    i.SetActive(false);
            //}
            //snake.isStart = false;
            //quitButton.SetActive(false);
        }
    }

}