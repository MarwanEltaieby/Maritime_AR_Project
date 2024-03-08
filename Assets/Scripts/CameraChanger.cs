using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraChanger : MonoBehaviour
{
    [SerializeField] TMP_Text rightClickText;
    Animator animator;

    private void Awake() {
        animator = GetComponent<Animator>();
        StartCoroutine(DisactivateText());
    }

    private IEnumerator DisactivateText()
    {
        yield return new WaitForSeconds(4f);
        rightClickText.gameObject.SetActive(false);
    }

    void OnFire(InputValue value) {
        animator.SetTrigger("Change Cam");
    }
}
