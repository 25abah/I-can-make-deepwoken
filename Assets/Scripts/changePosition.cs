using UnityEngine;

public class changePosition : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject player;
    private Transform playerTransform;
    private Transform transForm;
    public Vector3 offset;
    void Start()
    {
         playerTransform = player.transform;
         transForm = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transForm.position = playerTransform.position + offset;
    }
}
