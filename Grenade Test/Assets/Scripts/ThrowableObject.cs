using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public enum ThrowType
{
    ThrownWeak,
    ThrownStrong,
    Launched
}
public class ThrowableObject : MonoBehaviour
{
    [Header("Basic Attributes")]
    public Vector3 throwForce;
    public ThrowType throwType;

    [Header("Explosion Data")]
    public bool hasExplosion;
    public bool explosionRadius;

    private Rigidbody rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    public void Yeet()
    {
        rb.AddForce(throwForce, ForceMode.Impulse);
    }
}
