using UnityEngine;

public class Atividade3 : MonoBehaviour
{   
    public GameObject peixes;
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(peixes, new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10)), Quaternion.identity);
        }      
        
    }

    void Update()
    {
        
    }
}
