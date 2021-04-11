using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Vector3 mousePos;
    private Vector3 mousePosWorld;
    private Vector2 mousePosWorld2D;
    private Vector2 targetPos;
    private float speed = 0.1f;
    private bool isMoving;

    public Camera mainCamera;
    public GameObject player;
    private Animator playerAnim;
    
    RaycastHit2D hit;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            DetectClick();
        }
    }

    void DetectClick() {
        // mousePos = Input.mousePosition;
        // mousePosWorld = mainCamera.ScreenToWorldPoint(mousePos);
        // mousePosWorld2D = new Vector2(mousePosWorld.x, mousePosWorld.y);

        // hit = Physics2D.Raycast(mousePosWorld2D, Vector2.zero);

        // if (hit.collider != null) {
        //     Debug.Log("PLAYER HIT SOMETHING");
        //     if (hit.collider.gameObject.tag == "Clickable") {
        //         Debug.Log(true);
        //         targetPos = hit.point;
        //         isMoving = true;
        //     }
        // }

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.tag == "Clickable") {
                    targetPos = hit.point;
                    isMoving = true;
                }
            }
        }
    }

    private void FixedUpdate() {
        if (isMoving) {
            Move();
        }

        playerAnim.SetBool("walking", isMoving);
    }

    private void Move() {

        FlipSprite();
        
        player.transform.position = Vector3.MoveTowards(player.transform.position, targetPos, speed);

        if (player.transform.position.x == targetPos.x && player.transform.position.y == targetPos.y) {
            isMoving = false;
        }
    }

    private void FlipSprite() {
        if (player.transform.position.x > targetPos.x) {
            player.GetComponent<SpriteRenderer>().flipX = true;
        } else {
            player.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
