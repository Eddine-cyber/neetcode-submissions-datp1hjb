class Solution {
public:
    vector<int> dailyTemperatures(vector<int>& temperatures) {
        int i = temperatures.size()-1;
        vector<int> temps_heap;
        vector<int> res(temperatures.size());
        temps_heap.push_back(0);
        for(int i = 1; i<temperatures.size(); i++){
            while(temperatures[temps_heap.back()] < temperatures[i] && temps_heap.size() > 0){
                res[temps_heap.back()] = i - temps_heap.back();
                temps_heap.pop_back();
            }
            temps_heap.push_back(i);
        }

        return res;

    }
};
