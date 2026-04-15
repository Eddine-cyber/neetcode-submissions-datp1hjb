public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        if (nums.Length == 0) return new List<List<int>>(){new List<int>()} ;

        List<List<int>> list = new List<List<int>>();
        List<List<int>> subList = Subsets(nums[1..]);
        foreach(List<int> c in subList){
            list.Add(c);
            List<int> newList = new List<int>(c);
            newList.Add(nums[0]);
            list.Add(newList);
        }
        return list;
    }
}
