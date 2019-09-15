using UnityEngine;

// Transform.Rotate example
//
// Two cubes are created.  One (red) is rendered using Space.Self.  The
// other (green) uses Space.World.  The rotation is controlled using xAngle,
// yAngle and zAngle. Over time, the cubes rotate differently.

public class Rotate : MonoBehaviour
{
    float speed = 50.0f;
    //public float xAngle, yAngle, zAngle;
    //public Material selfMat, worldMat;

    //public GameObject ring1, ring2;

    void Awake()
    {
        /*ring1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ring1.transform.position = new Vector3(0.75f, 0.0f, 0.0f);
        ring1.GetComponent<Renderer>().material = selfMat;
        ring1.name = "Self";

        ring2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ring2.transform.position = new Vector3(-0.75f, 0.0f, 0.0f);
        ring2.GetComponent<Renderer>().material = worldMat;
        ring2.name = "World";*/
    }

    void Update()
    {
        //ring1.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
        //ring2.transform.Rotate(xAngle, yAngle, zAngle, Space.World);
        //transform.Rotate(Vector3.up * speed * Time.deltaTime);
        transform.Rotate(Vector3.right * speed * Time.deltaTime);
    }
}