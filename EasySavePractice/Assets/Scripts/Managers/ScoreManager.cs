using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
	private static ScoreManager _instance;
	private ScoreManager() { }

	[SerializeField] private int _score;
	[SerializeField] private TextMeshProUGUI _scoreText;

	private void Awake()
	{
		_instance = this;
		LoadCurrentScore();
	} 

	public static ScoreManager Instance
	{
		get
		{
			if (_instance == null)
			{
				GameObject singletonObject = new GameObject("ScoreManager");
				_instance = singletonObject.AddComponent<ScoreManager>();
			}
			return _instance;
		}
	}

    public int Score { get { return _score; } }
    public void AddScore()
    {
        _score++;
        UpdateScoreText();
    }
	public void LoadCurrentScore()
	{
		_score = GameDataManager.Instance.LoadScore();
		UpdateScoreText();
	}
	public void SaveCurrentScore() => GameDataManager.Instance.SaveScore(_score);
	private void UpdateScoreText() => _scoreText.text = "Score: " + _score.ToString();
}
