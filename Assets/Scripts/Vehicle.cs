// --------------------------------------------------------------------------------
//  Copyright (C) 2023 TwoAmigos
// --------------------------------------------------------------------------------

using UnityEngine;

// ABSTRACTION
public abstract class Vehicle : MonoBehaviour
{
    protected Rigidbody Rigidbody;

    // ENCAPSULATION
    protected abstract float Horsepower { get; }

    protected virtual void Move()
    {
        Rigidbody.AddForce(Vector3.left * Horsepower);
    }

    // Start is called before the first frame update
    protected void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    protected void Update()
    {
        Move();
    }
}