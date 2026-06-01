public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0,TreeNode left=null,TreeNode right=null){this.val=val;this.left=left;this.right=right;}
}
public class Solution
{
    private int idx=0;
    public TreeNode BstFromPreorder(int[] preorder)
    {
        return Build(preorder,int.MaxValue);
    }
    private TreeNode Build(int[] preorder,int bound)
    {
        if(idx==preorder.Length||preorder[idx]>bound)return null;
        TreeNode root=new TreeNode(preorder[idx++]);
        root.left=Build(preorder,root.val);
        root.right=Build(preorder,bound);
        return root;
    }
}
