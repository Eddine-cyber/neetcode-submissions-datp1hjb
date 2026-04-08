class Solution {
public:
    int maxArea(vector<int>& heights) {
        int i=0, j= heights.size()-1;
        int max_water = 0;
        while(i < j){
            int water = (j-i)* min(heights[i],heights[j]);
            if (water > max_water){
                max_water = water;     
            }
            if(heights[i] < heights[j]){i++;}
            else{j--;}
        }
        return max_water;
    }
};
