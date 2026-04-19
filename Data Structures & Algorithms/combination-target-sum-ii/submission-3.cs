public class Solution {
    List<List<int>> res = new();
    List<int> curr = new();
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        dfs(0, 0, candidates, target);
        return res;
    }
    private void dfs(int i, int sum, int[] candidates, int target){
        if(sum == target){
            List<int> curr_res = new List<int> (curr);
            res.Add(curr_res);
            return;
        }
        if(i > candidates.Length -1 || sum > target) return ;

        curr.Add(candidates[i]);
        dfs(i+1, sum+candidates[i], candidates, target);
        curr.RemoveAt(curr.Count -1);

        while(i+1 < candidates.Length  && candidates[i] == candidates[i+1]) i++;
        dfs(i+1, sum, candidates, target);

    }
}
