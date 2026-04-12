class Solution {
public:
    int minEatingSpeed(vector<int>& piles, int h) {
        int sum = accumulate(piles.begin(), piles.end(), 0);
        int min_nbr = ceil(double(sum)/h) , max_nbr = *max_element(piles.begin(), piles.end());
        return dicho(piles, min_nbr, max_nbr, h);

    }

    int dicho(vector<int>& piles, int low, int hight, int h){
        if(low == hight) return low;
        int mid = low + (hight-low)/2;
        int mid_hours = test_nbr_hours(piles, mid);
        if(mid_hours <= h){
            return dicho(piles, low, mid, h);
        }
        else{return dicho(piles, mid+1, hight, h);}
    }


    int test_nbr_hours(vector<int>& piles, int k){
        int sum = 0;
        for(int i=0; i<piles.size(); i++){
            sum += ceil((double)piles[i]/k); 
        }
        return sum;
    }
};
