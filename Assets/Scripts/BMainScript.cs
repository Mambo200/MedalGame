using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BMainScript : MonoBehaviour
{
    // Start is called before the first frame update
    protected virtual void Start()
    {
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }



    public virtual void GetDamage(float _damage, BMainScript _damageCauser)
    {
        Debug.LogWarning("This object does not overwrite the \"GetDamage(float, BMainScript)\" method!", this.gameObject);
    }

    public virtual void GetDamage(int _damage, BMainScript _damageCauser)
    {
        Debug.LogWarning("This object does not overwrite the \"GetDamage(int, BMainScript)\" method!", this.gameObject);
    }
}
