using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectInteractor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IAction interactableObject = collision.GetComponent<IAction>();

        if (interactableObject != null)
            interactableObject.ExecuteAction();
    }
}
