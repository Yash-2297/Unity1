using UnityEngine;
using System.Collections;

public class Delete : MonoBehaviour
{
    public float lifetime;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}