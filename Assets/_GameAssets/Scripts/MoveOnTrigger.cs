using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;

public class MoveOnTrigger : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;
    [SerializeField] private float movingValueX;
    [SerializeField] private float movingValueY;
    [SerializeField] private float time;
    [SerializeField] private bool canReturn;

    void OnTriggerEnter2D(Collider2D collision)
    {
        targetObject.transform.DOMove(new Vector3(targetObject.transform.position.x + movingValueX, targetObject.transform.position.y + movingValueY), time);
        if (canReturn)
        {
           StartCoroutine(doReturn()); 
        }
    }

    IEnumerator doReturn()
    {
        yield return new WaitForSeconds(2);
        targetObject.transform.DOMove(new Vector3(targetObject.transform.position.x - movingValueX, targetObject.transform.position.y - movingValueY), time);
    }
}
