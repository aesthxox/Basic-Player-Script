using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class playerscript : MonoBehaviour
{
    int hitpoints;
    public int score;
    public Text chatObject;
    public GameObject winText;
    public GameObject shop;
    public GameObject main;
    public Text dialog;
    public Image Poppy;
    bool talking_to_poppy;
    public GameObject Canvas;
    //bool youWin;

    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
        hitpoints = 3;
        talking_to_poppy = (false);
        //Canvas.SetActive == false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 5 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * 5 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * 5 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * 5 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            transform.Rotate(0.0f, -0.75f, 0.0f);
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            transform.Rotate(0.0f, 0.75f, 0.0f);
        }
        if (hitpoints == 0)
        {
            //Destroy(this.gameObject);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            hitpoints = hitpoints-1;
        }
        if (score == 3)
        {
            winText.SetActive(true);
        }
        if (talking_to_poppy = true)
        {
            Canvas.SetActive(true);
        }
        if (talking_to_poppy = false)
        {
            Canvas.SetActive(false);
        }
        if (Input.GetKey(KeyCode.E))
        {
            talking_to_poppy = (false);
            //Canvas.SetActive == false;

        }

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            score += 1;
            Destroy(other.gameObject);
            chatObject.text = "Coins:" + score;
        }
        if (other.gameObject.CompareTag("danger"))
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.CompareTag("Door"))
        {
            this.transform.position = shop.transform.position;
        }
        if (other.gameObject.CompareTag("Door 2"))
        {
            this.transform.position = main.transform.position;
        }
        if (other.gameObject.CompareTag("shop keep"))
        {
            dialog.text = "Hello!";
            talking_to_poppy = (true);
            //Canvas.SetActive == true;

        }

    }
}

