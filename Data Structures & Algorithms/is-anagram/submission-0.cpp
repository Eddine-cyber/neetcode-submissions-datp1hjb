class Solution {
public:
    bool isAnagram(string s, string t) {
        if (s.size() != t.size()){return false;}
        unordered_map<char, int> seen;
        for(char c : s){
            seen[c] += 1;
        }
        for(char c : t){
            if(seen[c] != 0){seen[c] -=1;}
            else{return false;}
        }
        return true;
        
    }
};
