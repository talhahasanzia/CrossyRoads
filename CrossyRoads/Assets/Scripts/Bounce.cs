using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour {


    float LerpTime;
    float CurrentLerpTime;
    float Pers = 1;

    Vector3 startPos;
    Vector3 endPos;

	
	// Update is called once per frame
	void Update () {

       

            if (Pers == 1)
            {

                LerpTime = 1;
                CurrentLerpTime = 0;
            
            }


            startPos = gameObject.transform.position;

            if (Input.GetKeyUp(KeyCode.UpArrow) && gameObject.transform.position==endPos)
            {

                endPos = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
            
            
            
            }
            if (Input.GetKeyUp(KeyCode.DownArrow) && gameObject.transform.position == endPos)
            {

                endPos = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);



            }
            if (Input.GetKeyUp(KeyCode.LeftArrow) && gameObject.transform.position == endPos)
            {

                endPos = new Vector3(transform.position.x , transform.position.y, transform.position.z+1);



            }
            if (Input.GetKeyUp(KeyCode.RightArrow) && gameObject.transform.position == endPos)
            {

                endPos = new Vector3(transform.position.x , transform.position.y, transform.position.z-1);



            }
            CurrentLerpTime += Time.deltaTime*5.5f;
            Pers = CurrentLerpTime / LerpTime;

            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, endPos, Pers);
        


	}
}
