using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public int damageCount = 10;

    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(ApplyDamage());
    }

    IEnumerator ApplyDamage()
    {
        // Assuming PlayerManager is a MonoBehaviour attached to a GameObject
        PlayerManager playerManager = FindObjectOfType<PlayerManager>();

        if (playerManager != null)
        {
            // Call the Damage coroutine from PlayerManager
            yield return playerManager.StartCoroutine(playerManager.Damage(damageCount));
        }
    }
}
