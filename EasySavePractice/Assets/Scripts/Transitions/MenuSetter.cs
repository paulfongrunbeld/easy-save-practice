using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSetter : MonoBehaviour, IAction
{
	[SerializeField] private string _sceneName;
	public void ExecuteAction() => SceneManager.LoadScene(_sceneName);
}
