#include <iostream>
using namespace std;
int main(void){
    // 自分の得意な言語で
    // Let's チャレンジ！！
    int a,b,c;
    cin >> a >> b >> c;
    int N;
    N = 0;
    N += a;
    N *= b;
    N = N % c;
    cout << N << endl;
    return 0;
}
