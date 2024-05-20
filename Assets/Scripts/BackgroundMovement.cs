using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    //bloque del nivel a generar aleatoreamente
    public BackGround levelBack;
    //ultimo bloque colocado
    public BackGround lastLevelBack;

    public BackGround currentLevelBack;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * 2 ;
        AddBackground();
    }

    // Update is called once per frame
    void Update()
    {
        float xcam = Camera.main.transform.position.x;
        float xold = lastLevelBack.exitPoint.position.x;

        if(xcam > xold + lastLevelBack.width / 2){
            MoveBackground();
        }
    }

    private void AddBackground(){
        BackGround back = (BackGround) Instantiate(levelBack);
        back.transform.SetParent(this.transform, false);
        Vector3 posit = Vector3.zero;
        // Debug.Log("-" + backGround.width + "-");
        posit = new Vector3(lastLevelBack.exitPoint.position.x + back.width / 2, lastLevelBack.transform.position.y, lastLevelBack.transform.position.z);
        back.transform.position = posit;
        currentLevelBack = back;
    }

    private void MoveBackground(){
        lastLevelBack.transform.position = new Vector3(lastLevelBack.transform.position.x + lastLevelBack.width * 2, lastLevelBack.transform.position.y, lastLevelBack.transform.position.z);
        BackGround temp = lastLevelBack;
        lastLevelBack = currentLevelBack;
        currentLevelBack = temp;
    }
}
