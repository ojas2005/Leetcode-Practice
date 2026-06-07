using System.Collections.Generic;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class BinaryTreeLevelOrderTraversal
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        List<IList<int>> result = new List<IList<int>>();
        if (root == null) return result;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            List<int> currentLevel = new List<int>();

            for (int i = 0; i < levelSize; i++)
            {
                TreeNode curr = queue.Dequeue();
                currentLevel.Add(curr.val);

                if (curr.left != null) queue.Enqueue(curr.left);
                if (curr.right != null) queue.Enqueue(curr.right);
            }
            result.Add(currentLevel);
        }

        return result;
    }
}
