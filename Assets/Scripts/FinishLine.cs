using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public string tagToDetect;

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if(collision.CompareTag(tagToDetect))
        {
            Destroy(collision.gameObject);
        }
	}
}
