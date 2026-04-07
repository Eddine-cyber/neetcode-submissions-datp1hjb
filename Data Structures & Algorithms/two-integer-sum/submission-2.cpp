class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        unordered_map<int, int> seen;
        vector<int> v;
        for(int i=0; i< nums.size(); i++){
            if(seen.count(nums[i])){
                if(2 * nums[i] == target){
                    v = {seen[nums[i]], i};
                    return v;
                }else continue;
            }
            seen[nums[i]] = i;
            int other = target-nums[i];
            if(seen.count(other)){
                if(seen[other] != i){
                    v = {seen[other], i};
                    return v;
                }
            }
        }
    }
};
