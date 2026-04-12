class Solution {
public:
    int search(vector<int>& nums, int target) {
        return search_(nums, target, 0, nums.size()-1);
    }

    int search_(vector<int>& nums, int target, int low, int hight){
        cout << "search_: " << "low  " << low << "  hight  " << hight << endl;
        if(low == hight){
            if(nums[low] == target) return low;
            else return -1; 
        }
        if(nums[low]<=nums[hight]){return find_in_assendent(nums, target, low, hight);}
        else{
            int mid = low + (hight-low)/2;
            if(nums[low] <= nums[mid]){
                if(nums[low] <= target &&  target <= nums[mid]) return find_in_assendent(nums, target, low, mid);  
                else return search_(nums, target, mid+1, hight);
            }else{
                if(nums[mid+1] <= target &&  target <= nums[hight]) return find_in_assendent(nums, target, mid+1, hight);  
                else return search_(nums, target, low, mid);
            }
        }
    }

    int find_in_assendent(vector<int>& nums, int target, int low, int hight){
        cout << "find_in_assendent: " << "low  " << low << "  hight  " << hight << endl;
        if(low == hight){
            if(nums[low] == target) return low;
            else return -1; 
        }
        int mid = low + (hight-low)/2;
        if(nums[low] <= target &&  target <= nums[mid]) return find_in_assendent(nums, target, low, mid);
        else return find_in_assendent(nums, target, mid+1, hight);
    }
};
