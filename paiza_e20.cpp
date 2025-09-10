#include <iostream>
using namespace std;
int main(void){
    // 自分の得意な言語で
    // Let's チャレンジ！！
    int a,b,c;
    cin >> a >> b >> c;
    int d;
    d = a * b;
    if(d <= c){
        cout << "YES" << endl;
    } else {
        cout << "NO" << endl;
    }
    return 0;
}
