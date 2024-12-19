using UnityEngine;

public class Dog : Animal
{
    public override void Speak() // POLYMORPHISM
    {
        Debug.Log("Woof! I am a dog.");
    }
    private void Start()
    {
        Name = "Dog";
    }

}
