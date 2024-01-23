using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class ClickSpawner : MonoBehaviour
{
    [SerializeField] protected InputAction spawnAction = new InputAction(type: InputActionType.Button);
    [SerializeField] protected GameObject prefabToSpawn;
    [SerializeField] protected Vector3 velocityOfSpawnedObject;

    [SerializeField] public AudioSource shootSound;

    public float zero = 0f;
    private float timeSinceLastShot;
    [SerializeField] private float shotDelay; // Adjust this value for the desired delay

    void OnEnable()
    {
        spawnAction.Enable();
    }

    void OnDisable()
    {
        spawnAction.Disable();
    }

    protected virtual GameObject spawnObject()
    {
        Debug.Log("Spawning a new object");

        if (shootSound != null)
        {
            shootSound.Play();
        }


        // Step 1: spawn the new object.
        Vector3 positionOfSpawnedObject = transform.position;  // spawn at the containing object position.
        Quaternion rotationOfSpawnedObject = Quaternion.identity;  // no rotation.
        GameObject newObject = Instantiate(prefabToSpawn, positionOfSpawnedObject, rotationOfSpawnedObject);

        // Step 2: modify the velocity of the new object.
        Mover newObjectMover = newObject.GetComponent<Mover>();
        if (newObjectMover)
        {
            newObjectMover.SetVelocity(velocityOfSpawnedObject);
        }

        return newObject;
    }

    private void Start()
    {
        timeSinceLastShot = shotDelay;
    }

    private void Update()
    {

       
        // Update the time since the last shot
        timeSinceLastShot += Time.deltaTime;

        if (spawnAction.WasPressedThisFrame() && timeSinceLastShot >= shotDelay)
        {
            Debug.Log("Button Pressed. Attempting to spawn object.");

            spawnObject();

            // Reset the timer after a shot is fired
            timeSinceLastShot = zero;
        }
    }
}
