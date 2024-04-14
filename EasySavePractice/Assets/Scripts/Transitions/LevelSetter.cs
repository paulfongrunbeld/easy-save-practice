using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSetter : MonoBehaviour, IAction
{
	[SerializeField] private string _sceneName;
	public void ExecuteAction()
	{
		ScoreManager.Instance.SaveCurrentScore();
		SceneManager.LoadScene(_sceneName);
	} 
}
