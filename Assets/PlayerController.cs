using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent
(typeof(Rigidbody), typeof (BoxCollider))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Animator _animator;

    [SerializeField] private float _moveSpeed;

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _joystick.Vertical * _moveSpeed);

        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
        }
       
    }

    private void OnTriggerEnter(Collider other)
   {
   if(this.CompareTag("Player") && other.CompareTag("Finish"))
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    } 
     if(this.CompareTag("Player") && other.CompareTag("floppa"))
    {
        SceneManager.LoadScene("Menu");
    } 
    if(this.CompareTag("Player") && other.CompareTag("Secret"))
    {
        SceneManager.LoadScene("Secret");
    } 
    if(this.CompareTag("Player") && other.CompareTag("l1"))
    {
        SceneManager.LoadScene("L1");
    } 
    if(this.CompareTag("Player") && other.CompareTag("l"))
    {
        SceneManager.LoadScene("l");
    } 
    if(this.CompareTag("Player") && other.CompareTag("l2"))
    {
        SceneManager.LoadScene("L2");
    } 
    if(this.CompareTag("Player") && other.CompareTag("l3"))
    {
        SceneManager.LoadScene("L3");
    } 
    if(this.CompareTag("Player") && other.CompareTag("l4"))
    {
        SceneManager.LoadScene("L4");
    } 
    if(this.CompareTag("Player") && other.CompareTag("l5"))
    {
        SceneManager.LoadScene("L5");
    } 
    if(this.CompareTag("Player") && other.CompareTag("l6"))
    {
        SceneManager.LoadScene("L6");
    } 
    if(this.CompareTag("Player") && other.CompareTag("l7"))
    {
        SceneManager.LoadScene("L7");
    } 
    if(this.CompareTag("Player") && other.CompareTag("l8"))
    {
        SceneManager.LoadScene("L8");
    } 
    if(this.CompareTag("Player") && other.CompareTag("l8"))
    {
        SceneManager.LoadScene("L8");
    } 
    if(this.CompareTag("Player") && other.CompareTag("GG"))
    {
        SceneManager.LoadScene("GG1");
    } 
    if(this.CompareTag("Player") && other.CompareTag("GG2"))
    {
        SceneManager.LoadScene("Game 5");
    }
    if(this.CompareTag("Player") && other.CompareTag("yi"))
    {
        SceneManager.LoadScene("Game 4");
    }  
   }
  
   
}
