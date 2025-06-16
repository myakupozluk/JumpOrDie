using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;

public class RotateOnTrigger : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;
    [SerializeField] private float rotateValue;
    [SerializeField] private float time;

    void OnTriggerEnter2D(Collider2D collision)
    {
        targetObject.transform.DORotate(new Vector3(targetObject.transform.rotation.x, targetObject.transform.rotation.y, targetObject.transform.rotation.z + rotateValue), time);
    }
}
