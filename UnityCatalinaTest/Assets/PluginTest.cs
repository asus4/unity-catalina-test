using System.Runtime.InteropServices;
using UnityEngine;


public class PluginTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");

        _unity_hello();
        int i = _unity_get_square_int(10);

        Debug.Log(i);
    }

    const string DLL_NAME = "UnityCatalinaPlugin";

    [DllImport(DLL_NAME)]
    private static extern void _unity_hello();

    [DllImport(DLL_NAME)]
    private static extern int _unity_get_square_int(int i);

}
