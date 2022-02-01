using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SIDE { Left, Mid, Right }
public class Character : MonoBehaviour
{
    public SIDE m_Side = SIDE.Mid;
    float NewXPos = 0f;
    public bool SwipeLeft;
    public bool SwipeRight;
    public float XValue=1.9f;
    private CharacterController m_char;

    private Animator m_Animator;
    private float x;
    public float SpeedDodge;

    public GameControl gameControl;

    void Start()
    {
        m_char = GetComponent<CharacterController>();
        m_Animator = GetComponent<Animator>();
        gameControl = GameObject.Find("_Scripts").GetComponent<GameControl>();
        //transform.position = Vector3.zero;
    }


    void Update()
    {
        
        if (gameControl.gameActive)
        {
            SwipeLeft = Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow);
            SwipeRight = Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow);

            if (SwipeLeft)
            {
                if (m_Side == SIDE.Mid)
                {
                    NewXPos = -XValue;
                    m_Side = SIDE.Left;
                    m_Animator.Play("jump-down");
                }
                else if (m_Side == SIDE.Right)
                {
                    NewXPos = 0;
                    m_Side = SIDE.Mid;
                    m_Animator.Play("jump-down");
                }
            }
            else if (SwipeRight)
            {
                if (m_Side == SIDE.Mid)
                {
                    NewXPos = XValue;
                    m_Side = SIDE.Right;
                    m_Animator.Play("jump-down");
                }
                else if (m_Side == SIDE.Left)
                {
                    NewXPos = 0;
                    m_Side = SIDE.Mid;
                    m_Animator.Play("jump-down");
                }
            }
            x = Mathf.Lerp(x, NewXPos, Time.deltaTime * 10f);
            m_char.Move((x - transform.position.x) * Vector3.right);
        }
        
        /*
        if (gameControl.gameActive && Input.GetMouseButton(0))
        {
            SwipeLeft = Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow);
            SwipeRight = Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow);
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (SwipeLeft || mousePos.x < 0)
            {
                if (m_Side == SIDE.Mid)
                {
                    NewXPos = -XValue;
                    m_Side = SIDE.Left;
                    m_Animator.Play("jump-down");
                }
                else if (m_Side == SIDE.Right)
                {
                    NewXPos = 0;
                    m_Side = SIDE.Mid;
                    m_Animator.Play("jump-down");
                }
            }
            else if (SwipeRight || mousePos.x > 0)
            {
                if (m_Side == SIDE.Mid)
                {
                    NewXPos = XValue;
                    m_Side = SIDE.Right;
                    m_Animator.Play("jump-down");
                }
                else if (m_Side == SIDE.Left)
                {
                    NewXPos = 0;
                    m_Side = SIDE.Mid;
                    m_Animator.Play("jump-down");
                }
            }
            x = Mathf.Lerp(x, NewXPos, Time.deltaTime * 10f);
            m_char.Move((x - transform.position.x) * Vector3.right);
        }
        */
    }
}
