using System;
using System.Collections.Generic;

public class DesignHashMap
{
    private class Node
    {
        public int Key;
        public int Value;
        public Node Next;
        public Node(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }

    private readonly Node[] bucket;
    private const int Size = 10007;

    public DesignHashMap()
    {
        bucket = new Node[Size];
    }

    private int Hash(int key)
    {
        return key % Size;
    }

    public void Put(int key, int value)
    {
        int idx = Hash(key);
        if (bucket[idx] == null)
        {
            bucket[idx] = new Node(-1, -1);
        }
        Node prev = Find(bucket[idx], key);
        if (prev.Next == null)
        {
            prev.Next = new Node(key, value);
        }
        else
        {
            prev.Next.Value = value;
        }
    }

    public int Get(int key)
    {
        int idx = Hash(key);
        if (bucket[idx] == null) return -1;
        Node prev = Find(bucket[idx], key);
        return prev.Next == null ? -1 : prev.Next.Value;
    }

    public void Remove(int key)
    {
        int idx = Hash(key);
        if (bucket[idx] == null) return;
        Node prev = Find(bucket[idx], key);
        if (prev.Next != null)
        {
            prev.Next = prev.Next.Next;
        }
    }

    private Node Find(Node bucketHead, int key)
    {
        Node curr = bucketHead;
        Node prev = null;
        while (curr != null && curr.Key != key)
        {
            prev = curr;
            curr = curr.Next;
        }
        return prev;
    }
}
