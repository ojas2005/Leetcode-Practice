public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0,TreeNode left=null,TreeNode right=null){this.val=val;this.left=left;this.right=right;}
}
public class Solution
{
    public IList<IList<int>> VerticalTraversal(TreeNode root)
    {
        List<int[]> nodes=new List<int[]>();
        Fill(root,0,0,nodes);
        nodes.Sort((a,b)=>a[0]!=b[0]?a[0]-b[0]:a[1]!=b[1]?a[1]-b[1]:a[2]-b[2]);
        List<IList<int>> res=new List<IList<int>>();
        int prevCol=int.MinValue;
        foreach(var n in nodes)
        {
            if(n[0]!=prevCol)
            {
                res.Add(new List<int>());
                prevCol=n[0];
            }
            res[res.Count-1].Add(n[2]);
        }
        return res;
    }
    private void Fill(TreeNode node,int row,int col,List<int[]> nodes)
    {
        if(node==null)return;
        nodes.Add(new int[]{col,row,node.val});
        Fill(node.left,row+1,col-1,nodes);
        Fill(node.right,row+1,col+1,nodes);
    }
}
