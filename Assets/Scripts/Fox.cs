using UnityEngine;

//INHERITANCE
public class Fox : Animal
{
    //POLYMORPHISM
    protected override void Jump(float jumpForce)
    {
        base.Jump(jumpForce + 40f);
    }
}
