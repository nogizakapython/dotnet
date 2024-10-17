#include <iostream>
using namespace std;
int main(void){
    // 自分の得意な言語で
    // Let's チャレンジ！！
    string ans;
    for(int i=0;i<3;i++){
        string data;
        cin >> data;
        ans += data[0];
    }
    cout << ans << endl;
    return 0;
}
