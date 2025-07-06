using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllTransforms : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _scaleSpeed;
    private Vector3 one = new Vector3(1f, 1f, 1f);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_rotationSpeed * Vector3.up * Time.deltaTime);
        transform.Translate(_moveSpeed * Vector3.forward * Time.deltaTime);
        transform.localScale += one * _scaleSpeed * Time.deltaTime;
    }
}
