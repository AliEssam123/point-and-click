using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salfhManger : MonoBehaviour
{

    private int currentShelv = 0;
    public GameObject[] shelves;
    public GameObject holder;


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(shelves[0], holder.transform.position, holder.transform.rotation, holder.transform);

    }

    public void Changed(int direction)
    {
        if (currentShelv + direction < 0)
        {
            currentShelv = shelves.Length - 1;
        }
        else if (currentShelv + direction > shelves.Length - 1)
        {
            currentShelv = 0;
        }
        else
        {
            currentShelv = currentShelv + direction;
        }
        Destroy(holder.transform.GetChild(0).gameObject);
        Instantiate(shelves[currentShelv], holder.transform.position, holder.transform.rotation, holder.transform);
    }

}
