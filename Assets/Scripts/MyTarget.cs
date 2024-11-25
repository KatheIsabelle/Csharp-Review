using UnityEngine;
//Coletando informações sobre determinado target.
//Alterando propriedades sobre um determinado target
public class MyTarget : MonoBehaviour
{
    public GameObject ObjectTarget;
    public GameObject BG;

    void Start()
    {
        // Pegando a posição, rotação and escala do objeto
        Vector3 position = ObjectTarget.transform.position; // Get the position of the object
        Vector3 rotation = ObjectTarget.transform.rotation.eulerAngles; // Get the rotation of the object
        Vector3 scale = ObjectTarget.transform.localScale; // Get the scale of the object

        Debug.Log("Posição do objeto " + position.x + " , " + position.y + " , " + position.z);
        Debug.Log("Rotação do objeto " + rotation.x + " , " + rotation.y + " , " + rotation.z);
        Debug.Log("Escala do objeto " + scale.x + " , " + scale.y + " , " + scale.z);


        //Alterando características do objeto
        ObjectTarget.GetComponent<SpriteRenderer>().color = Color.blue;
        BG.GetComponent<SpriteRenderer>().color = Color.yellow;

        //Alterando a posição do objeto
        ObjectTarget.transform.position = new Vector3(7f, 0, 0); // eixo x = 9, eixo y = 0, eixo z = 0

        
    }

    void Update()
    {   

    }

}
