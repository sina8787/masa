using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public float moveSpeed = 3f; // Speed of NPC movement

    void Update()
    {
        // Call the MoveNPC function to handle NPC movement
        MoveNPC();
    }

    void MoveNPC()
    {
        // Calculate the NPC's new position
        Vector3 newPosition = transform.position + transform.forward * moveSpeed * Time.deltaTime;

        // Move the NPC
        transform.position = newPosition;
    }
}

