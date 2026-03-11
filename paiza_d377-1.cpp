#include <iostream>
using namespace std;
int main(void){
    // 自分の得意な言語で
    // Let's チャレンジ！！
    string s;
    string ans;
    int m;
    cin >> s;
    m = s.length();
    ans = "";
    for(int i = 0;i<m;i++){
        string d;
        d = s[i];
        if((i != 0) && (i != m - 1)){
            ans += s;
        }
    }
    cout << ans << endl;

    return 0;
}
