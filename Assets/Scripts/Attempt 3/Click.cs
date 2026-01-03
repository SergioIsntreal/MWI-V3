using UnityEngine;

public class Click : MonoBehaviour
{
    [SerializeField] EmployeeMovement employee;
    [SerializeField] StoreManager storeManager;
    [SerializeField] Transform navPoint;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        storeManager.Clicked(transform);
        employee.target = navPoint.transform;
    }
}
