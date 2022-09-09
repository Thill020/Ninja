using UnityEngine;

public class ItemDropEffectRocket : MonoBehaviour
{
    #region Serialized Fields
    [SerializeField] private bool rotate = true;
    [SerializeField] private float rocketDistance = 2;
    [SerializeField] private float rocketSpeed = 4;
    [SerializeField] private float rotationSpeed = 2;
    #endregion

    #region Private Fields
    private Rigidbody2D _rigidbody;
    private bool _impulseApplied;
    private bool _applyImpulse;
    private bool _torqueApplied;
    private bool _applyTorque;
    #endregion
    
    #region Unity Events
    // Start is called before the first frame update
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _impulseApplied = false;
        _torqueApplied = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (!isActiveAndEnabled)
            return;
        
        if(!_impulseApplied)
            _applyImpulse = true;

        if (!rotate)
            return;
        
        if (!_torqueApplied)
            _applyTorque = true;
    }

    private void FixedUpdate()
    {
        RocketEffectFixedUpdate();
        RotationEffectFixedUpdate();
    }
    #endregion

    #region Fixed Update Methods
    private void RocketEffectFixedUpdate()
    {
        if (!_applyImpulse || _impulseApplied)
            return;

        _applyImpulse = false;
        _impulseApplied = true;
        _rigidbody.AddForce(new Vector2(0, rocketDistance * rocketSpeed), ForceMode2D.Impulse);
    }

    private void RotationEffectFixedUpdate()
    {
        if (!_applyTorque || _torqueApplied)
            return;

        _applyTorque = false;
        _torqueApplied = true;
        _rigidbody.AddTorque(_rigidbody.position.y * rotationSpeed, ForceMode2D.Impulse);
    }
    #endregion
}
