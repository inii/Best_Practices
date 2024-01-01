using Fantasy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Fantasy.Entry.Initialize();

        var id = IdFactory.NextEntityId(1024);
        Debug.Log("{  ==============> id factory next entity id: "+ id);
    }


}
