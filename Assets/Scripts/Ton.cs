using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // get the game object moving
        //GetComponent<Rigidbody2D>().AddForce(
        // new Vector2(10, 5),
        // ForceMode2D.Impulse);

        // get object moving
        const float MinImpulseForce = 3f;
        const float MaxImpulseForce = 5f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            direction*magnitude,
            ForceMode2D.Impulse);
    }
    /// <summary>
    /// called when the cube hits the floor
    /// </summary>
    /// <param name="col">collision info</param>
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Ouch!");
    }


}
