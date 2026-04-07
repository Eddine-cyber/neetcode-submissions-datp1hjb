class Solution {
public:

    string encode(vector<string>& strs) {
        string s ;
        for(int i=0; i < strs.size(); i++){
            string element = strs[i];
            s = s +  to_string(element.size()) + '#' + element;
        }
        return s;
    }

    vector<string> decode(string s) {
        vector<string> strs;
        int k = 0;
        for(int i = 0; i < s.size(); i+= 1){
            string stri = "";
            if(s[i] == '#') {
                int lenght = stoi(s.substr(k,i-k));
                if(lenght == 0){stri = "";}
                else{for (int j = 0; j < lenght; j++){
                    stri += s[i + 1 + j];
                }} 
                k = i + lenght + 1;
                i = k;
                strs.push_back(stri);
            }
        }
        return strs;
    }
};
