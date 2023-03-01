using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class Boss_Stats : MonoBehaviour
{

    public Image HealhBar_EN;
    public Scene_state_machine scene;
    [SerializeField] float bossHP = 10000f;
    private float MaxbossHP = 10000f;
    [SerializeField] private GameObject minX;
    [SerializeField] private GameObject maxX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Bullet") == true)
        {

            bossHP -= 1;
            HealhBar_EN.fillAmount = bossHP / MaxbossHP;
        }
    }

    public void Update()
    {
        Debug.Log(bossHP);
        if (bossHP <= 0)
        {

            Death();
           
        }
    }

    public void Death()
    {
       
        scene.winner();
    }
    public void shotProjection()
    {

       //Vector2 horizontalBounds = new Vector2(minX.transform.position.x, maxX.transform.position.x);
    }
    
}
