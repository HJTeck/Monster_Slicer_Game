using UnityEngine;

public class Human : MonoBehaviour
{
    public GameObject humanSlicedPrefab;
    public float humanStartForce = 15f;
    Rigidbody2D rb2;
           
    // Start is called before the first frame update
    void Start()
    {

        rb2 = GetComponent<Rigidbody2D>();
		rb2.AddForce(transform.up * humanStartForce, ForceMode2D.Impulse);

    }

    void OnTriggerEnter2D (Collider2D col2)
    {
        if (col2.tag == "Blade")
        {
            GameObject slicedHuman = Instantiate(humanSlicedPrefab,transform.position,transform.rotation);
          
            Destroy(slicedHuman,3f);
            Destroy(gameObject);

            // sliced human count
            HumanSlicedCount.humanSlicedCount++;
           
        }
        
    }


}
