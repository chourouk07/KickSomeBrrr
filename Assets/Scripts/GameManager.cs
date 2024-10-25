using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    //arrays containing Runestones
    public GameObject[] runeStone;
    //Arrays containing Fruits
    public GameObject[] fruit;

    public float Timer;
    public static float timeLeft;
    public Text timeLeftText;

    public static float currentScore;
    public float levelScore;
    public Text ScoreText;
    [SerializeField] public static int addedScore = 1;


    // Start is called before the first frame update
    void Start()
    {
        timeLeft = Timer;

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        CoolDownTimer();
        DiesplayTimer();
        DisplayScore();
        CheckScore();
    }

    public void DiesplayTimer()
    {
        //show UI
        float minutes = Mathf.Floor(timeLeft / 60);
        float seconds = Mathf.Floor(timeLeft % 60);
        timeLeftText.text = "Time : " + minutes + ":" + seconds;
        if (seconds < 10)
        {
            timeLeftText.text = "Time : " + minutes + ":0" + seconds;
        }
    }
    public void DisplayScore()
    {
        ScoreText.text = "Score : " + currentScore + "/" + levelScore;
    }

    public void CoolDownTimer()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        else
        {
            //timeLeft = Timer;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //rest game because loss
        }
    }

    public void CheckScore()
    {
        if (timeLeft < 0 && currentScore < 20)
        {
            // lose and reset level
            Debug.Log("You Lose!");
            //rest scene
            Invoke("ReloadScene", 1);
        }
        else if (currentScore >= 20)
        {
            //win and move to next scene
            Debug.Log("You Win!");
            //trigger lab animation
            //load next scene
            Invoke("NextScene", 3);

        }
    }

    void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
