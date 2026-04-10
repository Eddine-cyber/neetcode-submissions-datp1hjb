class Solution {
public:
    int search(vector<int>& nums, int target){
        return search_index(nums, target, 0, nums.size()-1);
    }

    int search_index(vector<int>& nums, int target, int min_index, int max_index) {
        int n = max_index - min_index +1;
        if(n == 1){
            if(target == nums[min_index]) return min_index;
            else return -1;
            }
        if(target <= nums[min_index + (n-1)/2]){
            return search_index(nums, target, min_index, min_index + (n-1)/2);}
        else{
            return search_index(nums, target, min_index + n/2, min_index + n-1);}
    }
 
};
