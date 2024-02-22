using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ConversationStarter : MonoBehaviour
{
    [SerializeField] private NPCConversation myConversation;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            if(Input.GetKeyDown(KeyCode.L))
            {
                ConversationManager.Instance.StartConversation(myConversation);
                Debug.Log("dialogStarted");
            }
        }
        
    }
}
