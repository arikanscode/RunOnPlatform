using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public GameObject go;
    private Rigidbody rg;
    private CharacterController m_char;

    public GameControl gameControl;

    void Start()
    {
        rg = go.GetComponent<Rigidbody>();
        m_char = GetComponent<CharacterController>();
        gameControl = GameObject.Find("_Scripts").GetComponent<GameControl>();
    }
    
    void Update()
    {
        if (gameControl.gameActive)
        {
            go.transform.Translate(0f, 0f, 0.12f);

        }
        
        if (Input.GetKeyDown(KeyCode.F)&&m_char.isGrounded==true)
        {
            rg.AddForce(new Vector3(0, 5f, 0), ForceMode.Impulse);
        }
         /*
         float x = Input.GetAxis("Horizontal");
        // float y = Input.GetAxis("Vertical");

         x *= Time.deltaTime * hiz ;
        // y *= Time.deltaTime * hiz;

         go.transform.Translate(x, 0f, 0f);
         */
    }
}
