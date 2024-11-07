
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDeleteScript : MonoBehaviour
{
    GameObject clickedGameObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Debug.Log("”­ŽË");
            clickedGameObject = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hitSprite = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hitSprite.collider != null)
                {
                Debug.Log("–½’†");
                clickedGameObject = hitSprite.transform.gameObject;
                if (clickedGameObject.CompareTag("hukidasi"))
                {
                    Debug.Log("”j‰ó");
                    Destroy(clickedGameObject);
                }
            }
        }
    }
}



