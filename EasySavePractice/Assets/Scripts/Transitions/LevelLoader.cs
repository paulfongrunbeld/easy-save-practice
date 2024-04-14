using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour, IAction
{
    [SerializeField] private string _levelName;

	private void Awake()
	{
		GameDataManager.Instance.SetData();
		_levelName = GameDataManager.Instance.LoadLevelName();
	}
	public void ExecuteAction() => SceneManager.LoadScene(_levelName);
}
