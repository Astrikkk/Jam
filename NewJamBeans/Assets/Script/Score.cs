using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Text scoreTxt;
    public int score;
    public int highScore;
    public Text HighscoreTxt;
    public float time;
    private float TimeStart;
    public GameObject Holder;

    void Start()
    {
        score = 0;
        TimeStart = time;
        highScore = PlayerPrefs.GetInt("HighScore");
    }

    void Update()
    {
        if(Holder.GetComponent<Holder>().defeate != true)
        {
            time -= Time.deltaTime;
            scoreTxt.text = score.ToString();
            HighscoreTxt.text = highScore.ToString();
            if(time <= 0)
            {
                score += 1;
                time = TimeStart;
            }
        }

        if(highScore < score)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }
}
