using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public float velocity = 1.0f;
    public float velocityRighLeft = 1.0f;
    public FixedJoystick joystick;
    private int life = 50;
    public Text life_state;
    public int jumpForce = 300;
    private JumpButtonScript jumpButtonScript;
    private bool isJumping = false;
    public AudioClip damageClip;
    public AudioClip jumpSound;
    public AudioClip velociticlip;
    private AudioSource audioSource;


    void Start()
    {
        print("Start life = " + life);
        life_state.text = life.ToString();
        jumpButtonScript = GameObject.Find("bJump").GetComponent<JumpButtonScript>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.position += new Vector3(velocity * Time.deltaTime, 0, -(joystick.Direction.x * velocity * Time.deltaTime));
        jump();

    }
    private void jump()
    {
        if (jumpButtonScript.isPressed && !isJumping)
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>(); audioSource.PlayOneShot(jumpSound);
            rb.AddForce(Vector3.up * jumpForce);
            jumpButtonScript.isPressed = false;
            //isJumping = true;
            jumpButtonScript.gameObject.SetActive(false);
        }
    }

    public void updateLife(int puntos)
    {
        life += puntos; audioSource.PlayOneShot(velociticlip);
        print("Current life = " + life); 
        life_state.text = life.ToString();

    }


    private void OnCollisionEnter(Collision collision)
    {
        DamageScript damageScript = collision.gameObject.GetComponent<DamageScript>(); audioSource.PlayOneShot(damageClip);

        if (damageScript != null)
        {
            // Проверяем, достигло ли здоровье значения 0
            if (life <= 0)
            {
                
                // Assume you have a variable containing the scene name
                string gameOverScene = "GameOver";
                SceneManager.LoadScene(gameOverScene);
            }
           
        }
    }
}