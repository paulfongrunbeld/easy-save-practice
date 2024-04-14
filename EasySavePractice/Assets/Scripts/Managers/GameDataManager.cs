using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDataManager : MonoBehaviour
{
	[SerializeField] private int _currentScore;
	[SerializeField] private string _currentLevelName;

	private static GameDataManager _instance;
	private GameDataManager() { }

	private void Awake()
	{
		_instance = this;

		_currentScore = LoadScore();
		_currentLevelName = LoadLevelName();

		SaveLevelName(SceneManager.GetActiveScene().name);
	} 

	public static GameDataManager Instance
	{
		get
		{
			if (_instance == null)
			{
				GameObject singletonObject = new GameObject("GameDataManager");
				_instance = singletonObject.AddComponent<GameDataManager>();
			}
			return _instance;
		}
	}

	public void SetData()
	{
		ES3.Save("score", _currentScore);
		ES3.Save("levelName", _currentLevelName);
	}

	public void RestartData()
	{
		ES3.Save("score", 0);
		ES3.Save("levelName", "Level_1");
	}

	public void SaveScore(int score) => ES3.Save("score", score);
	public void SaveLevelName(string levelName) => ES3.Save("levelName", levelName);
	public int LoadScore() => ES3.Load<int>("score");
	public string LoadLevelName() => ES3.Load<string>("levelName");
}
