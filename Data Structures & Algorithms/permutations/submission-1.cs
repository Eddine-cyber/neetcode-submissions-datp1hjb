public class Solution {
    /*
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> res = new();
        int n = nums.Length;
        if(n==1){
            res.Add(new List<int>{nums[0]});
            return res;
        } 
        for(int i = 0; i < n; i++){
            int[] curr = new int[n-1] ;
            for(int j = 0; j < i; j++){
                curr[j] = nums[j];
            }
            for(int j = i+1; j<n; j++){
                curr[j-1] = nums[j];
            }
            List<List<int>> newList = Permute(curr);
            foreach(List<int> c in newList){
                c.Add(nums[i]);
                res.Add(c);
            }
        }
        return res;
    }
    */
    public List<List<int>> Permute(int[] nums) {

        List<List<int>> curr_perm = new List<List<int>> {new List<int> ()};
        foreach(int c in nums){
            List<List<int>> new_perm = new();
            foreach(List<int> perm in curr_perm){        
                for(int i= 0; i< perm.Count + 1; i++){
                    List<int> new_list = new List<int> (perm);
                    new_list.Insert(i, c);
                    new_perm.Add(new_list);
                }
            }
            curr_perm = new_perm;
        }
        return curr_perm;
    }
}
