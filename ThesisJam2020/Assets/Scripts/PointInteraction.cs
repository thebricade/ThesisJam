using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointInteraction : MonoBehaviour
{
    private SpriteEffect _spriteEffect, _spriteEffectPair;

    public GameObject pairObject;

     
    
   // public GameObject mainWindowOutline;
    
    //This script will be for objects that you can interactive wit3-----------
    //h and trigger different cameras effects (zoom) or cuts depending on the object 
    
    // Start is called before the first frame update
    void Start()
    {
        _spriteEffect = gameObject.AddComponent<SpriteEffect>();
        _spriteEffectPair = pairObject.AddComponent<SpriteEffect>();
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        _spriteEffect.numberAssignment(0.2f,SpriteEffect.EffectType.FadeImage,0);
        _spriteEffectPair.numberAssignment(0.2f,SpriteEffect.EffectType.ShowImage,0);
        //if(this.GetComponent<SpriteRenderer>().color)
        
    }

    public void attack()
    {
        
        // pairObject.GetComponent<Transform>().position = 2; 
    }
}
