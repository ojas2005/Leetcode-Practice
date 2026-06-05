public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0,TreeNode left=null,TreeNode right=null){this.val=val;this.left=left;this.right=right;}
}
public class Solution
{
    private int diameter=0;
    public int DiameterOfBinaryTree(TreeNode root)
    {
        Depth(root);
        return diameter;
    }
    private int Depth(TreeNode node)
    {
        if(node==null)return 0;
        int l=Depth(node.left);
        int r=Depth(node.right);
        diameter=Math.Max(diameter,l+r);
        return Math.Max(l,r)+1;
    }
}
