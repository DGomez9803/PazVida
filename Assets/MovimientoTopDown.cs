using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTopDown : MonoBehaviour
{
    public float velocidadMovimiento;
    

    public Rigidbody2D rb2D;
    public Animator animator;
    private Vector2 direccion;
    private float movimientoX;
    private float movimientoY;   
    public Joystick joystick;
    private void Update(){
        

        //movimientoX = Input.GetAxisRaw("Horizontal");
        //movimientoY = Input.GetAxisRaw("Vertical");
        movimientoX = joystick.Horizontal* velocidadMovimiento;
        movimientoY = joystick.Vertical* velocidadMovimiento;
        animator.SetFloat("MovimientoX", movimientoX);
        animator.SetFloat("MovimientoY", movimientoY);
        if(movimientoX !=0 || movimientoY!=0)
        {
            animator.SetFloat("UltimoX",movimientoX);
            animator.SetFloat("UltimoY",movimientoY);
        }
      direccion = new Vector2(movimientoX,movimientoY).normalized;
    }

    private void FixedUpdate()
    {
      
        rb2D.MovePosition(rb2D.position + direccion * velocidadMovimiento);
    }
   
}
