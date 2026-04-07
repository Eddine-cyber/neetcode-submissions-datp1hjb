class Solution {
public:
    bool isPalindrome(string s) {
        s = deleteSpaces(s);
        int i = 0, j = s.size() ;
        while (i < j){
            if(s[i] == s[j-1]){
                i++;
                j-=1;
            }else{return false;}
        }return true;
    }

    string deleteSpaces(string& s){
        string res;
        int i = 0;
        while (i < s.size()) {
            if(isalnum(s[i])){res += tolower(s[i]);}
            i++; 
        }return res;
    }
};
