using UnityEngine;

[CreateAssetMenu]
public class DataPoints : ScriptableObject
{
    public float up, down, side;

    public BaseClass newBaseClass = new BaseClass();
    
    public DataPoints Output()
    {
        var other = newBaseClass;
        var obj = this;
        obj.down = 5f;
        return obj;
    }
}
