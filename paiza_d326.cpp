#include <iostream>
using namespace std;
int main(void){
    // 自分の得意な言語で
    // Let's チャレンジ！！
    string str1;
    int leng_a;
    cin >> str1;
    leng_a = str1.length();
    for(int i=0;i<leng_a;i++){
        string out_str;
        out_str = str1[i];
        cout << out_str << endl;
    }

    return 0;
}
