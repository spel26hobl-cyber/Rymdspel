using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Player_Movement : MonoBehaviour
{
    public float playerSpeed;
    public GameObject Lasershot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.transform.position = new Vector2(0, -1);
        if (Input.GetKey(KeyCode.Space))    
        {
            Instantiate(Lasershot, this.transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 10)
            this.transform.position = transform.position = new Vector2(0, 1);
        if (transform.position.x < -10)
            this.transform.position = transform.position = new Vector2(0, 1);
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * playerSpeed * Time.deltaTime);
        }
    }
}
