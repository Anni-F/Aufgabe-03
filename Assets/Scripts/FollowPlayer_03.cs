using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer_03 : MonoBehaviour
{

    public GameObject player;

    public Vector3 offset = new Vector3(-121, 6, 155);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Vektor3 hier, weil die Kamera nicht direkt Pos. des Spielers, soll Abstand zu Auto. Kamera vorher auf 0, 0, 0 setzen
        transform.position = player.transform.position + offset;
    }
}
