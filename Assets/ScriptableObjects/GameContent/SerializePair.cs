using UnityEngine;

[System.Serializable]
public struct SerializablePair<TKey, TValue>
{
    [SerializeField] private TKey key;
    [SerializeField] private TValue value;

    public SerializablePair(TKey key, TValue value)
    {
        this.key = key;
        this.value = value;
    }

    public TKey GetKey()
    {
        return key;
    }
    public TValue GetValue()
    {
        return value;
    }
}