using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGrenades : MonoBehaviour
{
    public GameObject sphereGrenade;
    public void ThrowObject(GameObject grenade)
    {
        GameObject thing = Instantiate(grenade, transform.position, transform.rotation);
        Rigidbody thingRb = thing.GetComponent<Rigidbody>();
        ThrowableObject thingProperties = thing.GetComponent<ThrowableObject>();
        thingRb.AddRelativeForce(thingProperties.throwForce, ForceMode.Impulse);

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ThrowObject(sphereGrenade);
        }
    }
}
