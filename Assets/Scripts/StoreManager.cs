using UnityEngine;

public class StoreManager : MonoBehaviour
{
    [SerializeField] EmployeeMovement[] employees;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clicked(Transform item)
    {
        foreach (var employee in employees)
        {
            if(employee.status == Status.Idle)
            {
                employee.target = item;
            }
        }
    }
}
