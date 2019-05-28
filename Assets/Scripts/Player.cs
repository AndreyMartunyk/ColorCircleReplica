using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float jumpForse = 10f;
    public Rigidbody2D rb;
    public SpriteRenderer sr;


    public eColor currentCollor;


    void Start()
    {
        SetRandomColor();
    }

    public void SetRandomColor()
    {
        eColor prewColor = currentCollor;


        do
        {
            GameColor color = FindObjectOfType<ColorManager>().GetColor(Random.Range(0, 4));
            sr.color = color.color;
            currentCollor = color.name;
            Debug.Log("Truing to getcolor");

            
        } while (currentCollor == prewColor);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0) 
        || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            rb.velocity = Vector2.up * jumpForse;

        }
        
    }

  

    //private void OnTriggerEnter2D(Collider2D coll)
    //{
    //    if (coll.tag == "Finish")
    //    {
    //        SceneManager.LoadScene(1);
    //        return;
    //    }
    //    if (coll.tag == "ColorChanger")
    //    {
    //        SetRandomColor();
    //        Destroy(coll.gameObject);
    //        return;
    //    }
    //    if (coll.tag == "Untagged")
    //    {
    //        return;
    //    }

    //    if (coll.tag != currentCollor)
    //    {
    //        Die();
    //    } 
        
    //}

    public void Die()
    {
        Debug.Log("GAME OVER!!");
        GameHelper.RestartScene();       
    }

    
}
