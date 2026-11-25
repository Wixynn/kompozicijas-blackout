using UnityEngine;

public class Collectable : MonoBehaviour
{
    public float rotateSpeed;
    public GameObject collectEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Instantiate(collectEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
