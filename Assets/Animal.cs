using UnityEngine;

// INHERITANCE
public class Animal : MonoBehaviour
{
    public string Name { get; set; } // ENCAPSULATION

    public virtual void Speak() // POLYMORPHISM
    {
        Debug.Log("Animal makes a sound");
    }

    public void Move() // ABSTRACTION
    {
        Debug.Log($"{Name} is moving.");
    }
}
