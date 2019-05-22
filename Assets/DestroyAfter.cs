using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfter : MonoBehaviour
{
    public float timeToDestroy = 2;

    private void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }
}
