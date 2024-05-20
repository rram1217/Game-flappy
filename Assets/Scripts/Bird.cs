using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public float speed = 2;
    public float force = 300;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || Input.GetMouseButtonDown(0) ){
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //restart level
        //Application.LoadLevel(Application.loadedLevel);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
        SceneManager.LoadScene(0);
    }

    /*
        Si usas las versiones más nuevas de Unity, el LoadLevel verás que está obsoleto. Simplemente deberás cambiar dicha línea por
        SceneManager.LoadScene("nombre de la escena a recargar");
        y añadir en la parte superior del script
        using UnityEngine.SceneManagement;
    */
}
