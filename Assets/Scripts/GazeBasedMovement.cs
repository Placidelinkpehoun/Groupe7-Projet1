using UnityEngine;

public class GazeBasedMovement : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public float gazeTimeThreshold = 1.5f;
    private float gazeTimer = 0f;

    private Camera vrCamera;
    private CharacterController characterController;
    private bool isPaused = false;

    void Start()
    {
        vrCamera = Camera.main;
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Touche "Espace" pour pause
        {
            isPaused = !isPaused; // Alterne entre pause et reprise
        }

        if (isPaused) return;

        Vector3 forwardDirection = vrCamera.transform.forward;

        if (Vector3.Angle(forwardDirection, Vector3.up) > 30f)
        {
            gazeTimer += Time.deltaTime;
            if (gazeTimer >= gazeTimeThreshold)
            {
                MoveForward(forwardDirection);
            }
        }
        else
        {
            gazeTimer = 0f;
        }
    }

    void MoveForward(Vector3 direction)
    {
        Vector3 moveDirection = new Vector3(direction.x, 0, direction.z).normalized;
        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }

    public void PauseMovement()
    {
        isPaused = true;
    }

    public void ResumeMovement()
    {
        isPaused = false;
    }
}
