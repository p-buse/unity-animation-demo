using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateOnClick : MonoBehaviour
{
   bool selected = false;
   Animator animator; 

   void Start()
   {
       animator = GetComponent<Animator>();
   }
   void OnMouseDown()
   {
       selected = !selected;
       this.animator.SetBool("isSelected", selected);
   }
}