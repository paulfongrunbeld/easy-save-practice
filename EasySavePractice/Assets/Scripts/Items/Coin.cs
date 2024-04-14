using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, ICollectable
{
    public void Collect()
    {
        ScoreManager.Instance.AddScore();
        Destroy(gameObject);
    }
}
