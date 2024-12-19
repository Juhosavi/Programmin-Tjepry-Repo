using UnityEngine;

public class Cat : Animal
{
    public override void Speak() // POLYMORPHISM
    {
        Debug.Log("Meow! I am a cat.");
    }
    private void Start()
    {
        Name = "Cat";
    }

}
