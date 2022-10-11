using UnityEngine;

public class RestartPlane : MonoBehaviour
{
    #region Public Fields
    
    [Tooltip("Where the gameobject should respawn")]
    public Vector3 respawnLocation = new Vector3(0, 0, 0);
    
    [Tooltip("Should destroy enemy gameobject after death?")]
    public bool shouldDestroyEnemy = true;
    
    [Tooltip("The delay time before destroying the enemy gameobject")]
    public float enemyDestroyDelay = 3f;
    
    #endregion
    
    #region Unity Events
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool isPlayer = collision.gameObject.CompareTag("Player");

        if (!isPlayer && !collision.gameObject.CompareTag("Enemy"))
            return;

        //Add Trigger for Being a Bully Achievement
        collision.gameObject.GetComponent<Health>().InstaKill(true);

        if (isPlayer)
            return;
        
        if (shouldDestroyEnemy)
            Destroy(collision.gameObject, enemyDestroyDelay);
        else
            collision.gameObject.SetActive(false);
    }
    
    #endregion
}
