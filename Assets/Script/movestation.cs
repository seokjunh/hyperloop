using UnityEngine;

public class movestation : MonoBehaviour
{
    public Transform station = null;
    public Transform car = null;

    public float speed = 1.0f;

    public bool s = true;
    public bool c = false;

    // Update is called once per frame
    void Update()
    {
        if (s)
        {
            movePlate();
        }
        if (c)
        {
            moveCar();
        }

    }

    public void movePlate()
    {
        station.Translate(Vector3.left * speed * Time.deltaTime);
        car.Translate(Vector3.left * speed * Time.deltaTime);
        if (station.position.x <= -3.499f)
        {
            s = false;
            Invoke("moveCar", 2f);
        }
    }

    public void moveCar()
    {
        c = true;
        car.Translate(Vector3.forward * speed * Time.deltaTime);
        if (car.position.z >= -46.0f)
        {
            c = false;
        }
    }
}
