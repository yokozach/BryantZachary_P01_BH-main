using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    public Scene_state_machine scene_;
    public Image HealhBar; 
    
    [SerializeField] int playerHP;
    public GameObject bulletPrefab;
    private float MaxplayerHP=5f;

    public PlayerController playerController;
    public float playerSpeed;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
     
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Bolt") == true)
        {

            playerHP -= 1;
            audioSource.Play();
            HealhBar.fillAmount = playerHP / MaxplayerHP;
        }
    }

    
    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (playerController.joystickVec.y != 0)
        {

            rb.velocity = new Vector2(playerController.joystickVec.x * playerSpeed, playerController.joystickVec.y * playerSpeed);
        }
        else
        {
            
            rb.velocity = Vector2.zero;
        }


    }
   void Update()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);

        if (playerHP <= 0)
        {
            Debug.Log("Dead");
            scene_.looser();
            
        }
    }
    
}
