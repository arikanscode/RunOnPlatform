using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    Rigidbody rb;
    public AudioClip coinVoice, hitVoice;
    public GameControl gameControl;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameControl = GameObject.Find("_Scripts").GetComponent<GameControl>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("coin"))
        {
            AudioSource.PlayClipAtPoint(coinVoice, transform.position);
            Destroy(collision.gameObject);
            gameControl.addGold();
            
        }
        else if (collision.gameObject.tag.Equals("barrier"))
        {
            AudioSource.PlayClipAtPoint(hitVoice, transform.position);
            gameControl.gameActive = false;
            gameControl.lostText.gameObject.SetActive(true);
            Time.timeScale = 0; 


        }
    }

}
