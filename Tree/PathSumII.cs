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

public class PathSumII
{
    public IList<IList<int>> PathSum(TreeNode root, int targetSum)
    {
        List<IList<int>> paths = new List<IList<int>>();
        FindPaths(root, targetSum, new List<int>(), paths);
        return paths;
    }

    private void FindPaths(TreeNode node, int sum, List<int> currentPath, List<IList<int>> paths)
    {
        if (node == null) return;
        
        currentPath.Add(node.val);
        if (node.left == null && node.right == null && sum == node.val)
        {
            paths.Add(new List<int>(currentPath));
        }
        else
        {
            FindPaths(node.left, sum - node.val, currentPath, paths);
            FindPaths(node.right, sum - node.val, currentPath, paths);
        }
        currentPath.RemoveAt(currentPath.Count - 1);
    }
}
