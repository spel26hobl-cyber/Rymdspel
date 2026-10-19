using UnityEngine;

public class Laser_Script : MonoBehaviour
{
    public float laserspeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.up * laserspeed * Time.deltaTime);
    }
}
