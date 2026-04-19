public class Solution {
    private List<List<int>> res = new();
    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        dfs(0, new List<int>(), nums);
        return res;
    }

    private void dfs(int i, List<int> curr, int[] nums){
        if(i == nums.Length){
            List<int> newList = new List<int> (curr);
            res.Add(newList);
            return;
        }

        curr.Add(nums[i]);
        dfs(i+1, curr, nums);
        curr.RemoveAt(curr.Count -1);
        
        while( i+1 < nums.Length && nums[i] == nums[i+1]){
            i++;
        }
        
        dfs(i+1, curr, nums);
    }
}
