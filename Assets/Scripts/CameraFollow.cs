using UnityEngine;
using Mirror;

public class CameraFollow : NetworkBehaviour
{
    [SerializeField] Vector3 offset = new Vector3(0, 10, -10);
    Camera cam;

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();
        cam = Camera.main;
        cam.transform.SetParent(transform);
        cam.transform.localPosition = offset;
        cam.transform.LookAt(transform);
    }

    void LateUpdate()
    {
        if (!isLocalPlayer || cam == null) return;
        cam.transform.position = transform.position + offset;
    }
}
