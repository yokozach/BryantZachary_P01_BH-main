using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltVehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public float bulletSpeed;



    public void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += -transform.up * bulletSpeed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player") == true)
        {

            Destroy(gameObject);
        }
    }
}
