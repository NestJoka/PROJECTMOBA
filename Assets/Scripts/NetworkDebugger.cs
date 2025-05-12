using UnityEngine;
using Mirror;

public class NetworkDebugger : MonoBehaviour
{
    void Update()
    {
        if (NetworkClient.isConnected)
        {
            Debug.Log("🟢 Client está conectado ao Host");
        }
        else if (NetworkClient.active)
        {
            Debug.Log("🟡 Tentando conectar ao Host...");
        }
    }
}
