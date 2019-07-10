using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text winText;
    public Text scoreText;

    private Rigidbody rb;
    private int count;
    private int score;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        score = 0;
        SetCountText ();
        winText.text = "";
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);
         {
            if (Input.GetKey("escape"))
     Application.Quit();

        }
    }
    

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ( "Pick Up"))
        {
            other.gameObject.SetActive (false);
            count = count + 1;
            score = score +1;
            SetCountText ();
        }
        else{
            other.gameObject.CompareTag("Enemy");
            other.gameObject.SetActive(false);
            score = score -1;
            SetCountText();
        }
    }

    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString ();
        if (count >= 24)
        {
            winText.text = "You Win!";
        }
        {
            if (count == 12) //*note that this number should be equal to the number of yellow pickups on the first playfield
{
    transform.position = new Vector3(25.0f, transform.position.y,0.16f); 
}
        }
    }
}