using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;

public class RotateOnTrigger : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;
    [SerializeField] private float rotateValueX;
    [SerializeField] private float rotateValueY;
    [SerializeField] private float time;

    void OnTriggerEnter2D(Collider2D collision)
    {
        targetObject.transform.DORotate(new Vector2(targetObject.transform.rotation.x + rotateValueX, targetObject.transform.rotation.y + rotateValueY), time);
    }
}
