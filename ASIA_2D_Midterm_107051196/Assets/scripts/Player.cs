using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject Final;
    public Text TextCount;
    public int count;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "門")

        {
            Final.SetActive(true);
        }
        if (collision.tag == "西瓜")
        {
            Destroy(collision.gameObject);
            count++;
            TextCount.text = "scare:" + count;
        }
    }
       
    
    
	
}
