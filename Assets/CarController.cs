using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

    static public float speedX = 0;
    private Vector2 startPos;
    private Vector2 endPos;
    private float swipeLength = 0;
    Animator animator;

	// Use this for initialization
	void Start () {
        this.animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            this.endPos = Input.mousePosition;
            swipeLength = this.startPos.x - this.endPos.x;

            //x座標スワイプで走行
            //タップ、もしくは右方向へスワイプ
            if (this.endPos.x >= this.startPos.x || this.endPos.x == this.startPos.x)
            {
                speedX = 3.0f;
                GetComponent<AudioSource>().Play();
            }else
            {
                speedX = swipeLength / 50.0f;
                GetComponent<AudioSource>().Play();
            }
        }
        transform.Translate(speedX, 0, 0);
        speedX *= 0.99f;
        this.animator.speed = speedX * 0.5f;
	}

}
