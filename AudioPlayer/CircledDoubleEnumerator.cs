using System;
using System.Collections.Generic;

public interface IPreviosEnumerator<T> : IEnumerator<T>
{
    bool MovePrevious();
}

public class CircledDoubleEnumerator<T> : IPreviosEnumerator<T>
{
    private List<T> data = new List<T>();
    private int index = -1;

    public CircledDoubleEnumerator(IEnumerator<T> enumerator)
    {
        if (enumerator != null)
        {
            while (enumerator.MoveNext())
            {
                this.data.Add(enumerator.Current);
            }
            enumerator.Dispose();
        }
    }

    /// <summary>
    /// Add element to enumerator
    /// </summary>
    /// <param name="element">
    /// Element varalible
    /// </param>
    public void addElement(T element)
    {
        this.data.Add(element);
    }

    /// <summary>
    /// Move enumerator to previos value
    /// </summary>
    /// <returns>Return is operation successful</returns>
    public bool MovePrevious()
    {
        if (this.data.Count == 0) return false;

        if (--this.index < 0)
        {
            this.index = (this.data.Count - 1);
        }

        return true;
    }

    /// <summary>
    /// Move enumerator to next value
    /// </summary>
    /// <returns>Return is operation successful</returns>
    public bool MoveNext()
    {
        if (this.data.Count == 0) return false;

        if (++this.index == data.Count)
        {
            this.index = 0;
        }

        return true;
    }

    /// <summary>
    /// Get current object
    /// </summary>
    /// <returns>Return current object</returns>
    public T Current
    {
        get
        {
                if (this.index == -1) return default(T);
                else return this.data[this.index];
            }
    }

    /// <summary>
    /// Is enumator empty?
    /// </summary>
    /// <returns>Return is enumerator empty</returns>
    public bool isEmpty()
    {
        return this.data.Count == 0;
    }

    /// <summary>
    /// Get count of enumator values
    /// </summary>
    /// <returns>Return count of enumarator</returns>
    public int getCount()
    {
        return this.data.Count;
    }

    /// <summary>
    /// Set enumerator index to -1
    /// </summary>
    public void Reset()
    {
        this.index = -1;
    }

    /// <summary>
    /// Clear enumarator data
    /// </summary>
    public void Dispose()
    {
        this.data.Clear();
    }

    object System.Collections.IEnumerator.Current
    {
        get { return Current; }
    }
}