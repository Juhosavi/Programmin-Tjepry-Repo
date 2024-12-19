using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private void Update()
    {
        // Liikkuminen
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * 5;
        float moveZ = Input.GetAxis("Vertical") * Time.deltaTime * 5;

        transform.Translate(new Vector3(moveX, 0, moveZ));
    }

    private void OnTriggerEnter(Collider other)
    {
        Animal animal = other.GetComponent<Animal>();
        if (animal != null)
        {
            Debug.Log($"You triggered {animal.Name}.");
            animal.Speak();
            animal.Move();
        }
    }
}
