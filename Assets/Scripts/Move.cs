using System;
using UnityEngine;

public class Move : MonoBehaviour {
    [SerializeField] private GameObject obj;
    [SerializeField] private float jumpVelocity = 5;
    [SerializeField] private float moveVelocity = 5;
    [SerializeField] private LayerMask whatIsGround;
    [SerializeField] private bool isGrounded = false;
    [SerializeField] private ColorsManager.Ecolor defaultColor = ColorsManager.Ecolor.Blue;
    private Rigidbody2D rb;
    private Collider2D  col;
    private Animator    animator;
    private SpriteRenderer spriteRenderer;
    


    private void Awake() {
	    rb = this.GetComponent<Rigidbody2D>();
	    if(rb == null) Debug.Log("not find Rigidbody2D in " + this.name);
	    
	    col = this.GetComponent<Collider2D>();
	    if(col == null) Debug.Log("not find Collider2D in " + this.name);
	    
	    animator = this.GetComponent<Animator>();
	    if(animator == null) Debug.Log("not find Animator in " + this.name);

	    spriteRenderer = GetComponent<SpriteRenderer>();
	    if(spriteRenderer == null) Debug.Log("not find SpriteRenderer in " + this.name);
	    
	    spriteRenderer.color = ColorsManager.Instance.colors[defaultColor];
    }

    // Update is called once per frame
    void Update() {
	    isGrounded = Physics2D.IsTouchingLayers(col, whatIsGround);
	    transform.Translate(Vector2.right * moveVelocity * Time.deltaTime);
	    animator.SetBool("Grounded", isGrounded);
	    //Debug.Log("isGrounded " + isGrounded);

	    if (Input.GetKeyUp(KeyCode.Space)) {
		    Jump();
	    }
    }
    
    public void OnButtonClick() { 
		Jump();
    }

    private static int count = 0;
    ColorsManager.Ecolor beforeColor = ColorsManager.Ecolor.Blue;
    private void Jump() {

	    if(isGrounded)
		    rb.velocity = Vector2.up * jumpVelocity;
	    else {
		    beforeColor = defaultColor;
		    defaultColor++;
		    if (defaultColor == ColorsManager.Ecolor.End) 
			    defaultColor = ColorsManager.Ecolor.Red;
		    spriteRenderer.color = ColorsManager.Instance.colors[defaultColor];
	    }
	    Debug.Log("[" + count + "] BeforeColor: " + beforeColor + " NewColor: " + defaultColor);
	    count++;
//	    Debug.Log("["+ counter + "] isGrounded: " + isGrounded + " color: " + defaultColor);
//
//	    Debug.Log(spriteRenderer.color);
    }
}

 