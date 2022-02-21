using UnityEngine;
using System.Collections;

public class AlienC : MonoBehaviour 
{
	public float attackDelay = 3f;
	public AlienCProjectile projectile;
	private Animator animator;
	public AudioClip pickupSound;

	// Use this for initialization
	void Start () 
	{
		animator = GetComponent<Animator> ();
		if (attackDelay > 0) 
		{
			StartCoroutine(OnAttack());
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		animator.SetInteger ("AnimState", 0);
	}

	IEnumerator OnAttack()
	{
		yield return new WaitForSeconds(attackDelay);
		Fire ();
		StartCoroutine (OnAttack ());
	}

	void Fire()
	{
		animator.SetInteger ("AnimState", 1);
		if(pickupSound)
			AudioSource.PlayClipAtPoint(pickupSound, transform.position);
	}

	void OnShoot(){
		if (projectile) {
			AlienCProjectile clone = Instantiate (projectile, transform.position, Quaternion.identity) as AlienCProjectile;
		}
	}
}
