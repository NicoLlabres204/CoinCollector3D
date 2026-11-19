using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerMoneda : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.AddScore(1);
                Debug.Log("Coin collected! Score: " + GameManager.Instance.score);
            }
            Destroy(gameObject);
        }
    }
}