using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour {


    float LerpTime;
    float CurrentLerpTime;
    float Perc = 1;

    Vector3 startPos;
    Vector3 endPos;

    bool fInput;
    public static bool Jump;
	// Update is called once per frame
	void Update () {
        Debug.Log("Jump: " + Jump);
      
            if (Perc == 1)
            {

                LerpTime = 1;
                CurrentLerpTime = 0;
                fInput = true;
                
            }
        

            startPos = gameObject.transform.position;

            if (Input.GetKeyDown(KeyCode.RightArrow) && gameObject.transform.position == endPos)
            {
                Jump = true;
                endPos = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);



            }
            if (Input.GetKeyDown(KeyCode.LeftArrow) && gameObject.transform.position == endPos)
            {
                Jump = true;
                endPos = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);



            }
            if (Input.GetKeyDown(KeyCode.UpArrow) && gameObject.transform.position == endPos)
            {
                Jump = true;

                endPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);



            }
            if (Input.GetKeyDown(KeyCode.DownArrow) && gameObject.transform.position == endPos)
            {
                Jump = true;
                endPos = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);



            }
            CurrentLerpTime += Time.deltaTime * 5f;
            Perc = CurrentLerpTime / LerpTime;


            if (fInput)
            {
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, endPos, Perc);

                if (Perc > 0.8)
                {

                    Perc = 1;

                }
                if (Mathf.Round(Perc) == 1)
                {

                    //Jump = false;
                }
            }
        

	}
}
