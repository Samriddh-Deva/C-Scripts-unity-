
using UnityEngine;

public class playercollision : MonoBehaviour
{
public player_movement move;


   void OnCollisionEnter(Collision collisionInfo)
{
if(collisionInfo.collider.tag == "over")
{
FindObjectOfType<gamemanager>().EndGame();
}
}}