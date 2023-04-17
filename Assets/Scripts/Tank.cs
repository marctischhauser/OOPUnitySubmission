// --------------------------------------------------------------------------------
//  Copyright (C) 2023 TwoAmigos
// --------------------------------------------------------------------------------

using UnityEngine;

// INHERITANCE
public class Tank : Vehicle
{
    // Start is called before the first frame update
    protected override float Horsepower => 5f;

    // POLYMORPHISM
    protected override void Move()
    {
        Rigidbody.AddForce(Vector3.left * (Horsepower - 1));
    }
}