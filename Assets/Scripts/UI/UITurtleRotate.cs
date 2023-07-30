
using UnityEngine;

public class UITurtleRotate : MonoBehaviour
{
    [SerializeField]
    private GameObject _turtle;

    public float rotationSpeed = 500.0F;
    private Quaternion originalPos;

    void Start()
    {  //Get the original rotation
        originalPos = transform.rotation;
    }


    public void RotateTurtleDown()
    {
        Vector3 _rotation = new Vector3(0, -10f, 0);
        transform.Rotate(_rotation * rotationSpeed * Time.deltaTime);
    }

    public void RotateTurtleUp()
    {
        Vector3 _rotation = new Vector3(0, 10f, 0);
        transform.Rotate(_rotation * rotationSpeed * Time.deltaTime);
    }

    public void RotateTurtleRight()
    {
        Vector3 _rotation = new Vector3(10f, 0, 0);
        transform.Rotate(_rotation * rotationSpeed * Time.deltaTime);
    }

    public void RotateTurtleLeft()
    {
        Vector3 _rotation = new Vector3(-20f, -0, 0);
        transform.Rotate(_rotation * rotationSpeed * Time.deltaTime);
    }

    public void Home()
    {
        transform.rotation = originalPos;

    }
}