using UnityEngine;
using UnityEngine.InputSystem;
public class parrying : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public InputActionReference parry;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnEnable()
    {
        parry.action.started += Fire;

    }
    public void OnDisable()
    {
        parry.action.started -= Fire;
    }
    public void Fire(InputAction.CallbackContext obj)
    {
        Debug.Log("parry");
        
    }
}
