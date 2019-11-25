using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movimientoCamaraEntrenamiento : MonoBehaviour
{
    public float speed;
    public GameObject power1;
    public GameObject power2;
    public GameObject power3;
    public GameObject power4;
    public int maxHealth;
    public int health;
    public int damage;
    public int maxMana;
    public int mana;
    public int regMana;
    public SimpleHealthBar healthBar;
    public SimpleHealthBar manaBar;
    public Sprite sprtOn;
    public Sprite sprtOff;
    private bool estadoVida1;
    private bool estadoVida2;
    private bool estadoVida3;
    public GameObject vida1;
    public GameObject vida2;
    public GameObject vida3;

    // Start is called before the first frame update
    void Start()
    {
        estadoVida1 = true;
        estadoVida2 = true;
        estadoVida3 = true;
    }

    // Update is called once per frame
    void Update()
    {

        if(!estadoVida1)
        {
            vida1.GetComponent<Image>().overrideSprite = sprtOff;
        }
        else
        {
            vida1.GetComponent<Image>().overrideSprite = sprtOn;
        }

        if (!estadoVida2)
        {
            vida2.GetComponent<Image>().overrideSprite = sprtOff;
        }
        else
        {
            vida2.GetComponent<Image>().overrideSprite = sprtOn;
        }

        if (!estadoVida3)
        {
            vida3.GetComponent<Image>().overrideSprite = sprtOff;
        }
        else
        {
            vida3.GetComponent<Image>().overrideSprite = sprtOn;
        }

        int tempMana = mana + regMana;

        if (tempMana <= maxMana)
        {
            mana = mana + regMana;
        }
        manaBar.UpdateBar(mana, maxMana);

        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);

        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0,speed*Time.deltaTime*7));
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0,speed * Time.deltaTime * -7));
        }

        if (Input.GetKeyUp(KeyCode.M))
        {
            health = health - damage;
            healthBar.UpdateBar(health, maxHealth);

            if (health <= 0)
            {
                if(estadoVida3)
                {
                    estadoVida3 = false;
                    health = health + maxHealth;
                }
                else if (estadoVida2)
                {
                    estadoVida2 = false;
                    health = health + maxHealth;
                }
                else if(estadoVida1)
                {
                    estadoVida1 = false;
                    health = health + maxHealth;
                }
            }
        }

        //-- 1 --
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Image temp = power1.GetComponent<Image>();
            temp.color = new Color(temp.color.r,temp.color.g,temp.color.b, 0.6f);
        }
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            Image temp = power1.GetComponent<Image>();
            temp.color = new Color(temp.color.r, temp.color.g, temp.color.b, 1f);
            int tempMana1 = mana - 40;
            if (tempMana1 >= 0)
            {
                mana = mana - 40;
            }
        }


        //-- 2 --
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Image temp = power2.GetComponent<Image>();
            temp.color = new Color(temp.color.r, temp.color.g, temp.color.b, 0.6f);
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            Image temp = power2.GetComponent<Image>();
            temp.color = new Color(temp.color.r, temp.color.g, temp.color.b, 1f);
            int tempMana2 = mana - 60;
            if (tempMana2 >= 0)
            {
                mana = mana - 60;
            }
        }

        //-- 3 --
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Image temp = power3.GetComponent<Image>();
            temp.color = new Color(temp.color.r, temp.color.g, temp.color.b, 0.6f);
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            Image temp = power3.GetComponent<Image>();
            temp.color = new Color(temp.color.r, temp.color.g, temp.color.b, 1f);
            int tempMana3 = mana - 80;
            if (tempMana3 >= 0)
            {
                mana = mana - 80;
            }
        }

        //-- 4 --
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Image temp = power4.GetComponent<Image>();
            temp.color = new Color(temp.color.r, temp.color.g, temp.color.b, 0.6f);
        }
        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            Image temp = power4.GetComponent<Image>();
            temp.color = new Color(temp.color.r, temp.color.g, temp.color.b, 1f);
            int tempMana1 = mana - 100;
            if (tempMana1 >= 0)
            {
                mana = mana - 100;
            }
        }

    }
}
