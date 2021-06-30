using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class animationStateController : MonoBehaviour
{
    public GameObject projectile;
    Animator animator;
    int isWalkingHash;
    int isRunningHash;
    int isJumpingHash;
    int isFireingHash;
    int firedHash;
    int teleportHash;
    int useHash;
    int deathHash;
    [SerializeField] public Transform groundCheckTransform;
    Transform spine;
    Transform spine1;
    // Start is called before the first frame update
    void Start()
    {
        
        //spine = transform.Find("Spine");
        spine = this.gameObject.transform.GetChild(1);
        spine1 = spine.gameObject.transform.GetChild(1);
      

        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        isJumpingHash = Animator.StringToHash("isJumping");
        isFireingHash = Animator.StringToHash("isChanneling");
        firedHash = Animator.StringToHash("fire");
        teleportHash = Animator.StringToHash("teleport");
        useHash = Animator.StringToHash("use");
        deathHash = Animator.StringToHash("death");

        //teleport

    }
   public IEnumerator Death()
    {

        animator.SetBool(deathHash, true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MainMenu");
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.layer==9)
        {

            StartCoroutine(Death());
        }
        if (col.gameObject.name=="finish")
        {
            animator.SetTrigger("dance");
        }
    }

    // Update is called once per frame
    void Update()
    {
        bool teleport = Input.GetKeyDown("b");
        bool firePressed = Input.GetButtonDown("Fire1");
        bool fireReleased = Input.GetButtonUp("Fire1");
        bool fire = Input.GetKey("v");
        bool forwardPressed = Input.GetKey("d");
        bool backPressed = Input.GetKey("a");
        bool jumpPressed = Input.GetKey("space");
        bool runPressed = Input.GetKey("left shift");
        bool movePressed = forwardPressed || backPressed;
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool use = animator.GetBool(useHash);

        //  bool isJumping = animator.GetBool(isJumpingHash);
        //  isJumping = false;


        


        //use
        IEnumerator Use()
        {

            animator.SetBool(useHash, true);
            yield return new WaitForSeconds(0);

            animator.SetBool(useHash, false);
        }
        if (Input.GetKeyDown("e"))
        {

            StartCoroutine(Use());
        }
        //WALKING
        if (!isWalking && movePressed)
        {
            animator.SetBool(isWalkingHash, true);
        }
        if (isWalking && !movePressed)
        {
            animator.SetBool(isWalkingHash, false);
        }

        //RUNNING
        if (!isRunning && (movePressed && runPressed))
        {
            animator.SetBool(isRunningHash, true);
        }

        if (isRunning && (!movePressed || !runPressed))
        {
            animator.SetBool(isRunningHash, false);
        }

        //TELEPORT
        IEnumerator Teleport ()
                {

                        animator.SetBool(teleportHash, true);
                        yield return new WaitForSeconds(0);

                    animator.SetBool(teleportHash, false);
                }
                if (teleport)
                {

                    StartCoroutine(Teleport());
                }   
       

        //FIRE
        IEnumerator Fire()
        {
            for (int i = 1; i <= 2; i++)
            {
                animator.SetBool(firedHash, true);
                yield return null;
            }
            animator.SetBool(firedHash, false);
        }
        if (firePressed)
        {
            animator.SetBool(isFireingHash, true);
           
     
        }
        if (fireReleased)
        {
            animator.SetBool(isFireingHash, false);

        }
        if (fire)
        {
            StartCoroutine(Fire());
        }

      //finish
     
      
        //TAKE OF
        if (jumpPressed && (Physics.OverlapSphere(groundCheckTransform.position, 0.1f).Length != 1))
        {
            animator.SetTrigger("takeOf");

        }

        //JUMP/LAND
        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f).Length != 1)
        {
            animator.SetBool(isJumpingHash, false);
        }
        else
        {
         animator.SetBool(isJumpingHash, true);
        }
     //   animator.GetCurrentAnimatorStateInfo(0);
        //CHARACTER TRANSFORM ROTATION LEFT/RIGHT
        if (Input.GetKey("a"))
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);

        }
        if (Input.GetKey("d"))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        } 
        //test
        if (Input.GetKeyDown(KeyCode.Y))
        {

        }
    }
}
