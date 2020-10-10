using UnityEngine;

public class Monster : MonoBehaviour {

	public GameObject monsterSlicedPrefab;
	public float monsStartForce = 15f;
	Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		rb.AddForce(transform.up * monsStartForce, ForceMode2D.Impulse);
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		
		if (col.tag == "Blade")
		{
			
			GameObject slicedMonster = Instantiate(monsterSlicedPrefab, transform.position, transform.rotation);         

			Destroy(slicedMonster, 3f);
			Destroy(gameObject);
			
			// score
			ScoreCount.scoreCount++;	
						
		}

	}
	
}
