using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    [SerializeField] Vector3 rotationOffset;
    Vector3 currentOffset;
    float zRotation = 23.5f;

    private void Update() {
        currentOffset += rotationOffset * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(currentOffset.x, currentOffset.y, currentOffset.z + zRotation);
    }
}
