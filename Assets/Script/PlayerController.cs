using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float HorizontalValue; 

    [SerializeField] private float forwardSpeed;
    [SerializeField] private float Horizontalspeed;
    [SerializeField] private float horizontalLimitValue;

    private float newPositionX;
    void Update()
    {
        PlayerHorizontalInput();
    }

    void FixedUpdate()
    {
        playerForwardMovement();
        PlayerHorizontalMovement();
    }

    private void playerForwardMovement()
    {
        transform.Translate(Vector3.back* forwardSpeed* Time.fixedDeltaTime);
    }

    private void PlayerHorizontalMovement()
    {
        newPositionX = transform.position.x + HorizontalValue * Horizontalspeed * Time.fixedDeltaTime;
        newPositionX = Mathf.Clamp(newPositionX , -horizontalLimitValue,horizontalLimitValue);
        transform.position = new Vector3(newPositionX,transform.position.y , transform.position.z);
    }

    private void PlayerHorizontalInput()
    {
        if (Input.GetMouseButton(0))
        {
            HorizontalValue = -Input.GetAxis("Mouse X");
        }
        else
        {
            HorizontalValue = 0;
        }
    }
}
