using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    Boolean hasPackage = false;
    [SerializeField] float delay = 1.0f;

    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    SpriteRenderer spriteRenderer;

    private void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("hit target!");
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        // Debug.Log("Trigger!");
        // Debug.Log(String.Format("Triggered tag: {0}", other.tag));
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Pick up package");
            hasPackage = true;
            Destroy(other.gameObject, delay);
            spriteRenderer.color = hasPackageColor;
        }
        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Deliverd Package");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
