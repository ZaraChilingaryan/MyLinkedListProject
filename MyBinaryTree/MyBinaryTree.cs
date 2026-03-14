using System.Collections;
using binarytreeproj;


namespace BinaryTreeProject;

public class MyBinaryTree<T> : IEnumerable<T>
    where T : IComparable<T>
{
    private BinaryTreeNode<T> _head;
    private int _count;

    public int Count
    {
        get { return _count; }
    }

    public bool Contains(T value)
    {
        BinaryTreeNode<T> current = _head;

        while (current != null)
        {
            int result = value.CompareTo(current.Value);

            if (result == 0)
                return true;

            if (result < 0)
                current = current.Left;
            else
                current = current.Right;
        }

        return false;
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}