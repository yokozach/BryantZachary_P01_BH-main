using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI HP;
    [SerializeField] int playerHP;
    public GameObject bulletPrefab;

    public PlayerController playerController;
    public float playerSpeed;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerHpSH();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Bolt") == true)
        {

            playerHP -= 1;
        }
    }

    public void playerHpSH()
    {
        HP.text = "player HP: " + playerHP.ToString();

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
            SceneManager.LoadScene(2);
        }
    }
    
}
