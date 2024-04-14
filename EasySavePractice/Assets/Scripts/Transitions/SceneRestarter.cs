using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRestarter : MonoBehaviour, IAction
{
	public void ExecuteAction() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}
