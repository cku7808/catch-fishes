using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    static ScoreManager _instance = null;
    public static ScoreManager instance
    {
        get
        {
            return _instance;
        }
    }
    public UnityEngine.UI.Text text;
    public UnityEngine.UI.Text bestScoreText;
    int _score = 0;
    int _bestScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        _instance = this;
        _bestScore = PlayerPrefs.GetInt("bestScore", 0);
        bestScoreText.text = "Best Score : " + _bestScore;
    }
    public int score
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
            if(_bestScore < _score)
            {
                _bestScore = _score;
                PlayerPrefs.SetInt("bestScore", _bestScore);
                bestScoreText.text = "Best Score : " + _bestScore;
            }
            text.text = "Score : " + _score;
        }
    }
}
