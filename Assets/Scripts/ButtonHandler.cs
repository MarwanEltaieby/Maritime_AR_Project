using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    [SerializeField] GameObject activatableGameObject;

    public void SetActivatableGameObject() {
        if (activatableGameObject.activeInHierarchy) {
            activatableGameObject.SetActive(false);
        } else {
            activatableGameObject.SetActive(true);
        }
    }
}
