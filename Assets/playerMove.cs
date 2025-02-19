using UnityEngine;
using UnityEngine.InputSystem;
public class playerMove : MonoBehaviour
{
Rigidbody2D rb2d;
public float speed;
Vector2 moveAmount;
     void Start(){
	rb2d = GetComponent<Rigidbody2D>();
     }
	public void OnMove(InputAction.CallbackContext context){
moveAmount = context.ReadValue<Vector2>();
}
    void Update()
    {
     rb2d.linearVelocity = moveAmount*speed;   
    }
}
