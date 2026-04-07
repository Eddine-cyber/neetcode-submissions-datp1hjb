class Solution {
public:
    vector<int> topKFrequent(vector<int>& nums, int k) {
    unordered_map<int, int> m;
    for(int i=0; i< nums.size(); i++){
        m[nums[i]] += 1;
    }
    priority_queue<pair<int, int>, vector<pair<int, int>>, greater<pair<int,int>> > q;
    for(auto s : m){
        q.push({s.second, s.first});
        if(q.size() > k){q.pop();}
    }
    vector<int> v;
    while(!q.empty()){
        auto s = q.top();
        v.push_back(s.second);
        q.pop();
    }
    return v;
    }
};
