using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    public Vector2 speed = new Vector2(50, 50);

    private Vector2 movement;
	
	void Update () 
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        movement = new Vector2(
          speed.x * inputX,
          speed.y * inputY);

        // 5 - Shooting
        bool shoot = Input.GetButtonDown("Fire1");
        shoot |= Input.GetButtonDown("Fire2");
        // Careful: For Mac users, ctrl + arrow is a bad idea

        if (shoot)
        {
            WeaponScript weapon = GetComponent<WeaponScript>();
            if (weapon != null)
            {
                // false because the player is not an enemy
                weapon.Attack(false);
            }
        }
	}

    void FixedUpdate()
    {
        rigidbody2D.velocity = movement;
    }
}
