/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool jump = false;


    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.1f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }
        else
        {
            jump = false;
        }
        if(jump == true)
        {
            anim.SetBool("isJump", jump);
            transform.Translate(0, 0.1f, 0.1f);
        }
    }
}
*/
using System.Collections;
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
}
