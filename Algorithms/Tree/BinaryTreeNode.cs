﻿using System;

// binary tree node
public class BinaryTreeNode<T>
{
	private T value;
	private BinaryTreeNode<T> left;
	private BinaryTreeNode<T> right;

	public BinaryTreeNode(T value, BinaryTreeNode<T> left=null, BinaryTreeNode<T> right=null)
	{
		this.value = value;
		this.left = left;
		this.right = right;
	}

	public T Value
    {
		get
		{
			return this.value;
		}
        set
        {
            this.value = value;
        }
	}

	public BinaryTreeNode<T> Left
	{
		get
		{
			return this.left;
		}
		set
		{
			this.left = value;
		}
	}

	public BinaryTreeNode<T> Right
	{
		get
		{
			return this.right;
		}
		set
		{
			this.right = value;
		}
	}

    public void SetChildren(BinaryTreeNode<T> ln, BinaryTreeNode<T> rn) {
        left = ln;
        right = rn;
    }
}
