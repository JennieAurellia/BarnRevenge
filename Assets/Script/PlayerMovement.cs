using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    [SerializeField] private EntityPlayer entityPlayer;
    [SerializeField] private float speed;

    void Start()
    {
        entityPlayer = GetComponent<EntityPlayer>();
        speed = entityPlayer.MoveSpeed;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        var x = horizontalInput * speed * Time.deltaTime;

        float verticalInput = Input.GetAxis("Vertical");
        var y = verticalInput * speed * Time.deltaTime;

        var xyz = new Vector3(x, y, 0f);
        transform.Translate(xyz);
    }
}
