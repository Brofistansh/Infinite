using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool jump = false;
    public bool slide = false;



    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.3f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }
        else
        {
            jump = false;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            slide = true;
        }
        else
        {
            slide = false;
        }
        if (jump == true)
        {
            anim.SetBool("isJump", jump);
            transform.Translate(0, 0.3f, 0.1f);
        }
        else if(jump == false)
        {
            anim.SetBool("isJump", jump);
        }
        if (slide == true)
        {
            anim.SetBool("isSlide", slide);
            transform.Translate(0, 0f, 0.1f);
        }
        else if (slide == false)
        {
            anim.SetBool("isSlide", slide);
        }
    }
}

/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private bool isJumping = false;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        transform.Translate(0, 0, 0.1f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            anim.SetBool("isJump", true);
            StartCoroutine(ResetJumpAnimation());
        }

        if (isJumping)
        {
            transform.Translate(0, 0.1f, 0.1f);
        }
    }

    IEnumerator ResetJumpAnimation()
    {
        yield return new WaitForSeconds(0.5f);
        isJumping = false;
        anim.SetBool("isJump", false);
    }
}*/
