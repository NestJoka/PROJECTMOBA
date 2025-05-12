using UnityEngine;
using Mirror;

public class PlayerController : NetworkBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (isLocalPlayer)
        {
            Debug.Log("✅ PLAYER LOCAL INSTANCIADO!");
            GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            Debug.Log("🔁 Player remoto instanciado.");
            GetComponent<Renderer>().material.color = Color.red;
        }
    }

    void Update()
    {
        if (!isLocalPlayer) return;

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveZ) * moveSpeed * Time.deltaTime;
        rb.MovePosition(transform.position + move);
    }
}
