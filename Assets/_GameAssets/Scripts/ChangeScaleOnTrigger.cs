using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;

public class ChangeScaleOnTrigger : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;
    [SerializeField] private float scaleValueX;
    [SerializeField] private float scaleValueY;
    [SerializeField] private float time;

    void OnTriggerEnter2D(Collider2D collision)
    {
        targetObject.transform.DOScale(new Vector2(targetObject.transform.localScale.x + scaleValueX, targetObject.transform.localScale.y + scaleValueY), time);
    }
}
