using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Boss_Stats : MonoBehaviour
{
    [SerializeField] int bossHP = 10000;
    [SerializeField] private GameObject minX;
    [SerializeField] private GameObject maxX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Bullet") == true)
        {

            bossHP -= 1;
        }
    }

    public void Update()
    {
        Debug.Log(bossHP);
        if (bossHP <= 0)
        {

            Death();
            SceneManager.LoadScene(3);
        }
    }

    public void Death()
    {
        Destroy(gameObject);

    }
    public void shotProjection()
    {

       Vector2 horizontalBounds = new Vector2(minX.transform.position.x, maxX.transform.position.x);
    }
    
}
