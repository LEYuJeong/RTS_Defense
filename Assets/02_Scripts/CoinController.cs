using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using DG.Tweening;

public class CoinController : MonoBehaviour
{

    void Start()
    {
        transform.LookAt(Camera.main.transform.position);
    }

    void Update()
    {
        transform.DOMoveY(9.0f, 2.0f).OnComplete(() => Destroy(gameObject));
    }
}