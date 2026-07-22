public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0,TreeNode left=null,TreeNode right=null){this.val=val;this.left=left;this.right=right;}
}
public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        if(root==null)return true;
        return Mirror(root.left,root.right);
    }
    private bool Mirror(TreeNode l,TreeNode r)
    {
        if(l==null&&r==null)return true;
        if(l==null||r==null)return false;
        if(l.val!=r.val)return false;
        return Mirror(l.left,r.right)&&Mirror(l.right,r.left);
    }
}
