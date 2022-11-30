using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] Transform target;
    Vector3 offset = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position + target.position;
    }

    // Update is called once per frame
    void Update()
    {
        var x = target.position + offset;
        transform.position = new Vector3(x.x,transform.position.y,x.z);
    }
}