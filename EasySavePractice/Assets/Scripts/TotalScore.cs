using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
	private void Awake() => SetText();

	private void SetText()
	{
		int totalScore = GameDataManager.Instance.LoadScore();
		_text.text = "Вы завершили игру со счетом: " + totalScore.ToString();
	}
}
