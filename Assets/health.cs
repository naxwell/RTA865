using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public float cubeHealth = 10;

    public Animator charAnim;
    public float deathTimer = 3;
    public bool isDying = false;
    public GameObject playerPrefab;
    public Transform startingPos;

    public float lastHealth;
    public healthSlider healthBar;
    public Text deadText;
    // Start is called before the first frame update
    void Start()
    {
        lastHealth = cubeHealth;
    }

    // Update is called once per frame
    void Update()
    {

        if (lastHealth != cubeHealth)
        {
            healthBar.SetHealth(cubeHealth);
            lastHealth = cubeHealth;
        }

        if (cubeHealth <= 0)
        {
            charAnim.SetBool("isDead", true);
            isDying = true;
            //Destroy(this.gameObject);
        }

        if (isDying)
        {
            deathTimer -= Time.deltaTime;
            deadText.text = "YOU ARE DEAD";
        }

        if (deathTimer <= 0)
        {

            Dead();
        }
    }

    void Dead()
    {
        deadText.text = "";
        Destroy(this.gameObject);
        Instantiate(playerPrefab, startingPos.position, startingPos.rotation);

    }
}
