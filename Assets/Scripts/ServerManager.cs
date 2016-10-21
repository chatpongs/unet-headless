using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Rendering;

public class ServerManager : MonoBehaviour {

	public NetworkManager manager;
	void Awake()
	{
		// If running in headless mode, start the server immediately
		if(SystemInfo.graphicsDeviceType == GraphicsDeviceType.Null)
		{
			manager = GetComponent<NetworkManager>();
			manager.StartServer();
		}
	}
}
